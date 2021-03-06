﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:27
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
	''' <summary>Entity class which represents the entity 'Modulo'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ModuloEntity 
#Else
	<Serializable()> _
	Public Class ModuloEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END
			

#Region "Class Member Declarations"
		Private _motivosBajaDetalle As Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection
		Private _alwaysFetchMotivosBajaDetalle, _alreadyFetchedMotivosBajaDetalle As Boolean
		Private _motivosCancelacionDetalle As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
		Private _alwaysFetchMotivosCancelacionDetalle, _alreadyFetchedMotivosCancelacionDetalle As Boolean
		Private _motivoBajaCollectionViaMotivosBajaDetalle As Integralab.ORM.CollectionClasses.MotivoBajaCollection
		Private _alwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle, _alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle As Boolean
		Private _motivosCancelacionCollectionViaMotivosCancelacionDetalle As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
		Private _alwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle, _alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle As Boolean



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
		''' <param name="codigo">PK value for Modulo which data should be fetched into this Modulo Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Modulo which data should be fetched into this Modulo Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Modulo which data should be fetched into this Modulo Object</param>
		''' <param name="validator">The custom validator Object for this ModuloEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_motivosBajaDetalle = CType(info.GetValue("_motivosBajaDetalle", GetType(Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection)), Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection)
			_alwaysFetchMotivosBajaDetalle = info.GetBoolean("_alwaysFetchMotivosBajaDetalle")
			_alreadyFetchedMotivosBajaDetalle = info.GetBoolean("_alreadyFetchedMotivosBajaDetalle")
			_motivosCancelacionDetalle = CType(info.GetValue("_motivosCancelacionDetalle", GetType(Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection)), Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection)
			_alwaysFetchMotivosCancelacionDetalle = info.GetBoolean("_alwaysFetchMotivosCancelacionDetalle")
			_alreadyFetchedMotivosCancelacionDetalle = info.GetBoolean("_alreadyFetchedMotivosCancelacionDetalle")
			_motivoBajaCollectionViaMotivosBajaDetalle = CType(info.GetValue("_motivoBajaCollectionViaMotivosBajaDetalle", GetType(Integralab.ORM.CollectionClasses.MotivoBajaCollection)), Integralab.ORM.CollectionClasses.MotivoBajaCollection)
			_alwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle = info.GetBoolean("_alwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle")
			_alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle = info.GetBoolean("_alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle")
			_motivosCancelacionCollectionViaMotivosCancelacionDetalle = CType(info.GetValue("_motivosCancelacionCollectionViaMotivosCancelacionDetalle", GetType(Integralab.ORM.CollectionClasses.MotivoCancelacionCollection)), Integralab.ORM.CollectionClasses.MotivoCancelacionCollection)
			_alwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle = info.GetBoolean("_alwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle")
			_alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle = info.GetBoolean("_alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMotivosBajaDetalle = (_motivosBajaDetalle.Count > 0)
			_alreadyFetchedMotivosCancelacionDetalle = (_motivosCancelacionDetalle.Count > 0)
			_alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle = (_motivoBajaCollectionViaMotivosBajaDetalle.Count > 0)
			_alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle = (_motivosCancelacionCollectionViaMotivosCancelacionDetalle.Count > 0)


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
			info.AddValue("_motivosBajaDetalle", _motivosBajaDetalle)
			info.AddValue("_alwaysFetchMotivosBajaDetalle", _alwaysFetchMotivosBajaDetalle)
			info.AddValue("_alreadyFetchedMotivosBajaDetalle", _alreadyFetchedMotivosBajaDetalle)
			info.AddValue("_motivosCancelacionDetalle", _motivosCancelacionDetalle)
			info.AddValue("_alwaysFetchMotivosCancelacionDetalle", _alwaysFetchMotivosCancelacionDetalle)
			info.AddValue("_alreadyFetchedMotivosCancelacionDetalle", _alreadyFetchedMotivosCancelacionDetalle)
			info.AddValue("_motivoBajaCollectionViaMotivosBajaDetalle", _motivoBajaCollectionViaMotivosBajaDetalle)
			info.AddValue("_alwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle", _alwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle)
			info.AddValue("_alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle", _alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle)
			info.AddValue("_motivosCancelacionCollectionViaMotivosCancelacionDetalle", _motivosCancelacionCollectionViaMotivosCancelacionDetalle)
			info.AddValue("_alwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle", _alwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle)
			info.AddValue("_alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle", _alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle)


			
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

				Case "MotivosBajaDetalle"
					_alreadyFetchedMotivosBajaDetalle = True
					If Not entity Is Nothing Then
						Me.MotivosBajaDetalle.Add(CType(entity, MotivoBajaDetalleEntity))
					End If
				Case "MotivosCancelacionDetalle"
					_alreadyFetchedMotivosCancelacionDetalle = True
					If Not entity Is Nothing Then
						Me.MotivosCancelacionDetalle.Add(CType(entity, MotivoCancelacionDetalleEntity))
					End If
				Case "MotivoBajaCollectionViaMotivosBajaDetalle"
					_alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle = True
					If Not entity Is Nothing Then
						Me.MotivoBajaCollectionViaMotivosBajaDetalle.Add(CType(entity, MotivoBajaEntity))
					End If
				Case "MotivosCancelacionCollectionViaMotivosCancelacionDetalle"
					_alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle = True
					If Not entity Is Nothing Then
						Me.MotivosCancelacionCollectionViaMotivosCancelacionDetalle.Add(CType(entity, MotivoCancelacionEntity))
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

				Case "MotivosBajaDetalle"
					_motivosBajaDetalle.Add(CType(relatedEntity, MotivoBajaDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MotivosCancelacionDetalle"
					_motivosCancelacionDetalle.Add(CType(relatedEntity, MotivoCancelacionDetalleEntity))
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

				Case "MotivosBajaDetalle"
					MyBase.PerformRelatedEntityRemoval(_motivosBajaDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MotivosCancelacionDetalle"
					MyBase.PerformRelatedEntityRemoval(_motivosCancelacionDetalle, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_motivosBajaDetalle)
			toReturn.Add(_motivosCancelacionDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Modulo which data should be fetched into this Modulo Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Modulo which data should be fetched into this Modulo Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Modulo which data should be fetched into this Modulo Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ModuloFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ModuloFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MotivoBajaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MotivoBajaDetalleEntity'</returns>
		Public Function GetMultiMotivosBajaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection
			Return GetMultiMotivosBajaDetalle(forceFetch, _motivosBajaDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoBajaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMotivosBajaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection
			Return GetMultiMotivosBajaDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoBajaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MotivoBajaDetalleEntity'</returns>
		Public Function GetMultiMotivosBajaDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection
			Return GetMultiMotivosBajaDetalle(forceFetch, _motivosBajaDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoBajaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMotivosBajaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection
			If ( Not _alreadyFetchedMotivosBajaDetalle Or forceFetch Or _alwaysFetchMotivosBajaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _motivosBajaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_motivosBajaDetalle)
					End If
				End If
				_motivosBajaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_motivosBajaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_motivosBajaDetalle.GetMultiManyToOne(Me, Nothing, Filter)
				_motivosBajaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMotivosBajaDetalle = True
			End If
			Return _motivosBajaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MotivosBajaDetalle'. These settings will be taken into account
		''' when the property MotivosBajaDetalle is requested or GetMultiMotivosBajaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMotivosBajaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_motivosBajaDetalle.SortClauses=sortClauses
			_motivosBajaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MotivoCancelacionDetalleEntity'</returns>
		Public Function GetMultiMotivosCancelacionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			Return GetMultiMotivosCancelacionDetalle(forceFetch, _motivosCancelacionDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMotivosCancelacionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			Return GetMultiMotivosCancelacionDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MotivoCancelacionDetalleEntity'</returns>
		Public Function GetMultiMotivosCancelacionDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			Return GetMultiMotivosCancelacionDetalle(forceFetch, _motivosCancelacionDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMotivosCancelacionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			If ( Not _alreadyFetchedMotivosCancelacionDetalle Or forceFetch Or _alwaysFetchMotivosCancelacionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _motivosCancelacionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_motivosCancelacionDetalle)
					End If
				End If
				_motivosCancelacionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_motivosCancelacionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_motivosCancelacionDetalle.GetMultiManyToOne(Me, Nothing, Filter)
				_motivosCancelacionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMotivosCancelacionDetalle = True
			End If
			Return _motivosCancelacionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MotivosCancelacionDetalle'. These settings will be taken into account
		''' when the property MotivosCancelacionDetalle is requested or GetMultiMotivosCancelacionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMotivosCancelacionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_motivosCancelacionDetalle.SortClauses=sortClauses
			_motivosCancelacionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'MotivoBajaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MotivoBajaEntity'</returns>
		Public Function GetMultiMotivoBajaCollectionViaMotivosBajaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MotivoBajaCollection
			Return GetMultiMotivoBajaCollectionViaMotivosBajaDetalle(forceFetch, _motivoBajaCollectionViaMotivosBajaDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoBajaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMotivoBajaCollectionViaMotivosBajaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MotivoBajaCollection
			If ( Not _alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle Or forceFetch Or _alwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _motivoBajaCollectionViaMotivosBajaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_motivoBajaCollectionViaMotivosBajaDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ModuloEntity.Relations.MotivoBajaDetalleEntityUsingIdmodulo, "__ModuloEntity__", "MotivoBajaDetalle_", JoinHint.None)
				relations.Add(MotivoBajaDetalleEntity.Relations.MotivoBajaEntityUsingIdmotivo, "MotivoBajaDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ModuloFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_motivoBajaCollectionViaMotivosBajaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_motivoBajaCollectionViaMotivosBajaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_motivoBajaCollectionViaMotivosBajaDetalle.GetMulti(Filter, relations)
				_motivoBajaCollectionViaMotivosBajaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle = True
			End If
			Return _motivoBajaCollectionViaMotivosBajaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MotivoBajaCollectionViaMotivosBajaDetalle'. These settings will be taken into account
		''' when the property MotivoBajaCollectionViaMotivosBajaDetalle is requested or GetMultiMotivoBajaCollectionViaMotivosBajaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMotivoBajaCollectionViaMotivosBajaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_motivoBajaCollectionViaMotivosBajaDetalle.SortClauses=sortClauses
			_motivoBajaCollectionViaMotivosBajaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MotivoCancelacionEntity'</returns>
		Public Function GetMultiMotivosCancelacionCollectionViaMotivosCancelacionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
			Return GetMultiMotivosCancelacionCollectionViaMotivosCancelacionDetalle(forceFetch, _motivosCancelacionCollectionViaMotivosCancelacionDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMotivosCancelacionCollectionViaMotivosCancelacionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
			If ( Not _alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle Or forceFetch Or _alwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _motivosCancelacionCollectionViaMotivosCancelacionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_motivosCancelacionCollectionViaMotivosCancelacionDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ModuloEntity.Relations.MotivoCancelacionDetalleEntityUsingIdmodulo, "__ModuloEntity__", "MotivoCancelacionDetalle_", JoinHint.None)
				relations.Add(MotivoCancelacionDetalleEntity.Relations.MotivoCancelacionEntityUsingIdmotivo, "MotivoCancelacionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ModuloFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_motivosCancelacionCollectionViaMotivosCancelacionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_motivosCancelacionCollectionViaMotivosCancelacionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_motivosCancelacionCollectionViaMotivosCancelacionDetalle.GetMulti(Filter, relations)
				_motivosCancelacionCollectionViaMotivosCancelacionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle = True
			End If
			Return _motivosCancelacionCollectionViaMotivosCancelacionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MotivosCancelacionCollectionViaMotivosCancelacionDetalle'. These settings will be taken into account
		''' when the property MotivosCancelacionCollectionViaMotivosCancelacionDetalle is requested or GetMultiMotivosCancelacionCollectionViaMotivosCancelacionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMotivosCancelacionCollectionViaMotivosCancelacionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_motivosCancelacionCollectionViaMotivosCancelacionDetalle.SortClauses=sortClauses
			_motivosCancelacionCollectionViaMotivosCancelacionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ModuloFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ModuloFieldIndex)






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_motivosBajaDetalle.ActiveContext = MyBase.ActiveContext
			_motivosCancelacionDetalle.ActiveContext = MyBase.ActiveContext
			_motivoBajaCollectionViaMotivosBajaDetalle.ActiveContext = MyBase.ActiveContext
			_motivosCancelacionCollectionViaMotivosCancelacionDetalle.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ModuloDAO = CType(CreateDAOInstance(), ModuloDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ModuloDAO = CType(CreateDAOInstance(), ModuloDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ModuloDAO = CType(CreateDAOInstance(), ModuloDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ModuloEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ModuloEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Modulo which data should be fetched into this Modulo Object</param>
		''' <param name="validator">The validator Object for this ModuloEntity</param>
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
			_motivosBajaDetalle = New Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection(New MotivoBajaDetalleEntityFactory())
			_motivosBajaDetalle.SetContainingEntityInfo(Me, "Modulo")
			_alwaysFetchMotivosBajaDetalle = False
			_alreadyFetchedMotivosBajaDetalle = False
			_motivosCancelacionDetalle = New Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection(New MotivoCancelacionDetalleEntityFactory())
			_motivosCancelacionDetalle.SetContainingEntityInfo(Me, "Modulo")
			_alwaysFetchMotivosCancelacionDetalle = False
			_alreadyFetchedMotivosCancelacionDetalle = False
			_motivoBajaCollectionViaMotivosBajaDetalle = New Integralab.ORM.CollectionClasses.MotivoBajaCollection(New MotivoBajaEntityFactory())
			_alwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle = False
			_alreadyFetchedMotivoBajaCollectionViaMotivosBajaDetalle = False
			_motivosCancelacionCollectionViaMotivosCancelacionDetalle = New Integralab.ORM.CollectionClasses.MotivoCancelacionCollection(New MotivoCancelacionEntityFactory())
			_alwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle = False
			_alreadyFetchedMotivosCancelacionCollectionViaMotivosCancelacionDetalle = False


			
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

			_fieldsCustomProperties.Add("EsBaja", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Modulo which data should be fetched into this Modulo Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ModuloFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateModuloDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ModuloEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ModuloRelations
			Get	
				Return New ModuloRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoBajaDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivosBajaDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection(), _
					ModuloEntity.Relations.MotivoBajaDetalleEntityUsingIdmodulo, _
					CType(Integralab.ORM.EntityType.ModuloEntity, Integer), CType(Integralab.ORM.EntityType.MotivoBajaDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MotivosBajaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoCancelacionDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivosCancelacionDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection(), _
					ModuloEntity.Relations.MotivoCancelacionDetalleEntityUsingIdmodulo, _
					CType(Integralab.ORM.EntityType.ModuloEntity, Integer), CType(Integralab.ORM.EntityType.MotivoCancelacionDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MotivosCancelacionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoBaja' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivoBajaCollectionViaMotivosBajaDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ModuloEntity.Relations.MotivoBajaDetalleEntityUsingIdmodulo, "__ModuloEntity__", String.Empty, JoinHint.None)
				relations.Add(MotivoBajaDetalleEntity.Relations.MotivoBajaEntityUsingIdmotivo)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoBajaCollection(), _
					ModuloEntity.Relations.MotivoBajaDetalleEntityUsingIdmodulo, _
					CType(Integralab.ORM.EntityType.ModuloEntity, Integer), CType(Integralab.ORM.EntityType.MotivoBajaEntity, Integer), 0, Nothing, Nothing, relations, "MotivoBajaCollectionViaMotivosBajaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoCancelacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivosCancelacionCollectionViaMotivosCancelacionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ModuloEntity.Relations.MotivoCancelacionDetalleEntityUsingIdmodulo, "__ModuloEntity__", String.Empty, JoinHint.None)
				relations.Add(MotivoCancelacionDetalleEntity.Relations.MotivoCancelacionEntityUsingIdmotivo)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoCancelacionCollection(), _
					ModuloEntity.Relations.MotivoCancelacionDetalleEntityUsingIdmodulo, _
					CType(Integralab.ORM.EntityType.ModuloEntity, Integer), CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), 0, Nothing, Nothing, relations, "MotivosCancelacionCollectionViaMotivosCancelacionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ModuloEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ModuloEntity.CustomProperties
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
				Return ModuloEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Modulo<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenModulos"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ModuloFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ModuloFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity Modulo<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenModulos"."Nombre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ModuloFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ModuloFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity Modulo<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenModulos"."NombreCorto"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ModuloFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ModuloFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity Modulo<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenModulos"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ModuloFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ModuloFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Modulo<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenModulos"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ModuloFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ModuloFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsBaja property of the Entity Modulo<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenModulos"."EsBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsBaja]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ModuloFieldIndex.EsBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ModuloFieldIndex.EsBaja, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MotivoBajaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMotivosBajaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MotivosBajaDetalle]() As Integralab.ORM.CollectionClasses.MotivoBajaDetalleCollection
			Get
				Return GetMultiMotivosBajaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MotivosBajaDetalle. When set to true, MotivosBajaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MotivosBajaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMotivosBajaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMotivosBajaDetalle As Boolean
			Get
				Return _alwaysFetchMotivosBajaDetalle
			End Get
			Set
				_alwaysFetchMotivosBajaDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMotivosCancelacionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MotivosCancelacionDetalle]() As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			Get
				Return GetMultiMotivosCancelacionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MotivosCancelacionDetalle. When set to true, MotivosCancelacionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MotivosCancelacionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMotivosCancelacionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMotivosCancelacionDetalle As Boolean
			Get
				Return _alwaysFetchMotivosCancelacionDetalle
			End Get
			Set
				_alwaysFetchMotivosCancelacionDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MotivoBajaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMotivoBajaCollectionViaMotivosBajaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MotivoBajaCollectionViaMotivosBajaDetalle]() As Integralab.ORM.CollectionClasses.MotivoBajaCollection
			Get
				Return GetMultiMotivoBajaCollectionViaMotivosBajaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MotivoBajaCollectionViaMotivosBajaDetalle. When set to true, MotivoBajaCollectionViaMotivosBajaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MotivoBajaCollectionViaMotivosBajaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMotivoBajaCollectionViaMotivosBajaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle As Boolean
			Get
				Return _alwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle
			End Get
			Set
				_alwaysFetchMotivoBajaCollectionViaMotivosBajaDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MotivoCancelacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMotivosCancelacionCollectionViaMotivosCancelacionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MotivosCancelacionCollectionViaMotivosCancelacionDetalle]() As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
			Get
				Return GetMultiMotivosCancelacionCollectionViaMotivosCancelacionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MotivosCancelacionCollectionViaMotivosCancelacionDetalle. When set to true, MotivosCancelacionCollectionViaMotivosCancelacionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MotivosCancelacionCollectionViaMotivosCancelacionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMotivosCancelacionCollectionViaMotivosCancelacionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle As Boolean
			Get
				Return _alwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle
			End Get
			Set
				_alwaysFetchMotivosCancelacionCollectionViaMotivosCancelacionDetalle = value
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
				Return CInt(Integralab.ORM.EntityType.ModuloEntity)
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
