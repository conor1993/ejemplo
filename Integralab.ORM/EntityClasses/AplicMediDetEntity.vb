' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 26 de enero de 2018 13:41:32
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
	''' <summary>Entity class which represents the entity 'AplicMediDet'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class AplicMediDetEntity 
#Else
	<Serializable()> _
	Public Class AplicMediDetEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _aplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
		Private _alwaysFetchAplicMediDetDet, _alreadyFetchedAplicMediDetDet As Boolean
		Private _aplicMediCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMediCollectionViaAplicMediDetDet, _alreadyFetchedAplicMediCollectionViaAplicMediDetDet As Boolean
		Private _productoCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaAplicMediDetDet, _alreadyFetchedProductoCollectionViaAplicMediDetDet As Boolean
		Private _mcecatCorralesCabCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet, _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet As Boolean
		Private _mcecatLotesCabCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet, _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet As Boolean
		Private _aplicMedi As AplicMediEntity
		Private _alwaysFetchAplicMedi, _alreadyFetchedAplicMedi, _aplicMediReturnsNewIfNotFound As Boolean
		Private _producto As ProductoEntity
		Private _alwaysFetchProducto, _alreadyFetchedProducto, _productoReturnsNewIfNotFound As Boolean
		Private _mcecatCorralesCab As McecatCorralesCabEntity
		Private _alwaysFetchMcecatCorralesCab, _alreadyFetchedMcecatCorralesCab, _mcecatCorralesCabReturnsNewIfNotFound As Boolean
		Private _mcecatLotesCab As McecatLotesCabEntity
		Private _alwaysFetchMcecatLotesCab, _alreadyFetchedMcecatLotesCab, _mcecatLotesCabReturnsNewIfNotFound As Boolean


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
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idLote">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		Public Sub New(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String)

			InitClassFetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idLote">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idLote">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="validator">The custom validator Object for this AplicMediDetEntity</param>
		Public Sub New(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, validator As IValidator)

			InitClassFetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_aplicMediDetDet = CType(info.GetValue("_aplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediDetDetCollection)), Integralab.ORM.CollectionClasses.AplicMediDetDetCollection)
			_alwaysFetchAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediDetDet")
			_alreadyFetchedAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediDetDet")
			_aplicMediCollectionViaAplicMediDetDet = CType(info.GetValue("_aplicMediCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMediCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediCollectionViaAplicMediDetDet")
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediCollectionViaAplicMediDetDet")
			_productoCollectionViaAplicMediDetDet = CType(info.GetValue("_productoCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchProductoCollectionViaAplicMediDetDet")
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedProductoCollectionViaAplicMediDetDet")
			_mcecatCorralesCabCollectionViaAplicMediDetDet = CType(info.GetValue("_mcecatCorralesCabCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet")
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet")
			_mcecatLotesCabCollectionViaAplicMediDetDet = CType(info.GetValue("_mcecatLotesCabCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet")
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet")
			_aplicMedi = CType(info.GetValue("_aplicMedi", GetType(AplicMediEntity)), AplicMediEntity)
			If Not _aplicMedi Is Nothing Then
				AddHandler _aplicMedi.AfterSave, AddressOf OnEntityAfterSave
			End If
			_aplicMediReturnsNewIfNotFound = info.GetBoolean("_aplicMediReturnsNewIfNotFound")
			_alwaysFetchAplicMedi = info.GetBoolean("_alwaysFetchAplicMedi")
			_alreadyFetchedAplicMedi = info.GetBoolean("_alreadyFetchedAplicMedi")
			_producto = CType(info.GetValue("_producto", GetType(ProductoEntity)), ProductoEntity)
			If Not _producto Is Nothing Then
				AddHandler _producto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_productoReturnsNewIfNotFound = info.GetBoolean("_productoReturnsNewIfNotFound")
			_alwaysFetchProducto = info.GetBoolean("_alwaysFetchProducto")
			_alreadyFetchedProducto = info.GetBoolean("_alreadyFetchedProducto")
			_mcecatCorralesCab = CType(info.GetValue("_mcecatCorralesCab", GetType(McecatCorralesCabEntity)), McecatCorralesCabEntity)
			If Not _mcecatCorralesCab Is Nothing Then
				AddHandler _mcecatCorralesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcecatCorralesCabReturnsNewIfNotFound = info.GetBoolean("_mcecatCorralesCabReturnsNewIfNotFound")
			_alwaysFetchMcecatCorralesCab = info.GetBoolean("_alwaysFetchMcecatCorralesCab")
			_alreadyFetchedMcecatCorralesCab = info.GetBoolean("_alreadyFetchedMcecatCorralesCab")
			_mcecatLotesCab = CType(info.GetValue("_mcecatLotesCab", GetType(McecatLotesCabEntity)), McecatLotesCabEntity)
			If Not _mcecatLotesCab Is Nothing Then
				AddHandler _mcecatLotesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcecatLotesCabReturnsNewIfNotFound = info.GetBoolean("_mcecatLotesCabReturnsNewIfNotFound")
			_alwaysFetchMcecatLotesCab = info.GetBoolean("_alwaysFetchMcecatLotesCab")
			_alreadyFetchedMcecatLotesCab = info.GetBoolean("_alreadyFetchedMcecatLotesCab")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedAplicMediDetDet = (_aplicMediDetDet.Count > 0)
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = (_aplicMediCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = (_productoCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = (_mcecatCorralesCabCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = (_mcecatLotesCabCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedAplicMedi = Not(_aplicMedi Is Nothing)
			_alreadyFetchedProducto = Not(_producto Is Nothing)
			_alreadyFetchedMcecatCorralesCab = Not(_mcecatCorralesCab Is Nothing)
			_alreadyFetchedMcecatLotesCab = Not(_mcecatLotesCab Is Nothing)

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
			info.AddValue("_aplicMediDetDet", _aplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediDetDet", _alwaysFetchAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediDetDet", _alreadyFetchedAplicMediDetDet)
			info.AddValue("_aplicMediCollectionViaAplicMediDetDet", _aplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediCollectionViaAplicMediDetDet", _alwaysFetchAplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediCollectionViaAplicMediDetDet", _alreadyFetchedAplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_productoCollectionViaAplicMediDetDet", _productoCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchProductoCollectionViaAplicMediDetDet", _alwaysFetchProductoCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedProductoCollectionViaAplicMediDetDet", _alreadyFetchedProductoCollectionViaAplicMediDetDet)
			info.AddValue("_mcecatCorralesCabCollectionViaAplicMediDetDet", _mcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet", _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet", _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_mcecatLotesCabCollectionViaAplicMediDetDet", _mcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet", _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet", _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_aplicMedi", _aplicMedi)
			info.AddValue("_aplicMediReturnsNewIfNotFound", _aplicMediReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAplicMedi", _alwaysFetchAplicMedi)
			info.AddValue("_alreadyFetchedAplicMedi", _alreadyFetchedAplicMedi)
			info.AddValue("_producto", _producto)
			info.AddValue("_productoReturnsNewIfNotFound", _productoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProducto", _alwaysFetchProducto)
			info.AddValue("_alreadyFetchedProducto", _alreadyFetchedProducto)
			info.AddValue("_mcecatCorralesCab", _mcecatCorralesCab)
			info.AddValue("_mcecatCorralesCabReturnsNewIfNotFound", _mcecatCorralesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcecatCorralesCab", _alwaysFetchMcecatCorralesCab)
			info.AddValue("_alreadyFetchedMcecatCorralesCab", _alreadyFetchedMcecatCorralesCab)
			info.AddValue("_mcecatLotesCab", _mcecatLotesCab)
			info.AddValue("_mcecatLotesCabReturnsNewIfNotFound", _mcecatLotesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcecatLotesCab", _alwaysFetchMcecatLotesCab)
			info.AddValue("_alreadyFetchedMcecatLotesCab", _alreadyFetchedMcecatLotesCab)

			
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
				Case "AplicMedi"
					_alreadyFetchedAplicMedi = True
					Me.AplicMedi = CType(entity, AplicMediEntity)
				Case "Producto"
					_alreadyFetchedProducto = True
					Me.Producto = CType(entity, ProductoEntity)
				Case "McecatCorralesCab"
					_alreadyFetchedMcecatCorralesCab = True
					Me.McecatCorralesCab = CType(entity, McecatCorralesCabEntity)
				Case "McecatLotesCab"
					_alreadyFetchedMcecatLotesCab = True
					Me.McecatLotesCab = CType(entity, McecatLotesCabEntity)
				Case "AplicMediDetDet"
					_alreadyFetchedAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.AplicMediDetDet.Add(CType(entity, AplicMediDetDetEntity))
					End If
				Case "AplicMediCollectionViaAplicMediDetDet"
					_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.AplicMediCollectionViaAplicMediDetDet.Add(CType(entity, AplicMediEntity))
					End If
				Case "ProductoCollectionViaAplicMediDetDet"
					_alreadyFetchedProductoCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaAplicMediDetDet.Add(CType(entity, ProductoEntity))
					End If
				Case "McecatCorralesCabCollectionViaAplicMediDetDet"
					_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaAplicMediDetDet.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaAplicMediDetDet"
					_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaAplicMediDetDet.Add(CType(entity, McecatLotesCabEntity))
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
				Case "AplicMedi"
					SetupSyncAplicMedi(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Producto"
					SetupSyncProducto(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					SetupSyncMcecatCorralesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatLotesCab"
					SetupSyncMcecatLotesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					_aplicMediDetDet.Add(CType(relatedEntity, AplicMediDetDetEntity))
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
				Case "AplicMedi"
					DesetupSyncAplicMedi(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Producto"
					DesetupSyncProducto(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					DesetupSyncMcecatCorralesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatLotesCab"
					DesetupSyncMcecatLotesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					MyBase.PerformRelatedEntityRemoval(_aplicMediDetDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _aplicMedi Is Nothing Then
				toReturn.Add(_aplicMedi)
			End If
			If Not _producto Is Nothing Then
				toReturn.Add(_producto)
			End If
			If Not _mcecatCorralesCab Is Nothing Then
				toReturn.Add(_mcecatCorralesCab)
			End If
			If Not _mcecatLotesCab Is Nothing Then
				toReturn.Add(_mcecatLotesCab)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_aplicMediDetDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idLote">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String) As Boolean
			Return FetchUsingPK(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idLote">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idLote">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolioAplicacionMedicamento, Me.IdLote, Me.IdMedicamento, Me.IdCorral, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As AplicMediDetFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As AplicMediDetFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediDetDetEntity'</returns>
		Public Function GetMultiAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			Return GetMultiAplicMediDetDet(forceFetch, _aplicMediDetDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			Return GetMultiAplicMediDetDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediDetDetEntity'</returns>
		Public Function GetMultiAplicMediDetDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			Return GetMultiAplicMediDetDet(forceFetch, _aplicMediDetDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			If ( Not _alreadyFetchedAplicMediDetDet Or forceFetch Or _alwaysFetchAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _aplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_aplicMediDetDet)
					End If
				End If
				_aplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_aplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_aplicMediDetDet.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Filter)
				_aplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedAplicMediDetDet = True
			End If
			Return _aplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AplicMediDetDet'. These settings will be taken into account
		''' when the property AplicMediDetDet is requested or GetMultiAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_aplicMediDetDet.SortClauses=sortClauses
			_aplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediEntity'</returns>
		Public Function GetMultiAplicMediCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AplicMediCollection
			Return GetMultiAplicMediCollectionViaAplicMediDetDet(forceFetch, _aplicMediCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAplicMediCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AplicMediCollection
			If ( Not _alreadyFetchedAplicMediCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchAplicMediCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _aplicMediCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_aplicMediCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "__AplicMediDetEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.FolioAplicacionMedicamento), ComparisonOperator.Equal, Me.FolioAplicacionMedicamento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdMedicamento), ComparisonOperator.Equal, Me.IdMedicamento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_aplicMediCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_aplicMediCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_aplicMediCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_aplicMediCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = True
			End If
			Return _aplicMediCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AplicMediCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property AplicMediCollectionViaAplicMediDetDet is requested or GetMultiAplicMediCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAplicMediCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_aplicMediCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_aplicMediCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaAplicMediDetDet(forceFetch, _productoCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchProductoCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "__AplicMediDetEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.FolioAplicacionMedicamento), ComparisonOperator.Equal, Me.FolioAplicacionMedicamento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdMedicamento), ComparisonOperator.Equal, Me.IdMedicamento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_productoCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_productoCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaAplicMediDetDet = True
			End If
			Return _productoCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property ProductoCollectionViaAplicMediDetDet is requested or GetMultiProductoCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_productoCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(forceFetch, _mcecatCorralesCabCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "__AplicMediDetEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.FolioAplicacionMedicamento), ComparisonOperator.Equal, Me.FolioAplicacionMedicamento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdMedicamento), ComparisonOperator.Equal, Me.IdMedicamento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_mcecatCorralesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = True
			End If
			Return _mcecatCorralesCabCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaAplicMediDetDet is requested or GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(forceFetch, _mcecatLotesCabCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "__AplicMediDetEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.FolioAplicacionMedicamento), ComparisonOperator.Equal, Me.FolioAplicacionMedicamento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdMedicamento), ComparisonOperator.Equal, Me.IdMedicamento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_mcecatLotesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = True
			End If
			Return _mcecatLotesCabCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaAplicMediDetDet is requested or GetMultiMcecatLotesCabCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'AplicMediEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'AplicMediEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAplicMedi() As AplicMediEntity
			Return GetSingleAplicMedi(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AplicMediEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AplicMediEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAplicMedi(forceFetch As Boolean) As AplicMediEntity
			If ( Not _alreadyFetchedAplicMedi Or forceFetch Or _alwaysFetchAplicMedi) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New AplicMediEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioAplicacionMedicamento)
				End If
				If Not _aplicMediReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.AplicMedi = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), AplicMediEntity)
					End If
					Me.AplicMedi = newEntity
					_alreadyFetchedAplicMedi = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _aplicMedi
		End Function
	
		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto() As ProductoEntity
			Return GetSingleProducto(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto(forceFetch As Boolean) As ProductoEntity
			If ( Not _alreadyFetchedProducto Or forceFetch Or _alwaysFetchProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProductoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdMedicamento)
				End If
				If Not _productoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Producto = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProductoEntity)
					End If
					Me.Producto = newEntity
					_alreadyFetchedProducto = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _producto
		End Function
	
		''' <summary>Retrieves the related entity of type 'McecatCorralesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McecatCorralesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatCorralesCab() As McecatCorralesCabEntity
			Return GetSingleMcecatCorralesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McecatCorralesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McecatCorralesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatCorralesCab(forceFetch As Boolean) As McecatCorralesCabEntity
			If ( Not _alreadyFetchedMcecatCorralesCab Or forceFetch Or _alwaysFetchMcecatCorralesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McecatCorralesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCorral)
				End If
				If Not _mcecatCorralesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McecatCorralesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McecatCorralesCabEntity)
					End If
					Me.McecatCorralesCab = newEntity
					_alreadyFetchedMcecatCorralesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcecatCorralesCab
		End Function
	
		''' <summary>Retrieves the related entity of type 'McecatLotesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McecatLotesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatLotesCab() As McecatLotesCabEntity
			Return GetSingleMcecatLotesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McecatLotesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McecatLotesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatLotesCab(forceFetch As Boolean) As McecatLotesCabEntity
			If ( Not _alreadyFetchedMcecatLotesCab Or forceFetch Or _alwaysFetchMcecatLotesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McecatLotesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdLote)
				End If
				If Not _mcecatLotesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McecatLotesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McecatLotesCabEntity)
					End If
					Me.McecatLotesCab = newEntity
					_alreadyFetchedMcecatLotesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcecatLotesCab
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(AplicMediDetFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, AplicMediDetFieldIndex)
					Case AplicMediDetFieldIndex.FolioAplicacionMedicamento
						DesetupSyncAplicMedi(True, False)
						_alreadyFetchedAplicMedi = False
					Case AplicMediDetFieldIndex.IdLote
						DesetupSyncMcecatLotesCab(True, False)
						_alreadyFetchedMcecatLotesCab = False
					Case AplicMediDetFieldIndex.IdMedicamento
						DesetupSyncProducto(True, False)
						_alreadyFetchedProducto = False
					Case AplicMediDetFieldIndex.IdCorral
						DesetupSyncMcecatCorralesCab(True, False)
						_alreadyFetchedMcecatCorralesCab = False







					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_aplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_aplicMediCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
		If Not _aplicMedi Is Nothing Then
				_aplicMedi.ActiveContext = MyBase.ActiveContext
			End If
		If Not _producto Is Nothing Then
				_producto.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcecatCorralesCab Is Nothing Then
				_mcecatCorralesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcecatLotesCab Is Nothing Then
				_mcecatLotesCab.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As AplicMediDetDAO = CType(CreateDAOInstance(), AplicMediDetDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As AplicMediDetDAO = CType(CreateDAOInstance(), AplicMediDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As AplicMediDetDAO = CType(CreateDAOInstance(), AplicMediDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this AplicMediDetEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AplicMediDetEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idLote">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="validator">The validator Object for this AplicMediDetEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_aplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(New AplicMediDetDetEntityFactory())
			_aplicMediDetDet.SetContainingEntityInfo(Me, "AplicMediDet")
			_alwaysFetchAplicMediDetDet = False
			_alreadyFetchedAplicMediDetDet = False
			_aplicMediCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_alwaysFetchAplicMediCollectionViaAplicMediDetDet = False
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = False
			_productoCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaAplicMediDetDet = False
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = False
			_mcecatCorralesCabCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = False
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = False
			_mcecatLotesCabCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = False
			_aplicMedi = Nothing
			_aplicMediReturnsNewIfNotFound = True
			_alwaysFetchAplicMedi = False
			_alreadyFetchedAplicMedi = False
			_producto = Nothing
			_productoReturnsNewIfNotFound = True
			_alwaysFetchProducto = False
			_alreadyFetchedProducto = False
			_mcecatCorralesCab = Nothing
			_mcecatCorralesCabReturnsNewIfNotFound = True
			_alwaysFetchMcecatCorralesCab = False
			_alreadyFetchedMcecatCorralesCab = False
			_mcecatLotesCab = Nothing
			_mcecatLotesCabReturnsNewIfNotFound = True
			_alwaysFetchMcecatLotesCab = False
			_alreadyFetchedMcecatLotesCab = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioAplicacionMedicamento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdLote", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdMedicamento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooTrab", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooReim", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CosProm", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _aplicMedi</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAplicMedi(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _aplicMedi, AddressOf OnAplicMediPropertyChanged, "AplicMedi", AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, True, signalRelatedEntity, "AplicMediDet", resetFKFields, New Integer() { CInt(AplicMediDetFieldIndex.FolioAplicacionMedicamento) } )
			_aplicMedi = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _aplicMedi</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAplicMedi(relatedEntity As IEntity)
			DesetupSyncAplicMedi(True, True)
			_aplicMedi = CType(relatedEntity, AplicMediEntity)
			MyBase.PerformSetupSyncRelatedEntity( _aplicMedi, AddressOf OnAplicMediPropertyChanged, "AplicMedi", AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, True, _alreadyFetchedAplicMedi, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAplicMediPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _producto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento, True, signalRelatedEntity, "AplicMediDet", resetFKFields, New Integer() { CInt(AplicMediDetFieldIndex.IdMedicamento) } )
			_producto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _producto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProducto(relatedEntity As IEntity)
			DesetupSyncProducto(True, True)
			_producto = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento, True, _alreadyFetchedProducto, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProductoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcecatCorralesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, True, signalRelatedEntity, "AplicMediDet", resetFKFields, New Integer() { CInt(AplicMediDetFieldIndex.IdCorral) } )
			_mcecatCorralesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcecatCorralesCab(relatedEntity As IEntity)
			DesetupSyncMcecatCorralesCab(True, True)
			_mcecatCorralesCab = CType(relatedEntity, McecatCorralesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, True, _alreadyFetchedMcecatCorralesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcecatCorralesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcecatLotesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcecatLotesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcecatLotesCab, AddressOf OnMcecatLotesCabPropertyChanged, "McecatLotesCab", AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote, True, signalRelatedEntity, "AplicMediDet", resetFKFields, New Integer() { CInt(AplicMediDetFieldIndex.IdLote) } )
			_mcecatLotesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcecatLotesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcecatLotesCab(relatedEntity As IEntity)
			DesetupSyncMcecatLotesCab(True, True)
			_mcecatLotesCab = CType(relatedEntity, McecatLotesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcecatLotesCab, AddressOf OnMcecatLotesCabPropertyChanged, "McecatLotesCab", AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote, True, _alreadyFetchedMcecatLotesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcecatLotesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idLote">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDet which data should be fetched into this AplicMediDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(AplicMediDetFieldIndex.FolioAplicacionMedicamento)).ForcedCurrentValueWrite(folioAplicacionMedicamento)
				MyBase.Fields(CInt(AplicMediDetFieldIndex.IdLote)).ForcedCurrentValueWrite(idLote)
				MyBase.Fields(CInt(AplicMediDetFieldIndex.IdMedicamento)).ForcedCurrentValueWrite(idMedicamento)
				MyBase.Fields(CInt(AplicMediDetFieldIndex.IdCorral)).ForcedCurrentValueWrite(idCorral)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateAplicMediDetDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New AplicMediDetEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As AplicMediDetRelations
			Get	
				Return New AplicMediDetRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDetDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDetDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(), _
					AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, _
					CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "__AplicMediDetEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, _
					CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "__AplicMediDetEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, _
					CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "__AplicMediDetEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, _
					CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "__AplicMediDetEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					AplicMediDetEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, _
					CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMedi() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMedi", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatCorralesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatLotesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "AplicMediDetEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return AplicMediDetEntity.CustomProperties
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
				Return AplicMediDetEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolioAplicacionMedicamento property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."FolioAplicacionMedicamento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioAplicacionMedicamento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.FolioAplicacionMedicamento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.FolioAplicacionMedicamento, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdLote property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."IdLote"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdLote]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.IdLote, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.IdLote, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdMedicamento property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."IdMedicamento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdMedicamento]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.IdMedicamento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.IdMedicamento, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCorral property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."IdCorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdCorral]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.IdCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.IdCorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooTrab property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."Boo_Trab"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooTrab]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.BooTrab, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.BooTrab, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooReim property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."Boo_Reim"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooReim]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.BooReim, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.BooReim, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cantidad property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."Cantidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cantidad]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.Cantidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.Cantidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The CosProm property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."CosProm"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CosProm]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.CosProm, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.CosProm, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cabezas property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."Cabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cabezas]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.Cabezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.Cabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The Kilos property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."Kilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Kilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.Kilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.Kilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity AplicMediDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDet"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AplicMediDetDet]() As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			Get
				Return GetMultiAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMediDetDet. When set to true, AplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchAplicMediDetDet
			End Get
			Set
				_alwaysFetchAplicMediDetDet = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAplicMediCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AplicMediCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.AplicMediCollection
			Get
				Return GetMultiAplicMediCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMediCollectionViaAplicMediDetDet. When set to true, AplicMediCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMediCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiAplicMediCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMediCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchAplicMediCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchAplicMediCollectionViaAplicMediDetDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaAplicMediDetDet. When set to true, ProductoCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchProductoCollectionViaAplicMediDetDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaAplicMediDetDet. When set to true, McecatCorralesCabCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaAplicMediDetDet. When set to true, McecatLotesCabCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'AplicMediEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAplicMedi()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [AplicMedi]() As AplicMediEntity
			Get
				Return GetSingleAplicMedi(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAplicMedi(value)
				Else
					If value Is Nothing Then
						If Not _aplicMedi Is Nothing Then
							_aplicMedi.UnsetRelatedEntity(Me, "AplicMediDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMediDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMedi. When set to true, AplicMedi is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMedi is accessed. You can always execute
		''' a forced fetch by calling GetSingleAplicMedi(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMedi As Boolean
			Get
				Return _alwaysFetchAplicMedi
			End Get
			Set
				_alwaysFetchAplicMedi = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property AplicMedi is not found
		''' in the database. When set to true, AplicMedi will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property AplicMediReturnsNewIfNotFound As Boolean
			Get
				Return _aplicMediReturnsNewIfNotFound
			End Get
			Set
				_aplicMediReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'ProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Producto]() As ProductoEntity
			Get
				Return GetSingleProducto(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProducto(value)
				Else
					If value Is Nothing Then
						If Not _producto Is Nothing Then
							_producto.UnsetRelatedEntity(Me, "AplicMediDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMediDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Producto. When set to true, Producto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Producto is accessed. You can always execute
		''' a forced fetch by calling GetSingleProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProducto As Boolean
			Get
				Return _alwaysFetchProducto
			End Get
			Set
				_alwaysFetchProducto = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Producto is not found
		''' in the database. When set to true, Producto will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProductoReturnsNewIfNotFound As Boolean
			Get
				Return _productoReturnsNewIfNotFound
			End Get
			Set
				_productoReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McecatCorralesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcecatCorralesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McecatCorralesCab]() As McecatCorralesCabEntity
			Get
				Return GetSingleMcecatCorralesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcecatCorralesCab(value)
				Else
					If value Is Nothing Then
						If Not _mcecatCorralesCab Is Nothing Then
							_mcecatCorralesCab.UnsetRelatedEntity(Me, "AplicMediDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMediDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCab. When set to true, McecatCorralesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcecatCorralesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCab As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCab
			End Get
			Set
				_alwaysFetchMcecatCorralesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McecatCorralesCab is not found
		''' in the database. When set to true, McecatCorralesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McecatCorralesCabReturnsNewIfNotFound As Boolean
			Get
				Return _mcecatCorralesCabReturnsNewIfNotFound
			End Get
			Set
				_mcecatCorralesCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McecatLotesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcecatLotesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McecatLotesCab]() As McecatLotesCabEntity
			Get
				Return GetSingleMcecatLotesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcecatLotesCab(value)
				Else
					If value Is Nothing Then
						If Not _mcecatLotesCab Is Nothing Then
							_mcecatLotesCab.UnsetRelatedEntity(Me, "AplicMediDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMediDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCab. When set to true, McecatLotesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcecatLotesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCab As Boolean
			Get
				Return _alwaysFetchMcecatLotesCab
			End Get
			Set
				_alwaysFetchMcecatLotesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McecatLotesCab is not found
		''' in the database. When set to true, McecatLotesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McecatLotesCabReturnsNewIfNotFound As Boolean
			Get
				Return _mcecatLotesCabReturnsNewIfNotFound
			End Get
			Set
				_mcecatLotesCabReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.AplicMediDetEntity)
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
