' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 8 de febrero de 2018 12:25:22
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
	''' <summary>Entity class which represents the entity 'CatLugaresDeCompra'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CatLugaresDeCompraEntity 
#Else
	<Serializable()> _
	Public Class CatLugaresDeCompraEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cabRegCom As Integralab.ORM.CollectionClasses.CabRegComCollection
		Private _alwaysFetchCabRegCom, _alreadyFetchedCabRegCom As Boolean
		Private _proveedor As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor As Boolean
		Private _cabMovGanCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaCabRegCom, _alreadyFetchedCabMovGanCollectionViaCabRegCom As Boolean
		Private _cabMovGanCollectionViaCabRegCom_ As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaCabRegCom_, _alreadyFetchedCabMovGanCollectionViaCabRegCom_ As Boolean
		Private _proveedorCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaCabRegCom, _alreadyFetchedProveedorCollectionViaCabRegCom As Boolean
		Private _mcecatCorralesCabCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom, _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom As Boolean
		Private _mcgcatCompradoresdeGanadoCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
		Private _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom, _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom As Boolean
		Private _contDiotTiposOperacionCollectionViaProveedor As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
		Private _alwaysFetchContDiotTiposOperacionCollectionViaProveedor, _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor As Boolean
		Private _contDiotTiposTercerosCollectionViaProveedor As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
		Private _alwaysFetchContDiotTiposTercerosCollectionViaProveedor, _alreadyFetchedContDiotTiposTercerosCollectionViaProveedor As Boolean
		Private _cuentaContableCollectionViaProveedor As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaProveedor, _alreadyFetchedCuentaContableCollectionViaProveedor As Boolean
		Private _cuentaContableCollectionViaProveedor_ As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaProveedor_, _alreadyFetchedCuentaContableCollectionViaProveedor_ As Boolean



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
		''' <param name="idLugarCompra">PK value for CatLugaresDeCompra which data should be fetched into this CatLugaresDeCompra Object</param>
		Public Sub New(idLugarCompra As System.Int32)

			InitClassFetch(idLugarCompra, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idLugarCompra">PK value for CatLugaresDeCompra which data should be fetched into this CatLugaresDeCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idLugarCompra As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idLugarCompra, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idLugarCompra">PK value for CatLugaresDeCompra which data should be fetched into this CatLugaresDeCompra Object</param>
		''' <param name="validator">The custom validator Object for this CatLugaresDeCompraEntity</param>
		Public Sub New(idLugarCompra As System.Int32, validator As IValidator)

			InitClassFetch(idLugarCompra, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cabRegCom = CType(info.GetValue("_cabRegCom", GetType(Integralab.ORM.CollectionClasses.CabRegComCollection)), Integralab.ORM.CollectionClasses.CabRegComCollection)
			_alwaysFetchCabRegCom = info.GetBoolean("_alwaysFetchCabRegCom")
			_alreadyFetchedCabRegCom = info.GetBoolean("_alreadyFetchedCabRegCom")
			_proveedor = CType(info.GetValue("_proveedor", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")
			_cabMovGanCollectionViaCabRegCom = CType(info.GetValue("_cabMovGanCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaCabRegCom")
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaCabRegCom")
			_cabMovGanCollectionViaCabRegCom_ = CType(info.GetValue("_cabMovGanCollectionViaCabRegCom_", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaCabRegCom_ = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaCabRegCom_")
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaCabRegCom_")
			_proveedorCollectionViaCabRegCom = CType(info.GetValue("_proveedorCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchProveedorCollectionViaCabRegCom")
			_alreadyFetchedProveedorCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedProveedorCollectionViaCabRegCom")
			_mcecatCorralesCabCollectionViaCabRegCom = CType(info.GetValue("_mcecatCorralesCabCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom")
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom")
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom = CType(info.GetValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom")
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom")
			_contDiotTiposOperacionCollectionViaProveedor = CType(info.GetValue("_contDiotTiposOperacionCollectionViaProveedor", GetType(Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection)), Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection)
			_alwaysFetchContDiotTiposOperacionCollectionViaProveedor = info.GetBoolean("_alwaysFetchContDiotTiposOperacionCollectionViaProveedor")
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = info.GetBoolean("_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor")
			_contDiotTiposTercerosCollectionViaProveedor = CType(info.GetValue("_contDiotTiposTercerosCollectionViaProveedor", GetType(Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection)), Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection)
			_alwaysFetchContDiotTiposTercerosCollectionViaProveedor = info.GetBoolean("_alwaysFetchContDiotTiposTercerosCollectionViaProveedor")
			_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = info.GetBoolean("_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor")
			_cuentaContableCollectionViaProveedor = CType(info.GetValue("_cuentaContableCollectionViaProveedor", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaProveedor = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaProveedor")
			_alreadyFetchedCuentaContableCollectionViaProveedor = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaProveedor")
			_cuentaContableCollectionViaProveedor_ = CType(info.GetValue("_cuentaContableCollectionViaProveedor_", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaProveedor_ = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaProveedor_")
			_alreadyFetchedCuentaContableCollectionViaProveedor_ = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaProveedor_")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCabRegCom = (_cabRegCom.Count > 0)
			_alreadyFetchedProveedor = (_proveedor.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = (_cabMovGanCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = (_cabMovGanCollectionViaCabRegCom_.Count > 0)
			_alreadyFetchedProveedorCollectionViaCabRegCom = (_proveedorCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = (_mcecatCorralesCabCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = (_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = (_contDiotTiposOperacionCollectionViaProveedor.Count > 0)
			_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = (_contDiotTiposTercerosCollectionViaProveedor.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaProveedor = (_cuentaContableCollectionViaProveedor.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaProveedor_ = (_cuentaContableCollectionViaProveedor_.Count > 0)


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
			info.AddValue("_cabRegCom", _cabRegCom)
			info.AddValue("_alwaysFetchCabRegCom", _alwaysFetchCabRegCom)
			info.AddValue("_alreadyFetchedCabRegCom", _alreadyFetchedCabRegCom)
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)
			info.AddValue("_cabMovGanCollectionViaCabRegCom", _cabMovGanCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaCabRegCom", _alwaysFetchCabMovGanCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaCabRegCom", _alreadyFetchedCabMovGanCollectionViaCabRegCom)
			info.AddValue("_cabMovGanCollectionViaCabRegCom_", _cabMovGanCollectionViaCabRegCom_)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaCabRegCom_", _alwaysFetchCabMovGanCollectionViaCabRegCom_)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaCabRegCom_", _alreadyFetchedCabMovGanCollectionViaCabRegCom_)
			info.AddValue("_proveedorCollectionViaCabRegCom", _proveedorCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchProveedorCollectionViaCabRegCom", _alwaysFetchProveedorCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedProveedorCollectionViaCabRegCom", _alreadyFetchedProveedorCollectionViaCabRegCom)
			info.AddValue("_mcecatCorralesCabCollectionViaCabRegCom", _mcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom", _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom", _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom", _mcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom", _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom", _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_contDiotTiposOperacionCollectionViaProveedor", _contDiotTiposOperacionCollectionViaProveedor)
			info.AddValue("_alwaysFetchContDiotTiposOperacionCollectionViaProveedor", _alwaysFetchContDiotTiposOperacionCollectionViaProveedor)
			info.AddValue("_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor", _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor)
			info.AddValue("_contDiotTiposTercerosCollectionViaProveedor", _contDiotTiposTercerosCollectionViaProveedor)
			info.AddValue("_alwaysFetchContDiotTiposTercerosCollectionViaProveedor", _alwaysFetchContDiotTiposTercerosCollectionViaProveedor)
			info.AddValue("_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor", _alreadyFetchedContDiotTiposTercerosCollectionViaProveedor)
			info.AddValue("_cuentaContableCollectionViaProveedor", _cuentaContableCollectionViaProveedor)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaProveedor", _alwaysFetchCuentaContableCollectionViaProveedor)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaProveedor", _alreadyFetchedCuentaContableCollectionViaProveedor)
			info.AddValue("_cuentaContableCollectionViaProveedor_", _cuentaContableCollectionViaProveedor_)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaProveedor_", _alwaysFetchCuentaContableCollectionViaProveedor_)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaProveedor_", _alreadyFetchedCuentaContableCollectionViaProveedor_)


			
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

				Case "CabRegCom"
					_alreadyFetchedCabRegCom = True
					If Not entity Is Nothing Then
						Me.CabRegCom.Add(CType(entity, CabRegComEntity))
					End If
				Case "Proveedor"
					_alreadyFetchedProveedor = True
					If Not entity Is Nothing Then
						Me.Proveedor.Add(CType(entity, ProveedorEntity))
					End If
				Case "CabMovGanCollectionViaCabRegCom"
					_alreadyFetchedCabMovGanCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.CabMovGanCollectionViaCabRegCom.Add(CType(entity, CabMovGanEntity))
					End If
				Case "CabMovGanCollectionViaCabRegCom_"
					_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = True
					If Not entity Is Nothing Then
						Me.CabMovGanCollectionViaCabRegCom_.Add(CType(entity, CabMovGanEntity))
					End If
				Case "ProveedorCollectionViaCabRegCom"
					_alreadyFetchedProveedorCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaCabRegCom.Add(CType(entity, ProveedorEntity))
					End If
				Case "McecatCorralesCabCollectionViaCabRegCom"
					_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaCabRegCom.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McgcatCompradoresdeGanadoCollectionViaCabRegCom"
					_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.McgcatCompradoresdeGanadoCollectionViaCabRegCom.Add(CType(entity, McgcatCompradoresdeGanadoEntity))
					End If
				Case "ContDiotTiposOperacionCollectionViaProveedor"
					_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = True
					If Not entity Is Nothing Then
						Me.ContDiotTiposOperacionCollectionViaProveedor.Add(CType(entity, ContDiotTiposOperacionEntity))
					End If
				Case "ContDiotTiposTercerosCollectionViaProveedor"
					_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = True
					If Not entity Is Nothing Then
						Me.ContDiotTiposTercerosCollectionViaProveedor.Add(CType(entity, ContDiotTiposTercerosEntity))
					End If
				Case "CuentaContableCollectionViaProveedor"
					_alreadyFetchedCuentaContableCollectionViaProveedor = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaProveedor.Add(CType(entity, CuentaContableEntity))
					End If
				Case "CuentaContableCollectionViaProveedor_"
					_alreadyFetchedCuentaContableCollectionViaProveedor_ = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaProveedor_.Add(CType(entity, CuentaContableEntity))
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

				Case "CabRegCom"
					_cabRegCom.Add(CType(relatedEntity, CabRegComEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Proveedor"
					_proveedor.Add(CType(relatedEntity, ProveedorEntity))
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

				Case "CabRegCom"
					MyBase.PerformRelatedEntityRemoval(_cabRegCom, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Proveedor"
					MyBase.PerformRelatedEntityRemoval(_proveedor, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_cabRegCom)
			toReturn.Add(_proveedor)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idLugarCompra">PK value for CatLugaresDeCompra which data should be fetched into this CatLugaresDeCompra Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idLugarCompra As System.Int32) As Boolean
			Return FetchUsingPK(idLugarCompra, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idLugarCompra">PK value for CatLugaresDeCompra which data should be fetched into this CatLugaresDeCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idLugarCompra As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idLugarCompra, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idLugarCompra">PK value for CatLugaresDeCompra which data should be fetched into this CatLugaresDeCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idLugarCompra As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idLugarCompra, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdLugarCompra, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CatLugaresDeCompraFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CatLugaresDeCompraFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabRegComEntity'</returns>
		Public Function GetMultiCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom(forceFetch, _cabRegCom.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabRegComEntity'</returns>
		Public Function GetMultiCabRegCom(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom(forceFetch, _cabRegCom.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabRegComCollection
			If ( Not _alreadyFetchedCabRegCom Or forceFetch Or _alwaysFetchCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabRegCom)
					End If
				End If
				_cabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabRegCom.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Nothing, Filter)
				_cabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedCabRegCom = True
			End If
			Return _cabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabRegCom'. These settings will be taken into account
		''' when the property CabRegCom is requested or GetMultiCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabRegCom.SortClauses=sortClauses
			_cabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor(forceFetch, _proveedor.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedor(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor(forceFetch, _proveedor.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedor Or forceFetch Or _alwaysFetchProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedor)
					End If
				End If
				_proveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedor.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Filter)
				_proveedor.SuppressClearInGetMulti = False
				_alreadyFetchedProveedor = True
			End If
			Return _proveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Proveedor'. These settings will be taken into account
		''' when the property Proveedor is requested or GetMultiProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedor.SortClauses=sortClauses
			_proveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabMovGanEntity'</returns>
		Public Function GetMultiCabMovGanCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Return GetMultiCabMovGanCollectionViaCabRegCom(forceFetch, _cabMovGanCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabMovGanCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			If ( Not _alreadyFetchedCabMovGanCollectionViaCabRegCom Or forceFetch Or _alwaysFetchCabMovGanCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabMovGanCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabMovGanCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), ComparisonOperator.Equal, Me.IdLugarCompra))
				_cabMovGanCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabMovGanCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabMovGanCollectionViaCabRegCom.GetMulti(Filter, relations)
				_cabMovGanCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedCabMovGanCollectionViaCabRegCom = True
			End If
			Return _cabMovGanCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabMovGanCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property CabMovGanCollectionViaCabRegCom is requested or GetMultiCabMovGanCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabMovGanCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabMovGanCollectionViaCabRegCom.SortClauses=sortClauses
			_cabMovGanCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabMovGanEntity'</returns>
		Public Function GetMultiCabMovGanCollectionViaCabRegCom_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Return GetMultiCabMovGanCollectionViaCabRegCom_(forceFetch, _cabMovGanCollectionViaCabRegCom_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabMovGanCollectionViaCabRegCom_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			If ( Not _alreadyFetchedCabMovGanCollectionViaCabRegCom_ Or forceFetch Or _alwaysFetchCabMovGanCollectionViaCabRegCom_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabMovGanCollectionViaCabRegCom_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabMovGanCollectionViaCabRegCom_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), ComparisonOperator.Equal, Me.IdLugarCompra))
				_cabMovGanCollectionViaCabRegCom_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabMovGanCollectionViaCabRegCom_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabMovGanCollectionViaCabRegCom_.GetMulti(Filter, relations)
				_cabMovGanCollectionViaCabRegCom_.SuppressClearInGetMulti = False
				_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = True
			End If
			Return _cabMovGanCollectionViaCabRegCom_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabMovGanCollectionViaCabRegCom_'. These settings will be taken into account
		''' when the property CabMovGanCollectionViaCabRegCom_ is requested or GetMultiCabMovGanCollectionViaCabRegCom_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabMovGanCollectionViaCabRegCom_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabMovGanCollectionViaCabRegCom_.SortClauses=sortClauses
			_cabMovGanCollectionViaCabRegCom_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaCabRegCom(forceFetch, _proveedorCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaCabRegCom Or forceFetch Or _alwaysFetchProveedorCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), ComparisonOperator.Equal, Me.IdLugarCompra))
				_proveedorCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaCabRegCom.GetMulti(Filter, relations)
				_proveedorCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaCabRegCom = True
			End If
			Return _proveedorCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property ProveedorCollectionViaCabRegCom is requested or GetMultiProveedorCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaCabRegCom.SortClauses=sortClauses
			_proveedorCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch, _mcecatCorralesCabCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), ComparisonOperator.Equal, Me.IdLugarCompra))
				_mcecatCorralesCabCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaCabRegCom.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = True
			End If
			Return _mcecatCorralesCabCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaCabRegCom is requested or GetMultiMcecatCorralesCabCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaCabRegCom.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatCompradoresdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Return GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(forceFetch, _mcgcatCompradoresdeGanadoCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom Or forceFetch Or _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatCompradoresdeGanadoCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatCompradoresdeGanadoCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), ComparisonOperator.Equal, Me.IdLugarCompra))
				_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.GetMulti(Filter, relations)
				_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = True
			End If
			Return _mcgcatCompradoresdeGanadoCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatCompradoresdeGanadoCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property McgcatCompradoresdeGanadoCollectionViaCabRegCom is requested or GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatCompradoresdeGanadoCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.SortClauses=sortClauses
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ContDiotTiposOperacionEntity'</returns>
		Public Function GetMultiContDiotTiposOperacionCollectionViaProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			Return GetMultiContDiotTiposOperacionCollectionViaProveedor(forceFetch, _contDiotTiposOperacionCollectionViaProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiContDiotTiposOperacionCollectionViaProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			If ( Not _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor Or forceFetch Or _alwaysFetchContDiotTiposOperacionCollectionViaProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _contDiotTiposOperacionCollectionViaProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_contDiotTiposOperacionCollectionViaProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, "__CatLugaresDeCompraEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), ComparisonOperator.Equal, Me.IdLugarCompra))
				_contDiotTiposOperacionCollectionViaProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_contDiotTiposOperacionCollectionViaProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_contDiotTiposOperacionCollectionViaProveedor.GetMulti(Filter, relations)
				_contDiotTiposOperacionCollectionViaProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = True
			End If
			Return _contDiotTiposOperacionCollectionViaProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ContDiotTiposOperacionCollectionViaProveedor'. These settings will be taken into account
		''' when the property ContDiotTiposOperacionCollectionViaProveedor is requested or GetMultiContDiotTiposOperacionCollectionViaProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersContDiotTiposOperacionCollectionViaProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_contDiotTiposOperacionCollectionViaProveedor.SortClauses=sortClauses
			_contDiotTiposOperacionCollectionViaProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ContDiotTiposTercerosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ContDiotTiposTercerosEntity'</returns>
		Public Function GetMultiContDiotTiposTercerosCollectionViaProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
			Return GetMultiContDiotTiposTercerosCollectionViaProveedor(forceFetch, _contDiotTiposTercerosCollectionViaProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ContDiotTiposTercerosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiContDiotTiposTercerosCollectionViaProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
			If ( Not _alreadyFetchedContDiotTiposTercerosCollectionViaProveedor Or forceFetch Or _alwaysFetchContDiotTiposTercerosCollectionViaProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _contDiotTiposTercerosCollectionViaProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_contDiotTiposTercerosCollectionViaProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, "__CatLugaresDeCompraEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), ComparisonOperator.Equal, Me.IdLugarCompra))
				_contDiotTiposTercerosCollectionViaProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_contDiotTiposTercerosCollectionViaProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_contDiotTiposTercerosCollectionViaProveedor.GetMulti(Filter, relations)
				_contDiotTiposTercerosCollectionViaProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = True
			End If
			Return _contDiotTiposTercerosCollectionViaProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ContDiotTiposTercerosCollectionViaProveedor'. These settings will be taken into account
		''' when the property ContDiotTiposTercerosCollectionViaProveedor is requested or GetMultiContDiotTiposTercerosCollectionViaProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersContDiotTiposTercerosCollectionViaProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_contDiotTiposTercerosCollectionViaProveedor.SortClauses=sortClauses
			_contDiotTiposTercerosCollectionViaProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaProveedor(forceFetch, _cuentaContableCollectionViaProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaProveedor Or forceFetch Or _alwaysFetchCuentaContableCollectionViaProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, "__CatLugaresDeCompraEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CuentaContableEntityUsingCuentaContId, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), ComparisonOperator.Equal, Me.IdLugarCompra))
				_cuentaContableCollectionViaProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaProveedor.GetMulti(Filter, relations)
				_cuentaContableCollectionViaProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaProveedor = True
			End If
			Return _cuentaContableCollectionViaProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaProveedor'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaProveedor is requested or GetMultiCuentaContableCollectionViaProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaProveedor.SortClauses=sortClauses
			_cuentaContableCollectionViaProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaProveedor_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaProveedor_(forceFetch, _cuentaContableCollectionViaProveedor_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaProveedor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaProveedor_ Or forceFetch Or _alwaysFetchCuentaContableCollectionViaProveedor_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaProveedor_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaProveedor_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, "__CatLugaresDeCompraEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CuentaContableEntityUsingPrCuentaAnt, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), ComparisonOperator.Equal, Me.IdLugarCompra))
				_cuentaContableCollectionViaProveedor_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaProveedor_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaProveedor_.GetMulti(Filter, relations)
				_cuentaContableCollectionViaProveedor_.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaProveedor_ = True
			End If
			Return _cuentaContableCollectionViaProveedor_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaProveedor_'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaProveedor_ is requested or GetMultiCuentaContableCollectionViaProveedor_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaProveedor_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaProveedor_.SortClauses=sortClauses
			_cuentaContableCollectionViaProveedor_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CatLugaresDeCompraFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CatLugaresDeCompraFieldIndex)







					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cabRegCom.ActiveContext = MyBase.ActiveContext
			_proveedor.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaCabRegCom_.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_contDiotTiposOperacionCollectionViaProveedor.ActiveContext = MyBase.ActiveContext
			_contDiotTiposTercerosCollectionViaProveedor.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaProveedor.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaProveedor_.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CatLugaresDeCompraDAO = CType(CreateDAOInstance(), CatLugaresDeCompraDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CatLugaresDeCompraDAO = CType(CreateDAOInstance(), CatLugaresDeCompraDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CatLugaresDeCompraDAO = CType(CreateDAOInstance(), CatLugaresDeCompraDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CatLugaresDeCompraEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CatLugaresDeCompraEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idLugarCompra">PK value for CatLugaresDeCompra which data should be fetched into this CatLugaresDeCompra Object</param>
		''' <param name="validator">The validator Object for this CatLugaresDeCompraEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idLugarCompra As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idLugarCompra, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_cabRegCom = New Integralab.ORM.CollectionClasses.CabRegComCollection(New CabRegComEntityFactory())
			_cabRegCom.SetContainingEntityInfo(Me, "CatLugaresDeCompra")
			_alwaysFetchCabRegCom = False
			_alreadyFetchedCabRegCom = False
			_proveedor = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_proveedor.SetContainingEntityInfo(Me, "CatLugaresDeCompra")
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False
			_cabMovGanCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaCabRegCom = False
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = False
			_cabMovGanCollectionViaCabRegCom_ = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaCabRegCom_ = False
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = False
			_proveedorCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaCabRegCom = False
			_alreadyFetchedProveedorCollectionViaCabRegCom = False
			_mcecatCorralesCabCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = False
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = False
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(New McgcatCompradoresdeGanadoEntityFactory())
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = False
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = False
			_contDiotTiposOperacionCollectionViaProveedor = New Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection(New ContDiotTiposOperacionEntityFactory())
			_alwaysFetchContDiotTiposOperacionCollectionViaProveedor = False
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = False
			_contDiotTiposTercerosCollectionViaProveedor = New Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection(New ContDiotTiposTercerosEntityFactory())
			_alwaysFetchContDiotTiposTercerosCollectionViaProveedor = False
			_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = False
			_cuentaContableCollectionViaProveedor = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaProveedor = False
			_alreadyFetchedCuentaContableCollectionViaProveedor = False
			_cuentaContableCollectionViaProveedor_ = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaProveedor_ = False
			_alreadyFetchedCuentaContableCollectionViaProveedor_ = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdLugarCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdEstado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCiudad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoblacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("HorasTransporte", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idLugarCompra">PK value for CatLugaresDeCompra which data should be fetched into this CatLugaresDeCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idLugarCompra As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CatLugaresDeCompraFieldIndex.IdLugarCompra)).ForcedCurrentValueWrite(idLugarCompra)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCatLugaresDeCompraDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CatLugaresDeCompraEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CatLugaresDeCompraRelations
			Get	
				Return New CatLugaresDeCompraRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabRegCom() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabRegComCollection(), _
					CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), 0, Nothing, Nothing, Nothing, "CabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaCabRegCom_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaCabRegCom_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCompradoresdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCompradoresdeGanadoCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, "__CatLugaresDeCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(), _
					CatLugaresDeCompraEntity.Relations.CabRegComEntityUsingCveLugCom, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatCompradoresdeGanadoCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContDiotTiposOperacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathContDiotTiposOperacionCollectionViaProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, "__CatLugaresDeCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection(), _
					CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.ContDiotTiposOperacionEntity, Integer), 0, Nothing, Nothing, relations, "ContDiotTiposOperacionCollectionViaProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContDiotTiposTerceros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathContDiotTiposTercerosCollectionViaProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, "__CatLugaresDeCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection(), _
					CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity, Integer), 0, Nothing, Nothing, relations, "ContDiotTiposTercerosCollectionViaProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, "__CatLugaresDeCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CuentaContableEntityUsingCuentaContId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaProveedor_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, "__CatLugaresDeCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CuentaContableEntityUsingPrCuentaAnt)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CatLugaresDeCompraEntity.Relations.ProveedorEntityUsingIdLugarCompra, _
					CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaProveedor_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CatLugaresDeCompraEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CatLugaresDeCompraEntity.CustomProperties
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
				Return CatLugaresDeCompraEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdLugarCompra property of the Entity CatLugaresDeCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatLugaresDeCompra"."IdLugarCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdLugarCompra]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatLugaresDeCompraFieldIndex.IdLugarCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CatLugaresDeCompraFieldIndex.IdLugarCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity CatLugaresDeCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatLugaresDeCompra"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatLugaresDeCompraFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CatLugaresDeCompraFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdEstado property of the Entity CatLugaresDeCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatLugaresDeCompra"."IdEstado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdEstado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatLugaresDeCompraFieldIndex.IdEstado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CatLugaresDeCompraFieldIndex.IdEstado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCiudad property of the Entity CatLugaresDeCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatLugaresDeCompra"."IdCiudad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCiudad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatLugaresDeCompraFieldIndex.IdCiudad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CatLugaresDeCompraFieldIndex.IdCiudad, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoblacion property of the Entity CatLugaresDeCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatLugaresDeCompra"."IdPoblacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPoblacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatLugaresDeCompraFieldIndex.IdPoblacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CatLugaresDeCompraFieldIndex.IdPoblacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity CatLugaresDeCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatLugaresDeCompra"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatLugaresDeCompraFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CatLugaresDeCompraFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The HorasTransporte property of the Entity CatLugaresDeCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatLugaresDeCompra"."HorasTransporte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [HorasTransporte]() As System.Double
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatLugaresDeCompraFieldIndex.HorasTransporte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Double))
				End If
				Return CType(valueToReturn, System.Double)
			End Get
			Set
				SetNewFieldValue(CType(CatLugaresDeCompraFieldIndex.HorasTransporte, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabRegCom]() As Integralab.ORM.CollectionClasses.CabRegComCollection
			Get
				Return GetMultiCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabRegCom. When set to true, CabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabRegCom As Boolean
			Get
				Return _alwaysFetchCabRegCom
			End Get
			Set
				_alwaysFetchCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Proveedor]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Proveedor. When set to true, Proveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Proveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedor As Boolean
			Get
				Return _alwaysFetchProveedor
			End Get
			Set
				_alwaysFetchProveedor = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabMovGanCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabMovGanCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Get
				Return GetMultiCabMovGanCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGanCollectionViaCabRegCom. When set to true, CabMovGanCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGanCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabMovGanCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGanCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchCabMovGanCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchCabMovGanCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabMovGanCollectionViaCabRegCom_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabMovGanCollectionViaCabRegCom_]() As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Get
				Return GetMultiCabMovGanCollectionViaCabRegCom_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGanCollectionViaCabRegCom_. When set to true, CabMovGanCollectionViaCabRegCom_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGanCollectionViaCabRegCom_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabMovGanCollectionViaCabRegCom_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGanCollectionViaCabRegCom_ As Boolean
			Get
				Return _alwaysFetchCabMovGanCollectionViaCabRegCom_
			End Get
			Set
				_alwaysFetchCabMovGanCollectionViaCabRegCom_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaCabRegCom. When set to true, ProveedorCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchProveedorCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaCabRegCom. When set to true, McecatCorralesCabCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatCompradoresdeGanadoCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Get
				Return GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatCompradoresdeGanadoCollectionViaCabRegCom. When set to true, McgcatCompradoresdeGanadoCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatCompradoresdeGanadoCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContDiotTiposOperacionCollectionViaProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ContDiotTiposOperacionCollectionViaProveedor]() As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			Get
				Return GetMultiContDiotTiposOperacionCollectionViaProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ContDiotTiposOperacionCollectionViaProveedor. When set to true, ContDiotTiposOperacionCollectionViaProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ContDiotTiposOperacionCollectionViaProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiContDiotTiposOperacionCollectionViaProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchContDiotTiposOperacionCollectionViaProveedor As Boolean
			Get
				Return _alwaysFetchContDiotTiposOperacionCollectionViaProveedor
			End Get
			Set
				_alwaysFetchContDiotTiposOperacionCollectionViaProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ContDiotTiposTercerosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContDiotTiposTercerosCollectionViaProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ContDiotTiposTercerosCollectionViaProveedor]() As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
			Get
				Return GetMultiContDiotTiposTercerosCollectionViaProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ContDiotTiposTercerosCollectionViaProveedor. When set to true, ContDiotTiposTercerosCollectionViaProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ContDiotTiposTercerosCollectionViaProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiContDiotTiposTercerosCollectionViaProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchContDiotTiposTercerosCollectionViaProveedor As Boolean
			Get
				Return _alwaysFetchContDiotTiposTercerosCollectionViaProveedor
			End Get
			Set
				_alwaysFetchContDiotTiposTercerosCollectionViaProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaProveedor]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaProveedor. When set to true, CuentaContableCollectionViaProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaProveedor As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaProveedor
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaProveedor_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaProveedor_]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaProveedor_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaProveedor_. When set to true, CuentaContableCollectionViaProveedor_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaProveedor_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaProveedor_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaProveedor_ As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaProveedor_
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaProveedor_ = value
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
				Return CInt(Integralab.ORM.EntityType.CatLugaresDeCompraEntity)
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
