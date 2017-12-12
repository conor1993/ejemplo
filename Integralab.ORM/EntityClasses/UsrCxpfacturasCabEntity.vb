' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 1 de diciembre de 2017 15:44:18
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
	''' <summary>Entity class which represents the entity 'UsrCxpfacturasCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class UsrCxpfacturasCabEntity 
#Else
	<Serializable()> _
	Public Class UsrCxpfacturasCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _usrCxppagosProveedores As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
		Private _alwaysFetchUsrCxppagosProveedores, _alreadyFetchedUsrCxppagosProveedores As Boolean
		Private _usrCxpfacturasDet As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
		Private _alwaysFetchUsrCxpfacturasDet, _alreadyFetchedUsrCxpfacturasDet As Boolean
		Private _usrCxpfacturasDetRecepciones As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
		Private _alwaysFetchUsrCxpfacturasDetRecepciones, _alreadyFetchedUsrCxpfacturasDetRecepciones As Boolean
		Private _cuentaContableCollectionViaUsrCxpfacturasDet As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet, _alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet As Boolean
		Private _proveedor As ProveedorEntity
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor, _proveedorReturnsNewIfNotFound As Boolean


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
		''' <param name="empresaId">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		Public Sub New(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String)

			InitClassFetch(empresaId, idProveedor, noFactura, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(empresaId, idProveedor, noFactura, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="validator">The custom validator Object for this UsrCxpfacturasCabEntity</param>
		Public Sub New(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, validator As IValidator)

			InitClassFetch(empresaId, idProveedor, noFactura, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_usrCxppagosProveedores = CType(info.GetValue("_usrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection)), Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection)
			_alwaysFetchUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchUsrCxppagosProveedores")
			_alreadyFetchedUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedUsrCxppagosProveedores")
			_usrCxpfacturasDet = CType(info.GetValue("_usrCxpfacturasDet", GetType(Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection)), Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection)
			_alwaysFetchUsrCxpfacturasDet = info.GetBoolean("_alwaysFetchUsrCxpfacturasDet")
			_alreadyFetchedUsrCxpfacturasDet = info.GetBoolean("_alreadyFetchedUsrCxpfacturasDet")
			_usrCxpfacturasDetRecepciones = CType(info.GetValue("_usrCxpfacturasDetRecepciones", GetType(Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection)), Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection)
			_alwaysFetchUsrCxpfacturasDetRecepciones = info.GetBoolean("_alwaysFetchUsrCxpfacturasDetRecepciones")
			_alreadyFetchedUsrCxpfacturasDetRecepciones = info.GetBoolean("_alreadyFetchedUsrCxpfacturasDetRecepciones")
			_cuentaContableCollectionViaUsrCxpfacturasDet = CType(info.GetValue("_cuentaContableCollectionViaUsrCxpfacturasDet", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet")
			_alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet")
			_proveedor = CType(info.GetValue("_proveedor", GetType(ProveedorEntity)), ProveedorEntity)
			If Not _proveedor Is Nothing Then
				AddHandler _proveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_proveedorReturnsNewIfNotFound = info.GetBoolean("_proveedorReturnsNewIfNotFound")
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedUsrCxppagosProveedores = (_usrCxppagosProveedores.Count > 0)
			_alreadyFetchedUsrCxpfacturasDet = (_usrCxpfacturasDet.Count > 0)
			_alreadyFetchedUsrCxpfacturasDetRecepciones = (_usrCxpfacturasDetRecepciones.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet = (_cuentaContableCollectionViaUsrCxpfacturasDet.Count > 0)
			_alreadyFetchedProveedor = Not(_proveedor Is Nothing)

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
			info.AddValue("_usrCxppagosProveedores", _usrCxppagosProveedores)
			info.AddValue("_alwaysFetchUsrCxppagosProveedores", _alwaysFetchUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedUsrCxppagosProveedores", _alreadyFetchedUsrCxppagosProveedores)
			info.AddValue("_usrCxpfacturasDet", _usrCxpfacturasDet)
			info.AddValue("_alwaysFetchUsrCxpfacturasDet", _alwaysFetchUsrCxpfacturasDet)
			info.AddValue("_alreadyFetchedUsrCxpfacturasDet", _alreadyFetchedUsrCxpfacturasDet)
			info.AddValue("_usrCxpfacturasDetRecepciones", _usrCxpfacturasDetRecepciones)
			info.AddValue("_alwaysFetchUsrCxpfacturasDetRecepciones", _alwaysFetchUsrCxpfacturasDetRecepciones)
			info.AddValue("_alreadyFetchedUsrCxpfacturasDetRecepciones", _alreadyFetchedUsrCxpfacturasDetRecepciones)
			info.AddValue("_cuentaContableCollectionViaUsrCxpfacturasDet", _cuentaContableCollectionViaUsrCxpfacturasDet)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet", _alwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet", _alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet)
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_proveedorReturnsNewIfNotFound", _proveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)

			
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
				Case "UsrCxppagosProveedores"
					_alreadyFetchedUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.UsrCxppagosProveedores.Add(CType(entity, UsrCxppagosProveedoresEntity))
					End If
				Case "UsrCxpfacturasDet"
					_alreadyFetchedUsrCxpfacturasDet = True
					If Not entity Is Nothing Then
						Me.UsrCxpfacturasDet.Add(CType(entity, UsrCxpfacturasDetEntity))
					End If
				Case "UsrCxpfacturasDetRecepciones"
					_alreadyFetchedUsrCxpfacturasDetRecepciones = True
					If Not entity Is Nothing Then
						Me.UsrCxpfacturasDetRecepciones.Add(CType(entity, UsrCxpfacturasDetRecepcionesEntity))
					End If
				Case "CuentaContableCollectionViaUsrCxpfacturasDet"
					_alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaUsrCxpfacturasDet.Add(CType(entity, CuentaContableEntity))
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
				Case "UsrCxppagosProveedores"

				Case "UsrCxpfacturasDet"
					_usrCxpfacturasDet.Add(CType(relatedEntity, UsrCxpfacturasDetEntity))
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
				Case "Proveedor"
					DesetupSyncProveedor(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCxppagosProveedores"

				Case "UsrCxpfacturasDet"
					MyBase.PerformRelatedEntityRemoval(_usrCxpfacturasDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _proveedor Is Nothing Then
				toReturn.Add(_proveedor)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_usrCxppagosProveedores)
			toReturn.Add(_usrCxpfacturasDet)
			toReturn.Add(_usrCxpfacturasDetRecepciones)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String) As Boolean
			Return FetchUsingPK(empresaId, idProveedor, noFactura, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(empresaId, idProveedor, noFactura, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(empresaId, idProveedor, noFactura, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.EmpresaId, Me.IdProveedor, Me.NoFactura, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As UsrCxpfacturasCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As UsrCxpfacturasCabFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxppagosProveedoresEntity'</returns>
		Public Function GetMultiUsrCxppagosProveedores(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			Return GetMultiUsrCxppagosProveedores(forceFetch, _usrCxppagosProveedores.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrCxppagosProveedores(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			Return GetMultiUsrCxppagosProveedores(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxppagosProveedoresEntity'</returns>
		Public Function GetMultiUsrCxppagosProveedores(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			Return GetMultiUsrCxppagosProveedores(forceFetch, _usrCxppagosProveedores.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCxppagosProveedores(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			If ( Not _alreadyFetchedUsrCxppagosProveedores Or forceFetch Or _alwaysFetchUsrCxppagosProveedores) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCxppagosProveedores.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCxppagosProveedores)
					End If
				End If
				_usrCxppagosProveedores.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCxppagosProveedores.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCxppagosProveedores.GetMultiManyToOne(Nothing, Nothing, Nothing, Filter)
				_usrCxppagosProveedores.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCxppagosProveedores = True
			End If
			Return _usrCxppagosProveedores
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCxppagosProveedores'. These settings will be taken into account
		''' when the property UsrCxppagosProveedores is requested or GetMultiUsrCxppagosProveedores is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCxppagosProveedores(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCxppagosProveedores.SortClauses=sortClauses
			_usrCxppagosProveedores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasDetEntity'</returns>
		Public Function GetMultiUsrCxpfacturasDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			Return GetMultiUsrCxpfacturasDet(forceFetch, _usrCxpfacturasDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrCxpfacturasDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			Return GetMultiUsrCxpfacturasDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasDetEntity'</returns>
		Public Function GetMultiUsrCxpfacturasDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			Return GetMultiUsrCxpfacturasDet(forceFetch, _usrCxpfacturasDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCxpfacturasDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			If ( Not _alreadyFetchedUsrCxpfacturasDet Or forceFetch Or _alwaysFetchUsrCxpfacturasDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCxpfacturasDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCxpfacturasDet)
					End If
				End If
				_usrCxpfacturasDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCxpfacturasDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCxpfacturasDet.GetMultiManyToOne(Nothing, Me, Filter)
				_usrCxpfacturasDet.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCxpfacturasDet = True
			End If
			Return _usrCxpfacturasDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCxpfacturasDet'. These settings will be taken into account
		''' when the property UsrCxpfacturasDet is requested or GetMultiUsrCxpfacturasDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCxpfacturasDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCxpfacturasDet.SortClauses=sortClauses
			_usrCxpfacturasDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_usrCxpfacturasDetRecepciones.GetMultiManyToOne(Nothing, Me, Filter)
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
	
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaUsrCxpfacturasDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaUsrCxpfacturasDet(forceFetch, _cuentaContableCollectionViaUsrCxpfacturasDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaUsrCxpfacturasDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet Or forceFetch Or _alwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaUsrCxpfacturasDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaUsrCxpfacturasDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(UsrCxpfacturasCabEntity.Relations.UsrCxpfacturasDetEntityUsingEmpresaIdIdProveedorNoFactura, "__UsrCxpfacturasCabEntity__", "UsrCxpfacturasDet_", JoinHint.None)
				relations.Add(UsrCxpfacturasDetEntity.Relations.CuentaContableEntityUsingCuentaContableId, "UsrCxpfacturasDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.EmpresaId), ComparisonOperator.Equal, Me.EmpresaId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.IdProveedor), ComparisonOperator.Equal, Me.IdProveedor))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.NoFactura), ComparisonOperator.Equal, Me.NoFactura))
				_cuentaContableCollectionViaUsrCxpfacturasDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaUsrCxpfacturasDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaUsrCxpfacturasDet.GetMulti(Filter, relations)
				_cuentaContableCollectionViaUsrCxpfacturasDet.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet = True
			End If
			Return _cuentaContableCollectionViaUsrCxpfacturasDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaUsrCxpfacturasDet'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaUsrCxpfacturasDet is requested or GetMultiCuentaContableCollectionViaUsrCxpfacturasDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaUsrCxpfacturasDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaUsrCxpfacturasDet.SortClauses=sortClauses
			_cuentaContableCollectionViaUsrCxpfacturasDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(UsrCxpfacturasCabEntity.Relations.ProveedorEntityUsingIdProveedor) Then
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
	
	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(UsrCxpfacturasCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, UsrCxpfacturasCabFieldIndex)

					Case UsrCxpfacturasCabFieldIndex.IdProveedor
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
			_usrCxppagosProveedores.ActiveContext = MyBase.ActiveContext
			_usrCxpfacturasDet.ActiveContext = MyBase.ActiveContext
			_usrCxpfacturasDetRecepciones.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaUsrCxpfacturasDet.ActiveContext = MyBase.ActiveContext
		If Not _proveedor Is Nothing Then
				_proveedor.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As UsrCxpfacturasCabDAO = CType(CreateDAOInstance(), UsrCxpfacturasCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As UsrCxpfacturasCabDAO = CType(CreateDAOInstance(), UsrCxpfacturasCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As UsrCxpfacturasCabDAO = CType(CreateDAOInstance(), UsrCxpfacturasCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this UsrCxpfacturasCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.UsrCxpfacturasCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="validator">The validator Object for this UsrCxpfacturasCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(empresaId, idProveedor, noFactura, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_usrCxppagosProveedores = New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection(New UsrCxppagosProveedoresEntityFactory())
			_usrCxppagosProveedores.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchUsrCxppagosProveedores = False
			_alreadyFetchedUsrCxppagosProveedores = False
			_usrCxpfacturasDet = New Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection(New UsrCxpfacturasDetEntityFactory())
			_usrCxpfacturasDet.SetContainingEntityInfo(Me, "UsrCxpfacturasCab")
			_alwaysFetchUsrCxpfacturasDet = False
			_alreadyFetchedUsrCxpfacturasDet = False
			_usrCxpfacturasDetRecepciones = New Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection(New UsrCxpfacturasDetRecepcionesEntityFactory())
			_usrCxpfacturasDetRecepciones.SetContainingEntityInfo(Me, "UsrCxpfacturasCab")
			_alwaysFetchUsrCxpfacturasDetRecepciones = False
			_alreadyFetchedUsrCxpfacturasDetRecepciones = False
			_cuentaContableCollectionViaUsrCxpfacturasDet = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet = False
			_alreadyFetchedCuentaContableCollectionViaUsrCxpfacturasDet = False
			_proveedor = Nothing
			_proveedorReturnsNewIfNotFound = True
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EmpresaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaVencimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Anticipo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdMotivoCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Saldo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Gastos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Servicios", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TasaIva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TasaIsr", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TasaRetIva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteIsr", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteRetIva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Concepto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Contabilizada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Uuid", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Ieps", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _proveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", UsrCxpfacturasCabEntity.Relations.ProveedorEntityUsingIdProveedor, True, signalRelatedEntity, "UsrCxpfacturasCab", resetFKFields, New Integer() { CInt(UsrCxpfacturasCabFieldIndex.IdProveedor) } )
			_proveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _proveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedor(relatedEntity As IEntity)
			DesetupSyncProveedor(True, True)
			_proveedor = CType(relatedEntity, ProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", UsrCxpfacturasCabEntity.Relations.ProveedorEntityUsingIdProveedor, True, _alreadyFetchedProveedor, New String() {  } )
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



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasCab which data should be fetched into this UsrCxpfacturasCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(UsrCxpfacturasCabFieldIndex.EmpresaId)).ForcedCurrentValueWrite(empresaId)
				MyBase.Fields(CInt(UsrCxpfacturasCabFieldIndex.IdProveedor)).ForcedCurrentValueWrite(idProveedor)
				MyBase.Fields(CInt(UsrCxpfacturasCabFieldIndex.NoFactura)).ForcedCurrentValueWrite(noFactura)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateUsrCxpfacturasCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New UsrCxpfacturasCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As UsrCxpfacturasCabRelations
			Get	
				Return New UsrCxpfacturasCabRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxppagosProveedores' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection(), _
					UsrCxpfacturasCabEntity.Relations.UsrCxppagosProveedoresEntityUsingEmpresaIdIdProveedorNoFactura, _
					CType(Integralab.ORM.EntityType.UsrCxpfacturasCabEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxppagosProveedoresEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxpfacturasDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxpfacturasDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection(), _
					UsrCxpfacturasCabEntity.Relations.UsrCxpfacturasDetEntityUsingEmpresaIdIdProveedorNoFactura, _
					CType(Integralab.ORM.EntityType.UsrCxpfacturasCabEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxpfacturasDetEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxpfacturasDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxpfacturasDetRecepciones' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxpfacturasDetRecepciones() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection(), _
					UsrCxpfacturasCabEntity.Relations.UsrCxpfacturasDetRecepcionesEntityUsingEmpresaIdIdProveedorNoFactura, _
					CType(Integralab.ORM.EntityType.UsrCxpfacturasCabEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxpfacturasDetRecepcionesEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxpfacturasDetRecepciones", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaUsrCxpfacturasDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(UsrCxpfacturasCabEntity.Relations.UsrCxpfacturasDetEntityUsingEmpresaIdIdProveedorNoFactura, "__UsrCxpfacturasCabEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrCxpfacturasDetEntity.Relations.CuentaContableEntityUsingCuentaContableId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					UsrCxpfacturasCabEntity.Relations.UsrCxpfacturasDetEntityUsingEmpresaIdIdProveedorNoFactura, _
					CType(Integralab.ORM.EntityType.UsrCxpfacturasCabEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaUsrCxpfacturasDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					UsrCxpfacturasCabEntity.Relations.ProveedorEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.UsrCxpfacturasCabEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "UsrCxpfacturasCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return UsrCxpfacturasCabEntity.CustomProperties
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
				Return UsrCxpfacturasCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The EmpresaId property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."EmpresaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [EmpresaId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.EmpresaId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.EmpresaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProveedor property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."IdProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdProveedor]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdProveedor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdProveedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The NoFactura property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."NoFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 40<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [NoFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.NoFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.NoFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaFactura property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."FechaFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaFactura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaVencimiento property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."FechaVencimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaVencimiento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaVencimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaVencimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTotal property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."SubTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.SubTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.SubTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Iva property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."IVA"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Iva]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Iva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Iva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Total, Integer), value)
			End Set
		End Property
	
		''' <summary>The Anticipo property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Anticipo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Anticipo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Anticipo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Anticipo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdMotivoCancelacion property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."IdMotivoCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdMotivoCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdMotivoCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdMotivoCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdUsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Saldo property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Saldo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Saldo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Saldo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Saldo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Gastos property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Gastos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Gastos]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Gastos, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Gastos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Servicios property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Servicios"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Servicios]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Servicios, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Servicios, Integer), value)
			End Set
		End Property
	
		''' <summary>The TasaIva property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."TasaIva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TasaIva]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.TasaIva, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.TasaIva, Integer), value)
			End Set
		End Property
	
		''' <summary>The TasaIsr property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."TasaISR"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TasaIsr]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.TasaIsr, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.TasaIsr, Integer), value)
			End Set
		End Property
	
		''' <summary>The TasaRetIva property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."TasaRetIva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TasaRetIva]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.TasaRetIva, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.TasaRetIva, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteIsr property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."ImporteISR"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ImporteIsr]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.ImporteIsr, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.ImporteIsr, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteRetIva property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."ImporteRetIva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ImporteRetIva]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.ImporteRetIva, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.ImporteRetIva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Concepto property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Concepto"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Concepto]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Concepto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Concepto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Contabilizada property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Contabilizada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Contabilizada]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Contabilizada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Contabilizada, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaContabilizacion property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."FechaContabilizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaContabilizacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaContabilizacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.FechaContabilizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoliza property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."IdPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdPoliza]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdPoliza, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.IdPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Uuid property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."UUID"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 40<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Uuid]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Uuid, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Uuid, Integer), value)
			End Set
		End Property
	
		''' <summary>The Ieps property of the Entity UsrCxpfacturasCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasCab"."Ieps"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Ieps]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasCabFieldIndex.Ieps, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasCabFieldIndex.Ieps, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCxppagosProveedores()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCxppagosProveedores]() As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			Get
				Return GetMultiUsrCxppagosProveedores(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCxppagosProveedores. When set to true, UsrCxppagosProveedores is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCxppagosProveedores is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCxppagosProveedores(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCxppagosProveedores As Boolean
			Get
				Return _alwaysFetchUsrCxppagosProveedores
			End Get
			Set
				_alwaysFetchUsrCxppagosProveedores = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCxpfacturasDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCxpfacturasDet]() As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			Get
				Return GetMultiUsrCxpfacturasDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCxpfacturasDet. When set to true, UsrCxpfacturasDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCxpfacturasDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCxpfacturasDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCxpfacturasDet As Boolean
			Get
				Return _alwaysFetchUsrCxpfacturasDet
			End Get
			Set
				_alwaysFetchUsrCxpfacturasDet = value
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
	
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaUsrCxpfacturasDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaUsrCxpfacturasDet]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaUsrCxpfacturasDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaUsrCxpfacturasDet. When set to true, CuentaContableCollectionViaUsrCxpfacturasDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaUsrCxpfacturasDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaUsrCxpfacturasDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaUsrCxpfacturasDet = value
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
							_proveedor.UnsetRelatedEntity(Me, "UsrCxpfacturasCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "UsrCxpfacturasCab")
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
				Return CInt(Integralab.ORM.EntityType.UsrCxpfacturasCabEntity)
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
