' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 24 de enero de 2018 11:05:17
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
	''' <summary>Entity class which represents the entity 'Bancos'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class BancosEntity 
#Else
	<Serializable()> _
	Public Class BancosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _chequeDevuelto As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
		Private _alwaysFetchChequeDevuelto, _alreadyFetchedChequeDevuelto As Boolean
		Private _chequesPos As Integralab.ORM.CollectionClasses.ChequesPosCollection
		Private _alwaysFetchChequesPos, _alreadyFetchedChequesPos As Boolean
		Private _proveedorAvanzado As Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection
		Private _alwaysFetchProveedorAvanzado, _alreadyFetchedProveedorAvanzado As Boolean
		Private _pagoCheDevueltoCab As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
		Private _alwaysFetchPagoCheDevueltoCab, _alreadyFetchedPagoCheDevueltoCab As Boolean
		Private _cuenta As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuenta, _alreadyFetchedCuenta As Boolean
		Private _tipoProveedorCollectionViaProveedorAvanzado As Integralab.ORM.CollectionClasses.TipoProveedorCollection
		Private _alwaysFetchTipoProveedorCollectionViaProveedorAvanzado, _alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado As Boolean
		Private _tipoMonedaCollectionViaCuenta As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaCuenta, _alreadyFetchedTipoMonedaCollectionViaCuenta As Boolean
		Private _cuentaContableCollectionViaCuenta As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaCuenta, _alreadyFetchedCuentaContableCollectionViaCuenta As Boolean



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
		''' <param name="codigo">PK value for Bancos which data should be fetched into this Bancos Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Bancos which data should be fetched into this Bancos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Bancos which data should be fetched into this Bancos Object</param>
		''' <param name="validator">The custom validator Object for this BancosEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_chequeDevuelto = CType(info.GetValue("_chequeDevuelto", GetType(Integralab.ORM.CollectionClasses.ChequeDevueltoCollection)), Integralab.ORM.CollectionClasses.ChequeDevueltoCollection)
			_alwaysFetchChequeDevuelto = info.GetBoolean("_alwaysFetchChequeDevuelto")
			_alreadyFetchedChequeDevuelto = info.GetBoolean("_alreadyFetchedChequeDevuelto")
			_chequesPos = CType(info.GetValue("_chequesPos", GetType(Integralab.ORM.CollectionClasses.ChequesPosCollection)), Integralab.ORM.CollectionClasses.ChequesPosCollection)
			_alwaysFetchChequesPos = info.GetBoolean("_alwaysFetchChequesPos")
			_alreadyFetchedChequesPos = info.GetBoolean("_alreadyFetchedChequesPos")
			_proveedorAvanzado = CType(info.GetValue("_proveedorAvanzado", GetType(Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection)), Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection)
			_alwaysFetchProveedorAvanzado = info.GetBoolean("_alwaysFetchProveedorAvanzado")
			_alreadyFetchedProveedorAvanzado = info.GetBoolean("_alreadyFetchedProveedorAvanzado")
			_pagoCheDevueltoCab = CType(info.GetValue("_pagoCheDevueltoCab", GetType(Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection)), Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection)
			_alwaysFetchPagoCheDevueltoCab = info.GetBoolean("_alwaysFetchPagoCheDevueltoCab")
			_alreadyFetchedPagoCheDevueltoCab = info.GetBoolean("_alreadyFetchedPagoCheDevueltoCab")
			_cuenta = CType(info.GetValue("_cuenta", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuenta = info.GetBoolean("_alwaysFetchCuenta")
			_alreadyFetchedCuenta = info.GetBoolean("_alreadyFetchedCuenta")
			_tipoProveedorCollectionViaProveedorAvanzado = CType(info.GetValue("_tipoProveedorCollectionViaProveedorAvanzado", GetType(Integralab.ORM.CollectionClasses.TipoProveedorCollection)), Integralab.ORM.CollectionClasses.TipoProveedorCollection)
			_alwaysFetchTipoProveedorCollectionViaProveedorAvanzado = info.GetBoolean("_alwaysFetchTipoProveedorCollectionViaProveedorAvanzado")
			_alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado = info.GetBoolean("_alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado")
			_tipoMonedaCollectionViaCuenta = CType(info.GetValue("_tipoMonedaCollectionViaCuenta", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaCuenta = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaCuenta")
			_alreadyFetchedTipoMonedaCollectionViaCuenta = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaCuenta")
			_cuentaContableCollectionViaCuenta = CType(info.GetValue("_cuentaContableCollectionViaCuenta", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaCuenta = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaCuenta")
			_alreadyFetchedCuentaContableCollectionViaCuenta = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaCuenta")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedChequeDevuelto = (_chequeDevuelto.Count > 0)
			_alreadyFetchedChequesPos = (_chequesPos.Count > 0)
			_alreadyFetchedProveedorAvanzado = (_proveedorAvanzado.Count > 0)
			_alreadyFetchedPagoCheDevueltoCab = (_pagoCheDevueltoCab.Count > 0)
			_alreadyFetchedCuenta = (_cuenta.Count > 0)
			_alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado = (_tipoProveedorCollectionViaProveedorAvanzado.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaCuenta = (_tipoMonedaCollectionViaCuenta.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaCuenta = (_cuentaContableCollectionViaCuenta.Count > 0)


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
			info.AddValue("_chequeDevuelto", _chequeDevuelto)
			info.AddValue("_alwaysFetchChequeDevuelto", _alwaysFetchChequeDevuelto)
			info.AddValue("_alreadyFetchedChequeDevuelto", _alreadyFetchedChequeDevuelto)
			info.AddValue("_chequesPos", _chequesPos)
			info.AddValue("_alwaysFetchChequesPos", _alwaysFetchChequesPos)
			info.AddValue("_alreadyFetchedChequesPos", _alreadyFetchedChequesPos)
			info.AddValue("_proveedorAvanzado", _proveedorAvanzado)
			info.AddValue("_alwaysFetchProveedorAvanzado", _alwaysFetchProveedorAvanzado)
			info.AddValue("_alreadyFetchedProveedorAvanzado", _alreadyFetchedProveedorAvanzado)
			info.AddValue("_pagoCheDevueltoCab", _pagoCheDevueltoCab)
			info.AddValue("_alwaysFetchPagoCheDevueltoCab", _alwaysFetchPagoCheDevueltoCab)
			info.AddValue("_alreadyFetchedPagoCheDevueltoCab", _alreadyFetchedPagoCheDevueltoCab)
			info.AddValue("_cuenta", _cuenta)
			info.AddValue("_alwaysFetchCuenta", _alwaysFetchCuenta)
			info.AddValue("_alreadyFetchedCuenta", _alreadyFetchedCuenta)
			info.AddValue("_tipoProveedorCollectionViaProveedorAvanzado", _tipoProveedorCollectionViaProveedorAvanzado)
			info.AddValue("_alwaysFetchTipoProveedorCollectionViaProveedorAvanzado", _alwaysFetchTipoProveedorCollectionViaProveedorAvanzado)
			info.AddValue("_alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado", _alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado)
			info.AddValue("_tipoMonedaCollectionViaCuenta", _tipoMonedaCollectionViaCuenta)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaCuenta", _alwaysFetchTipoMonedaCollectionViaCuenta)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaCuenta", _alreadyFetchedTipoMonedaCollectionViaCuenta)
			info.AddValue("_cuentaContableCollectionViaCuenta", _cuentaContableCollectionViaCuenta)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaCuenta", _alwaysFetchCuentaContableCollectionViaCuenta)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaCuenta", _alreadyFetchedCuentaContableCollectionViaCuenta)


			
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
				Case "ProveedorAvanzado"
					_alreadyFetchedProveedorAvanzado = True
					If Not entity Is Nothing Then
						Me.ProveedorAvanzado.Add(CType(entity, ProveedorAvanzadoEntity))
					End If
				Case "PagoCheDevueltoCab"
					_alreadyFetchedPagoCheDevueltoCab = True
					If Not entity Is Nothing Then
						Me.PagoCheDevueltoCab.Add(CType(entity, PagoCheDevueltoCabEntity))
					End If
				Case "Cuenta"
					_alreadyFetchedCuenta = True
					If Not entity Is Nothing Then
						Me.Cuenta.Add(CType(entity, CuentaEntity))
					End If
				Case "TipoProveedorCollectionViaProveedorAvanzado"
					_alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado = True
					If Not entity Is Nothing Then
						Me.TipoProveedorCollectionViaProveedorAvanzado.Add(CType(entity, TipoProveedorEntity))
					End If
				Case "TipoMonedaCollectionViaCuenta"
					_alreadyFetchedTipoMonedaCollectionViaCuenta = True
					If Not entity Is Nothing Then
						Me.TipoMonedaCollectionViaCuenta.Add(CType(entity, TipoMonedaEntity))
					End If
				Case "CuentaContableCollectionViaCuenta"
					_alreadyFetchedCuentaContableCollectionViaCuenta = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaCuenta.Add(CType(entity, CuentaContableEntity))
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

				Case "ChequeDevuelto"
					_chequeDevuelto.Add(CType(relatedEntity, ChequeDevueltoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ChequesPos"
					_chequesPos.Add(CType(relatedEntity, ChequesPosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProveedorAvanzado"
					_proveedorAvanzado.Add(CType(relatedEntity, ProveedorAvanzadoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PagoCheDevueltoCab"
					_pagoCheDevueltoCab.Add(CType(relatedEntity, PagoCheDevueltoCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cuenta"
					_cuenta.Add(CType(relatedEntity, CuentaEntity))
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

				Case "ChequeDevuelto"
					MyBase.PerformRelatedEntityRemoval(_chequeDevuelto, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ChequesPos"
					MyBase.PerformRelatedEntityRemoval(_chequesPos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProveedorAvanzado"
					MyBase.PerformRelatedEntityRemoval(_proveedorAvanzado, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PagoCheDevueltoCab"
					MyBase.PerformRelatedEntityRemoval(_pagoCheDevueltoCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cuenta"
					MyBase.PerformRelatedEntityRemoval(_cuenta, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_chequeDevuelto)
			toReturn.Add(_chequesPos)
			toReturn.Add(_proveedorAvanzado)
			toReturn.Add(_pagoCheDevueltoCab)
			toReturn.Add(_cuenta)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Bancos which data should be fetched into this Bancos Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Bancos which data should be fetched into this Bancos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Bancos which data should be fetched into this Bancos Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As BancosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As BancosFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



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
				_chequeDevuelto.GetMultiManyToOne(Me, Nothing, Filter)
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
				_chequesPos.GetMultiManyToOne(Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'ProveedorAvanzadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorAvanzadoEntity'</returns>
		Public Function GetMultiProveedorAvanzado(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection
			Return GetMultiProveedorAvanzado(forceFetch, _proveedorAvanzado.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorAvanzadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProveedorAvanzado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection
			Return GetMultiProveedorAvanzado(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorAvanzadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorAvanzadoEntity'</returns>
		Public Function GetMultiProveedorAvanzado(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection
			Return GetMultiProveedorAvanzado(forceFetch, _proveedorAvanzado.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorAvanzadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorAvanzado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection
			If ( Not _alreadyFetchedProveedorAvanzado Or forceFetch Or _alwaysFetchProveedorAvanzado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorAvanzado.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorAvanzado)
					End If
				End If
				_proveedorAvanzado.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorAvanzado.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorAvanzado.GetMultiManyToOne(Me, Nothing, Filter)
				_proveedorAvanzado.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorAvanzado = True
			End If
			Return _proveedorAvanzado
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorAvanzado'. These settings will be taken into account
		''' when the property ProveedorAvanzado is requested or GetMultiProveedorAvanzado is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorAvanzado(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorAvanzado.SortClauses=sortClauses
			_proveedorAvanzado.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PagoCheDevueltoCabEntity'</returns>
		Public Function GetMultiPagoCheDevueltoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
			Return GetMultiPagoCheDevueltoCab(forceFetch, _pagoCheDevueltoCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiPagoCheDevueltoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
			Return GetMultiPagoCheDevueltoCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PagoCheDevueltoCabEntity'</returns>
		Public Function GetMultiPagoCheDevueltoCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
			Return GetMultiPagoCheDevueltoCab(forceFetch, _pagoCheDevueltoCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPagoCheDevueltoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
			If ( Not _alreadyFetchedPagoCheDevueltoCab Or forceFetch Or _alwaysFetchPagoCheDevueltoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _pagoCheDevueltoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_pagoCheDevueltoCab)
					End If
				End If
				_pagoCheDevueltoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_pagoCheDevueltoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_pagoCheDevueltoCab.GetMultiManyToOne(Me, Filter)
				_pagoCheDevueltoCab.SuppressClearInGetMulti = False
				_alreadyFetchedPagoCheDevueltoCab = True
			End If
			Return _pagoCheDevueltoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PagoCheDevueltoCab'. These settings will be taken into account
		''' when the property PagoCheDevueltoCab is requested or GetMultiPagoCheDevueltoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPagoCheDevueltoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_pagoCheDevueltoCab.SortClauses=sortClauses
			_pagoCheDevueltoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuenta(forceFetch, _cuenta.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuenta(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuenta(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuenta(forceFetch, _cuenta.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuenta Or forceFetch Or _alwaysFetchCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuenta)
					End If
				End If
				_cuenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuenta.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_cuenta.SuppressClearInGetMulti = False
				_alreadyFetchedCuenta = True
			End If
			Return _cuenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cuenta'. These settings will be taken into account
		''' when the property Cuenta is requested or GetMultiCuenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuenta.SortClauses=sortClauses
			_cuenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'TipoProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoProveedorEntity'</returns>
		Public Function GetMultiTipoProveedorCollectionViaProveedorAvanzado(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoProveedorCollection
			Return GetMultiTipoProveedorCollectionViaProveedorAvanzado(forceFetch, _tipoProveedorCollectionViaProveedorAvanzado.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoProveedorCollectionViaProveedorAvanzado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoProveedorCollection
			If ( Not _alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado Or forceFetch Or _alwaysFetchTipoProveedorCollectionViaProveedorAvanzado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoProveedorCollectionViaProveedorAvanzado.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoProveedorCollectionViaProveedorAvanzado)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(BancosEntity.Relations.ProveedorAvanzadoEntityUsingCodigoBanco, "__BancosEntity__", "ProveedorAvanzado_", JoinHint.None)
				relations.Add(ProveedorAvanzadoEntity.Relations.TipoProveedorEntityUsingCodigoTipoProveedor, "ProveedorAvanzado_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(BancosFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoProveedorCollectionViaProveedorAvanzado.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoProveedorCollectionViaProveedorAvanzado.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoProveedorCollectionViaProveedorAvanzado.GetMulti(Filter, relations)
				_tipoProveedorCollectionViaProveedorAvanzado.SuppressClearInGetMulti = False
				_alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado = True
			End If
			Return _tipoProveedorCollectionViaProveedorAvanzado
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoProveedorCollectionViaProveedorAvanzado'. These settings will be taken into account
		''' when the property TipoProveedorCollectionViaProveedorAvanzado is requested or GetMultiTipoProveedorCollectionViaProveedorAvanzado is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoProveedorCollectionViaProveedorAvanzado(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoProveedorCollectionViaProveedorAvanzado.SortClauses=sortClauses
			_tipoProveedorCollectionViaProveedorAvanzado.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMonedaEntity'</returns>
		Public Function GetMultiTipoMonedaCollectionViaCuenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Return GetMultiTipoMonedaCollectionViaCuenta(forceFetch, _tipoMonedaCollectionViaCuenta.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMonedaCollectionViaCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			If ( Not _alreadyFetchedTipoMonedaCollectionViaCuenta Or forceFetch Or _alwaysFetchTipoMonedaCollectionViaCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMonedaCollectionViaCuenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMonedaCollectionViaCuenta)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(BancosEntity.Relations.CuentaEntityUsingBancoId, "__BancosEntity__", "Cuenta_", JoinHint.None)
				relations.Add(CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId, "Cuenta_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(BancosFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoMonedaCollectionViaCuenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMonedaCollectionViaCuenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMonedaCollectionViaCuenta.GetMulti(Filter, relations)
				_tipoMonedaCollectionViaCuenta.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMonedaCollectionViaCuenta = True
			End If
			Return _tipoMonedaCollectionViaCuenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMonedaCollectionViaCuenta'. These settings will be taken into account
		''' when the property TipoMonedaCollectionViaCuenta is requested or GetMultiTipoMonedaCollectionViaCuenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMonedaCollectionViaCuenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMonedaCollectionViaCuenta.SortClauses=sortClauses
			_tipoMonedaCollectionViaCuenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaCuenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaCuenta(forceFetch, _cuentaContableCollectionViaCuenta.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaCuenta Or forceFetch Or _alwaysFetchCuentaContableCollectionViaCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaCuenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaCuenta)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(BancosEntity.Relations.CuentaEntityUsingBancoId, "__BancosEntity__", "Cuenta_", JoinHint.None)
				relations.Add(CuentaEntity.Relations.CuentaContableEntityUsingCuentacontableId, "Cuenta_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(BancosFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaCuenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaCuenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaCuenta.GetMulti(Filter, relations)
				_cuentaContableCollectionViaCuenta.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaCuenta = True
			End If
			Return _cuentaContableCollectionViaCuenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaCuenta'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaCuenta is requested or GetMultiCuentaContableCollectionViaCuenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaCuenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaCuenta.SortClauses=sortClauses
			_cuentaContableCollectionViaCuenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(BancosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, BancosFieldIndex)












					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_chequeDevuelto.ActiveContext = MyBase.ActiveContext
			_chequesPos.ActiveContext = MyBase.ActiveContext
			_proveedorAvanzado.ActiveContext = MyBase.ActiveContext
			_pagoCheDevueltoCab.ActiveContext = MyBase.ActiveContext
			_cuenta.ActiveContext = MyBase.ActiveContext
			_tipoProveedorCollectionViaProveedorAvanzado.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaCuenta.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaCuenta.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As BancosDAO = CType(CreateDAOInstance(), BancosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As BancosDAO = CType(CreateDAOInstance(), BancosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As BancosDAO = CType(CreateDAOInstance(), BancosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this BancosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.BancosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Bancos which data should be fetched into this Bancos Object</param>
		''' <param name="validator">The validator Object for this BancosEntity</param>
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
			_chequeDevuelto = New Integralab.ORM.CollectionClasses.ChequeDevueltoCollection(New ChequeDevueltoEntityFactory())
			_chequeDevuelto.SetContainingEntityInfo(Me, "Bancos")
			_alwaysFetchChequeDevuelto = False
			_alreadyFetchedChequeDevuelto = False
			_chequesPos = New Integralab.ORM.CollectionClasses.ChequesPosCollection(New ChequesPosEntityFactory())
			_chequesPos.SetContainingEntityInfo(Me, "Bancos")
			_alwaysFetchChequesPos = False
			_alreadyFetchedChequesPos = False
			_proveedorAvanzado = New Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection(New ProveedorAvanzadoEntityFactory())
			_proveedorAvanzado.SetContainingEntityInfo(Me, "Banco")
			_alwaysFetchProveedorAvanzado = False
			_alreadyFetchedProveedorAvanzado = False
			_pagoCheDevueltoCab = New Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection(New PagoCheDevueltoCabEntityFactory())
			_pagoCheDevueltoCab.SetContainingEntityInfo(Me, "Bancos")
			_alwaysFetchPagoCheDevueltoCab = False
			_alreadyFetchedPagoCheDevueltoCab = False
			_cuenta = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_cuenta.SetContainingEntityInfo(Me, "Bancos")
			_alwaysFetchCuenta = False
			_alreadyFetchedCuenta = False
			_tipoProveedorCollectionViaProveedorAvanzado = New Integralab.ORM.CollectionClasses.TipoProveedorCollection(New TipoProveedorEntityFactory())
			_alwaysFetchTipoProveedorCollectionViaProveedorAvanzado = False
			_alreadyFetchedTipoProveedorCollectionViaProveedorAvanzado = False
			_tipoMonedaCollectionViaCuenta = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaCuenta = False
			_alreadyFetchedTipoMonedaCollectionViaCuenta = False
			_cuentaContableCollectionViaCuenta = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaCuenta = False
			_alreadyFetchedCuentaContableCollectionViaCuenta = False


			
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

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BncCveSat", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Bancos which data should be fetched into this Bancos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(BancosFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateBancosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New BancosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As BancosRelations
			Get	
				Return New BancosRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChequeDevuelto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathChequeDevuelto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequeDevueltoCollection(), _
					BancosEntity.Relations.ChequeDevueltoEntityUsingIdBanco, _
					CType(Integralab.ORM.EntityType.BancosEntity, Integer), CType(Integralab.ORM.EntityType.ChequeDevueltoEntity, Integer), 0, Nothing, Nothing, Nothing, "ChequeDevuelto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChequesPos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathChequesPos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequesPosCollection(), _
					BancosEntity.Relations.ChequesPosEntityUsingCveBanCte, _
					CType(Integralab.ORM.EntityType.BancosEntity, Integer), CType(Integralab.ORM.EntityType.ChequesPosEntity, Integer), 0, Nothing, Nothing, Nothing, "ChequesPos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProveedorAvanzado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorAvanzado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection(), _
					BancosEntity.Relations.ProveedorAvanzadoEntityUsingCodigoBanco, _
					CType(Integralab.ORM.EntityType.BancosEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorAvanzadoEntity, Integer), 0, Nothing, Nothing, Nothing, "ProveedorAvanzado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PagoCheDevueltoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPagoCheDevueltoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection(), _
					BancosEntity.Relations.PagoCheDevueltoCabEntityUsingIdBancoDeposito, _
					CType(Integralab.ORM.EntityType.BancosEntity, Integer), CType(Integralab.ORM.EntityType.PagoCheDevueltoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "PagoCheDevueltoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuenta() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					BancosEntity.Relations.CuentaEntityUsingBancoId, _
					CType(Integralab.ORM.EntityType.BancosEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, Nothing, "Cuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoProveedorCollectionViaProveedorAvanzado() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(BancosEntity.Relations.ProveedorAvanzadoEntityUsingCodigoBanco, "__BancosEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorAvanzadoEntity.Relations.TipoProveedorEntityUsingCodigoTipoProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoProveedorCollection(), _
					BancosEntity.Relations.ProveedorAvanzadoEntityUsingCodigoBanco, _
					CType(Integralab.ORM.EntityType.BancosEntity, Integer), CType(Integralab.ORM.EntityType.TipoProveedorEntity, Integer), 0, Nothing, Nothing, relations, "TipoProveedorCollectionViaProveedorAvanzado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaCuenta() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(BancosEntity.Relations.CuentaEntityUsingBancoId, "__BancosEntity__", String.Empty, JoinHint.None)
				relations.Add(CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					BancosEntity.Relations.CuentaEntityUsingBancoId, _
					CType(Integralab.ORM.EntityType.BancosEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaCuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaCuenta() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(BancosEntity.Relations.CuentaEntityUsingBancoId, "__BancosEntity__", String.Empty, JoinHint.None)
				relations.Add(CuentaEntity.Relations.CuentaContableEntityUsingCuentacontableId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					BancosEntity.Relations.CuentaEntityUsingBancoId, _
					CType(Integralab.ORM.EntityType.BancosEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaCuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "BancosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return BancosEntity.CustomProperties
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
				Return BancosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncIdBanco"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncDescripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncDescripcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncObservaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.Estatus, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncIdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.UsuarioAlta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncFechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.FechaAlta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncIdUsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncFechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncIdMotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.MotivoBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesBaja property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncObservacionesBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.ObservacionesBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.ObservacionesBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The BncCveSat property of the Entity Bancos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompBancos"."BncCveSat"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [BncCveSat]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BancosFieldIndex.BncCveSat, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(BancosFieldIndex.BncCveSat, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'ProveedorAvanzadoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorAvanzado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorAvanzado]() As Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection
			Get
				Return GetMultiProveedorAvanzado(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorAvanzado. When set to true, ProveedorAvanzado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorAvanzado is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorAvanzado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorAvanzado As Boolean
			Get
				Return _alwaysFetchProveedorAvanzado
			End Get
			Set
				_alwaysFetchProveedorAvanzado = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPagoCheDevueltoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PagoCheDevueltoCab]() As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
			Get
				Return GetMultiPagoCheDevueltoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PagoCheDevueltoCab. When set to true, PagoCheDevueltoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PagoCheDevueltoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiPagoCheDevueltoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPagoCheDevueltoCab As Boolean
			Get
				Return _alwaysFetchPagoCheDevueltoCab
			End Get
			Set
				_alwaysFetchPagoCheDevueltoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cuenta]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cuenta. When set to true, Cuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cuenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuenta As Boolean
			Get
				Return _alwaysFetchCuenta
			End Get
			Set
				_alwaysFetchCuenta = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'TipoProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoProveedorCollectionViaProveedorAvanzado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoProveedorCollectionViaProveedorAvanzado]() As Integralab.ORM.CollectionClasses.TipoProveedorCollection
			Get
				Return GetMultiTipoProveedorCollectionViaProveedorAvanzado(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoProveedorCollectionViaProveedorAvanzado. When set to true, TipoProveedorCollectionViaProveedorAvanzado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoProveedorCollectionViaProveedorAvanzado is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoProveedorCollectionViaProveedorAvanzado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoProveedorCollectionViaProveedorAvanzado As Boolean
			Get
				Return _alwaysFetchTipoProveedorCollectionViaProveedorAvanzado
			End Get
			Set
				_alwaysFetchTipoProveedorCollectionViaProveedorAvanzado = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMonedaCollectionViaCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMonedaCollectionViaCuenta]() As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Get
				Return GetMultiTipoMonedaCollectionViaCuenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMonedaCollectionViaCuenta. When set to true, TipoMonedaCollectionViaCuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMonedaCollectionViaCuenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMonedaCollectionViaCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMonedaCollectionViaCuenta As Boolean
			Get
				Return _alwaysFetchTipoMonedaCollectionViaCuenta
			End Get
			Set
				_alwaysFetchTipoMonedaCollectionViaCuenta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaCuenta]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaCuenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaCuenta. When set to true, CuentaContableCollectionViaCuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaCuenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaCuenta As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaCuenta
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaCuenta = value
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
				Return CInt(Integralab.ORM.EntityType.BancosEntity)
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
