' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 17:52:56
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
	''' <summary>Entity class which represents the entity 'Cuenta'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CuentaEntity 
#Else
	<Serializable()> _
	Public Class CuentaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mveCta As Integralab.ORM.CollectionClasses.MveCtaCollection
		Private _alwaysFetchMveCta, _alreadyFetchedMveCta As Boolean
		Private _cheque As Integralab.ORM.CollectionClasses.ChequeCollection
		Private _alwaysFetchCheque, _alreadyFetchedCheque As Boolean
		Private _cheque_ As Integralab.ORM.CollectionClasses.ChequeCollection
		Private _alwaysFetchCheque_, _alreadyFetchedCheque_ As Boolean
		Private _usrBanDepositos As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
		Private _alwaysFetchUsrBanDepositos, _alreadyFetchedUsrBanDepositos As Boolean
		Private _usrCxppagosProveedores As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
		Private _alwaysFetchUsrCxppagosProveedores, _alreadyFetchedUsrCxppagosProveedores As Boolean
		Private _beneficiarioCollectionViaCheque As Integralab.ORM.CollectionClasses.BeneficiarioCollection
		Private _alwaysFetchBeneficiarioCollectionViaCheque, _alreadyFetchedBeneficiarioCollectionViaCheque As Boolean
		Private _beneficiarioCollectionViaCheque_ As Integralab.ORM.CollectionClasses.BeneficiarioCollection
		Private _alwaysFetchBeneficiarioCollectionViaCheque_, _alreadyFetchedBeneficiarioCollectionViaCheque_ As Boolean
		Private _polizaCollectionViaCheque As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaCheque, _alreadyFetchedPolizaCollectionViaCheque As Boolean
		Private _polizaCollectionViaCheque__ As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaCheque__, _alreadyFetchedPolizaCollectionViaCheque__ As Boolean
		Private _polizaCollectionViaCheque_ As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaCheque_, _alreadyFetchedPolizaCollectionViaCheque_ As Boolean
		Private _polizaCollectionViaCheque___ As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaCheque___, _alreadyFetchedPolizaCollectionViaCheque___ As Boolean
		Private _polizaCollectionViaUsrBanDepositos As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaUsrBanDepositos, _alreadyFetchedPolizaCollectionViaUsrBanDepositos As Boolean
		Private _polizaCollectionViaUsrBanDepositos_ As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaUsrBanDepositos_, _alreadyFetchedPolizaCollectionViaUsrBanDepositos_ As Boolean
		Private _proveedorCollectionViaUsrCxppagosProveedores As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaUsrCxppagosProveedores, _alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores As Boolean
		Private _polizaCollectionViaUsrCxppagosProveedores As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaUsrCxppagosProveedores, _alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores As Boolean
		Private _tipoMoneda As TipoMonedaEntity
		Private _alwaysFetchTipoMoneda, _alreadyFetchedTipoMoneda, _tipoMonedaReturnsNewIfNotFound As Boolean
		Private _bancos As BancosEntity
		Private _alwaysFetchBancos, _alreadyFetchedBancos, _bancosReturnsNewIfNotFound As Boolean
		Private _cuentaContable As CuentaContableEntity
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable, _cuentaContableReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for Cuenta which data should be fetched into this Cuenta Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Cuenta which data should be fetched into this Cuenta Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Cuenta which data should be fetched into this Cuenta Object</param>
		''' <param name="validator">The custom validator Object for this CuentaEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mveCta = CType(info.GetValue("_mveCta", GetType(Integralab.ORM.CollectionClasses.MveCtaCollection)), Integralab.ORM.CollectionClasses.MveCtaCollection)
			_alwaysFetchMveCta = info.GetBoolean("_alwaysFetchMveCta")
			_alreadyFetchedMveCta = info.GetBoolean("_alreadyFetchedMveCta")
			_cheque = CType(info.GetValue("_cheque", GetType(Integralab.ORM.CollectionClasses.ChequeCollection)), Integralab.ORM.CollectionClasses.ChequeCollection)
			_alwaysFetchCheque = info.GetBoolean("_alwaysFetchCheque")
			_alreadyFetchedCheque = info.GetBoolean("_alreadyFetchedCheque")
			_cheque_ = CType(info.GetValue("_cheque_", GetType(Integralab.ORM.CollectionClasses.ChequeCollection)), Integralab.ORM.CollectionClasses.ChequeCollection)
			_alwaysFetchCheque_ = info.GetBoolean("_alwaysFetchCheque_")
			_alreadyFetchedCheque_ = info.GetBoolean("_alreadyFetchedCheque_")
			_usrBanDepositos = CType(info.GetValue("_usrBanDepositos", GetType(Integralab.ORM.CollectionClasses.UsrBanDepositosCollection)), Integralab.ORM.CollectionClasses.UsrBanDepositosCollection)
			_alwaysFetchUsrBanDepositos = info.GetBoolean("_alwaysFetchUsrBanDepositos")
			_alreadyFetchedUsrBanDepositos = info.GetBoolean("_alreadyFetchedUsrBanDepositos")
			_usrCxppagosProveedores = CType(info.GetValue("_usrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection)), Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection)
			_alwaysFetchUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchUsrCxppagosProveedores")
			_alreadyFetchedUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedUsrCxppagosProveedores")
			_beneficiarioCollectionViaCheque = CType(info.GetValue("_beneficiarioCollectionViaCheque", GetType(Integralab.ORM.CollectionClasses.BeneficiarioCollection)), Integralab.ORM.CollectionClasses.BeneficiarioCollection)
			_alwaysFetchBeneficiarioCollectionViaCheque = info.GetBoolean("_alwaysFetchBeneficiarioCollectionViaCheque")
			_alreadyFetchedBeneficiarioCollectionViaCheque = info.GetBoolean("_alreadyFetchedBeneficiarioCollectionViaCheque")
			_beneficiarioCollectionViaCheque_ = CType(info.GetValue("_beneficiarioCollectionViaCheque_", GetType(Integralab.ORM.CollectionClasses.BeneficiarioCollection)), Integralab.ORM.CollectionClasses.BeneficiarioCollection)
			_alwaysFetchBeneficiarioCollectionViaCheque_ = info.GetBoolean("_alwaysFetchBeneficiarioCollectionViaCheque_")
			_alreadyFetchedBeneficiarioCollectionViaCheque_ = info.GetBoolean("_alreadyFetchedBeneficiarioCollectionViaCheque_")
			_polizaCollectionViaCheque = CType(info.GetValue("_polizaCollectionViaCheque", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaCheque = info.GetBoolean("_alwaysFetchPolizaCollectionViaCheque")
			_alreadyFetchedPolizaCollectionViaCheque = info.GetBoolean("_alreadyFetchedPolizaCollectionViaCheque")
			_polizaCollectionViaCheque__ = CType(info.GetValue("_polizaCollectionViaCheque__", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaCheque__ = info.GetBoolean("_alwaysFetchPolizaCollectionViaCheque__")
			_alreadyFetchedPolizaCollectionViaCheque__ = info.GetBoolean("_alreadyFetchedPolizaCollectionViaCheque__")
			_polizaCollectionViaCheque_ = CType(info.GetValue("_polizaCollectionViaCheque_", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaCheque_ = info.GetBoolean("_alwaysFetchPolizaCollectionViaCheque_")
			_alreadyFetchedPolizaCollectionViaCheque_ = info.GetBoolean("_alreadyFetchedPolizaCollectionViaCheque_")
			_polizaCollectionViaCheque___ = CType(info.GetValue("_polizaCollectionViaCheque___", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaCheque___ = info.GetBoolean("_alwaysFetchPolizaCollectionViaCheque___")
			_alreadyFetchedPolizaCollectionViaCheque___ = info.GetBoolean("_alreadyFetchedPolizaCollectionViaCheque___")
			_polizaCollectionViaUsrBanDepositos = CType(info.GetValue("_polizaCollectionViaUsrBanDepositos", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaUsrBanDepositos = info.GetBoolean("_alwaysFetchPolizaCollectionViaUsrBanDepositos")
			_alreadyFetchedPolizaCollectionViaUsrBanDepositos = info.GetBoolean("_alreadyFetchedPolizaCollectionViaUsrBanDepositos")
			_polizaCollectionViaUsrBanDepositos_ = CType(info.GetValue("_polizaCollectionViaUsrBanDepositos_", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaUsrBanDepositos_ = info.GetBoolean("_alwaysFetchPolizaCollectionViaUsrBanDepositos_")
			_alreadyFetchedPolizaCollectionViaUsrBanDepositos_ = info.GetBoolean("_alreadyFetchedPolizaCollectionViaUsrBanDepositos_")
			_proveedorCollectionViaUsrCxppagosProveedores = CType(info.GetValue("_proveedorCollectionViaUsrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores")
			_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores")
			_polizaCollectionViaUsrCxppagosProveedores = CType(info.GetValue("_polizaCollectionViaUsrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores")
			_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores")
			_tipoMoneda = CType(info.GetValue("_tipoMoneda", GetType(TipoMonedaEntity)), TipoMonedaEntity)
			If Not _tipoMoneda Is Nothing Then
				AddHandler _tipoMoneda.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoMonedaReturnsNewIfNotFound = info.GetBoolean("_tipoMonedaReturnsNewIfNotFound")
			_alwaysFetchTipoMoneda = info.GetBoolean("_alwaysFetchTipoMoneda")
			_alreadyFetchedTipoMoneda = info.GetBoolean("_alreadyFetchedTipoMoneda")
			_bancos = CType(info.GetValue("_bancos", GetType(BancosEntity)), BancosEntity)
			If Not _bancos Is Nothing Then
				AddHandler _bancos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_bancosReturnsNewIfNotFound = info.GetBoolean("_bancosReturnsNewIfNotFound")
			_alwaysFetchBancos = info.GetBoolean("_alwaysFetchBancos")
			_alreadyFetchedBancos = info.GetBoolean("_alreadyFetchedBancos")
			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable Is Nothing Then
				AddHandler _cuentaContable.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContableReturnsNewIfNotFound = info.GetBoolean("_cuentaContableReturnsNewIfNotFound")
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMveCta = (_mveCta.Count > 0)
			_alreadyFetchedCheque = (_cheque.Count > 0)
			_alreadyFetchedCheque_ = (_cheque_.Count > 0)
			_alreadyFetchedUsrBanDepositos = (_usrBanDepositos.Count > 0)
			_alreadyFetchedUsrCxppagosProveedores = (_usrCxppagosProveedores.Count > 0)
			_alreadyFetchedBeneficiarioCollectionViaCheque = (_beneficiarioCollectionViaCheque.Count > 0)
			_alreadyFetchedBeneficiarioCollectionViaCheque_ = (_beneficiarioCollectionViaCheque_.Count > 0)
			_alreadyFetchedPolizaCollectionViaCheque = (_polizaCollectionViaCheque.Count > 0)
			_alreadyFetchedPolizaCollectionViaCheque__ = (_polizaCollectionViaCheque__.Count > 0)
			_alreadyFetchedPolizaCollectionViaCheque_ = (_polizaCollectionViaCheque_.Count > 0)
			_alreadyFetchedPolizaCollectionViaCheque___ = (_polizaCollectionViaCheque___.Count > 0)
			_alreadyFetchedPolizaCollectionViaUsrBanDepositos = (_polizaCollectionViaUsrBanDepositos.Count > 0)
			_alreadyFetchedPolizaCollectionViaUsrBanDepositos_ = (_polizaCollectionViaUsrBanDepositos_.Count > 0)
			_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = (_proveedorCollectionViaUsrCxppagosProveedores.Count > 0)
			_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = (_polizaCollectionViaUsrCxppagosProveedores.Count > 0)
			_alreadyFetchedTipoMoneda = Not(_tipoMoneda Is Nothing)
			_alreadyFetchedBancos = Not(_bancos Is Nothing)
			_alreadyFetchedCuentaContable = Not(_cuentaContable Is Nothing)

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
			info.AddValue("_mveCta", _mveCta)
			info.AddValue("_alwaysFetchMveCta", _alwaysFetchMveCta)
			info.AddValue("_alreadyFetchedMveCta", _alreadyFetchedMveCta)
			info.AddValue("_cheque", _cheque)
			info.AddValue("_alwaysFetchCheque", _alwaysFetchCheque)
			info.AddValue("_alreadyFetchedCheque", _alreadyFetchedCheque)
			info.AddValue("_cheque_", _cheque_)
			info.AddValue("_alwaysFetchCheque_", _alwaysFetchCheque_)
			info.AddValue("_alreadyFetchedCheque_", _alreadyFetchedCheque_)
			info.AddValue("_usrBanDepositos", _usrBanDepositos)
			info.AddValue("_alwaysFetchUsrBanDepositos", _alwaysFetchUsrBanDepositos)
			info.AddValue("_alreadyFetchedUsrBanDepositos", _alreadyFetchedUsrBanDepositos)
			info.AddValue("_usrCxppagosProveedores", _usrCxppagosProveedores)
			info.AddValue("_alwaysFetchUsrCxppagosProveedores", _alwaysFetchUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedUsrCxppagosProveedores", _alreadyFetchedUsrCxppagosProveedores)
			info.AddValue("_beneficiarioCollectionViaCheque", _beneficiarioCollectionViaCheque)
			info.AddValue("_alwaysFetchBeneficiarioCollectionViaCheque", _alwaysFetchBeneficiarioCollectionViaCheque)
			info.AddValue("_alreadyFetchedBeneficiarioCollectionViaCheque", _alreadyFetchedBeneficiarioCollectionViaCheque)
			info.AddValue("_beneficiarioCollectionViaCheque_", _beneficiarioCollectionViaCheque_)
			info.AddValue("_alwaysFetchBeneficiarioCollectionViaCheque_", _alwaysFetchBeneficiarioCollectionViaCheque_)
			info.AddValue("_alreadyFetchedBeneficiarioCollectionViaCheque_", _alreadyFetchedBeneficiarioCollectionViaCheque_)
			info.AddValue("_polizaCollectionViaCheque", _polizaCollectionViaCheque)
			info.AddValue("_alwaysFetchPolizaCollectionViaCheque", _alwaysFetchPolizaCollectionViaCheque)
			info.AddValue("_alreadyFetchedPolizaCollectionViaCheque", _alreadyFetchedPolizaCollectionViaCheque)
			info.AddValue("_polizaCollectionViaCheque__", _polizaCollectionViaCheque__)
			info.AddValue("_alwaysFetchPolizaCollectionViaCheque__", _alwaysFetchPolizaCollectionViaCheque__)
			info.AddValue("_alreadyFetchedPolizaCollectionViaCheque__", _alreadyFetchedPolizaCollectionViaCheque__)
			info.AddValue("_polizaCollectionViaCheque_", _polizaCollectionViaCheque_)
			info.AddValue("_alwaysFetchPolizaCollectionViaCheque_", _alwaysFetchPolizaCollectionViaCheque_)
			info.AddValue("_alreadyFetchedPolizaCollectionViaCheque_", _alreadyFetchedPolizaCollectionViaCheque_)
			info.AddValue("_polizaCollectionViaCheque___", _polizaCollectionViaCheque___)
			info.AddValue("_alwaysFetchPolizaCollectionViaCheque___", _alwaysFetchPolizaCollectionViaCheque___)
			info.AddValue("_alreadyFetchedPolizaCollectionViaCheque___", _alreadyFetchedPolizaCollectionViaCheque___)
			info.AddValue("_polizaCollectionViaUsrBanDepositos", _polizaCollectionViaUsrBanDepositos)
			info.AddValue("_alwaysFetchPolizaCollectionViaUsrBanDepositos", _alwaysFetchPolizaCollectionViaUsrBanDepositos)
			info.AddValue("_alreadyFetchedPolizaCollectionViaUsrBanDepositos", _alreadyFetchedPolizaCollectionViaUsrBanDepositos)
			info.AddValue("_polizaCollectionViaUsrBanDepositos_", _polizaCollectionViaUsrBanDepositos_)
			info.AddValue("_alwaysFetchPolizaCollectionViaUsrBanDepositos_", _alwaysFetchPolizaCollectionViaUsrBanDepositos_)
			info.AddValue("_alreadyFetchedPolizaCollectionViaUsrBanDepositos_", _alreadyFetchedPolizaCollectionViaUsrBanDepositos_)
			info.AddValue("_proveedorCollectionViaUsrCxppagosProveedores", _proveedorCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores", _alwaysFetchProveedorCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores", _alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores)
			info.AddValue("_polizaCollectionViaUsrCxppagosProveedores", _polizaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores", _alwaysFetchPolizaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores", _alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_tipoMoneda", _tipoMoneda)
			info.AddValue("_tipoMonedaReturnsNewIfNotFound", _tipoMonedaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoMoneda", _alwaysFetchTipoMoneda)
			info.AddValue("_alreadyFetchedTipoMoneda", _alreadyFetchedTipoMoneda)
			info.AddValue("_bancos", _bancos)
			info.AddValue("_bancosReturnsNewIfNotFound", _bancosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchBancos", _alwaysFetchBancos)
			info.AddValue("_alreadyFetchedBancos", _alreadyFetchedBancos)
			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_cuentaContableReturnsNewIfNotFound", _cuentaContableReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)

			
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
				Case "TipoMoneda"
					_alreadyFetchedTipoMoneda = True
					Me.TipoMoneda = CType(entity, TipoMonedaEntity)
				Case "Bancos"
					_alreadyFetchedBancos = True
					Me.Bancos = CType(entity, BancosEntity)
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					Me.CuentaContable = CType(entity, CuentaContableEntity)
				Case "MveCta"
					_alreadyFetchedMveCta = True
					If Not entity Is Nothing Then
						Me.MveCta.Add(CType(entity, MveCtaEntity))
					End If
				Case "Cheque"
					_alreadyFetchedCheque = True
					If Not entity Is Nothing Then
						Me.Cheque.Add(CType(entity, ChequeEntity))
					End If
				Case "Cheque_"
					_alreadyFetchedCheque_ = True
					If Not entity Is Nothing Then
						Me.Cheque_.Add(CType(entity, ChequeEntity))
					End If
				Case "UsrBanDepositos"
					_alreadyFetchedUsrBanDepositos = True
					If Not entity Is Nothing Then
						Me.UsrBanDepositos.Add(CType(entity, UsrBanDepositosEntity))
					End If
				Case "UsrCxppagosProveedores"
					_alreadyFetchedUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.UsrCxppagosProveedores.Add(CType(entity, UsrCxppagosProveedoresEntity))
					End If
				Case "BeneficiarioCollectionViaCheque"
					_alreadyFetchedBeneficiarioCollectionViaCheque = True
					If Not entity Is Nothing Then
						Me.BeneficiarioCollectionViaCheque.Add(CType(entity, BeneficiarioEntity))
					End If
				Case "BeneficiarioCollectionViaCheque_"
					_alreadyFetchedBeneficiarioCollectionViaCheque_ = True
					If Not entity Is Nothing Then
						Me.BeneficiarioCollectionViaCheque_.Add(CType(entity, BeneficiarioEntity))
					End If
				Case "PolizaCollectionViaCheque"
					_alreadyFetchedPolizaCollectionViaCheque = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaCheque.Add(CType(entity, PolizaEntity))
					End If
				Case "PolizaCollectionViaCheque__"
					_alreadyFetchedPolizaCollectionViaCheque__ = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaCheque__.Add(CType(entity, PolizaEntity))
					End If
				Case "PolizaCollectionViaCheque_"
					_alreadyFetchedPolizaCollectionViaCheque_ = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaCheque_.Add(CType(entity, PolizaEntity))
					End If
				Case "PolizaCollectionViaCheque___"
					_alreadyFetchedPolizaCollectionViaCheque___ = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaCheque___.Add(CType(entity, PolizaEntity))
					End If
				Case "PolizaCollectionViaUsrBanDepositos"
					_alreadyFetchedPolizaCollectionViaUsrBanDepositos = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaUsrBanDepositos.Add(CType(entity, PolizaEntity))
					End If
				Case "PolizaCollectionViaUsrBanDepositos_"
					_alreadyFetchedPolizaCollectionViaUsrBanDepositos_ = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaUsrBanDepositos_.Add(CType(entity, PolizaEntity))
					End If
				Case "ProveedorCollectionViaUsrCxppagosProveedores"
					_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaUsrCxppagosProveedores.Add(CType(entity, ProveedorEntity))
					End If
				Case "PolizaCollectionViaUsrCxppagosProveedores"
					_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaUsrCxppagosProveedores.Add(CType(entity, PolizaEntity))
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
				Case "TipoMoneda"
					SetupSyncTipoMoneda(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Bancos"
					SetupSyncBancos(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable"
					SetupSyncCuentaContable(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MveCta"
					_mveCta.Add(CType(relatedEntity, MveCtaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cheque"
					_cheque.Add(CType(relatedEntity, ChequeEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cheque_"
					_cheque_.Add(CType(relatedEntity, ChequeEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrBanDepositos"
					_usrBanDepositos.Add(CType(relatedEntity, UsrBanDepositosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrCxppagosProveedores"
					_usrCxppagosProveedores.Add(CType(relatedEntity, UsrCxppagosProveedoresEntity))
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
				Case "TipoMoneda"
					DesetupSyncTipoMoneda(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Bancos"
					DesetupSyncBancos(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable"
					DesetupSyncCuentaContable(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MveCta"
					MyBase.PerformRelatedEntityRemoval(_mveCta, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cheque"
					MyBase.PerformRelatedEntityRemoval(_cheque, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cheque_"
					MyBase.PerformRelatedEntityRemoval(_cheque_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrBanDepositos"
					MyBase.PerformRelatedEntityRemoval(_usrBanDepositos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCxppagosProveedores"
					MyBase.PerformRelatedEntityRemoval(_usrCxppagosProveedores, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _tipoMoneda Is Nothing Then
				toReturn.Add(_tipoMoneda)
			End If
			If Not _bancos Is Nothing Then
				toReturn.Add(_bancos)
			End If
			If Not _cuentaContable Is Nothing Then
				toReturn.Add(_cuentaContable)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_mveCta)
			toReturn.Add(_cheque)
			toReturn.Add(_cheque_)
			toReturn.Add(_usrBanDepositos)
			toReturn.Add(_usrCxppagosProveedores)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Cuenta which data should be fetched into this Cuenta Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Cuenta which data should be fetched into this Cuenta Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Cuenta which data should be fetched into this Cuenta Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CuentaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CuentaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MveCtaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MveCtaEntity'</returns>
		Public Function GetMultiMveCta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MveCtaCollection
			Return GetMultiMveCta(forceFetch, _mveCta.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MveCtaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMveCta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MveCtaCollection
			Return GetMultiMveCta(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MveCtaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MveCtaEntity'</returns>
		Public Function GetMultiMveCta(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MveCtaCollection
			Return GetMultiMveCta(forceFetch, _mveCta.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MveCtaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMveCta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MveCtaCollection
			If ( Not _alreadyFetchedMveCta Or forceFetch Or _alwaysFetchMveCta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mveCta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mveCta)
					End If
				End If
				_mveCta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mveCta.EntityFactoryToUse = entityFactoryToUse
				End If
				_mveCta.GetMultiManyToOne(Me, Filter)
				_mveCta.SuppressClearInGetMulti = False
				_alreadyFetchedMveCta = True
			End If
			Return _mveCta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MveCta'. These settings will be taken into account
		''' when the property MveCta is requested or GetMultiMveCta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMveCta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mveCta.SortClauses=sortClauses
			_mveCta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque(forceFetch, _cheque.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque(forceFetch, _cheque.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			If ( Not _alreadyFetchedCheque Or forceFetch Or _alwaysFetchCheque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cheque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cheque)
					End If
				End If
				_cheque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cheque.EntityFactoryToUse = entityFactoryToUse
				End If
				_cheque.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Filter)
				_cheque.SuppressClearInGetMulti = False
				_alreadyFetchedCheque = True
			End If
			Return _cheque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cheque'. These settings will be taken into account
		''' when the property Cheque is requested or GetMultiCheque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCheque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cheque.SortClauses=sortClauses
			_cheque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque_(forceFetch, _cheque_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque_(forceFetch, _cheque_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			If ( Not _alreadyFetchedCheque_ Or forceFetch Or _alwaysFetchCheque_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cheque_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cheque_)
					End If
				End If
				_cheque_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cheque_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cheque_.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Filter)
				_cheque_.SuppressClearInGetMulti = False
				_alreadyFetchedCheque_ = True
			End If
			Return _cheque_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cheque_'. These settings will be taken into account
		''' when the property Cheque_ is requested or GetMultiCheque_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCheque_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cheque_.SortClauses=sortClauses
			_cheque_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrBanDepositosEntity'</returns>
		Public Function GetMultiUsrBanDepositos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Return GetMultiUsrBanDepositos(forceFetch, _usrBanDepositos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrBanDepositos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Return GetMultiUsrBanDepositos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrBanDepositosEntity'</returns>
		Public Function GetMultiUsrBanDepositos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Return GetMultiUsrBanDepositos(forceFetch, _usrBanDepositos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrBanDepositos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			If ( Not _alreadyFetchedUsrBanDepositos Or forceFetch Or _alwaysFetchUsrBanDepositos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrBanDepositos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrBanDepositos)
					End If
				End If
				_usrBanDepositos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrBanDepositos.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrBanDepositos.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_usrBanDepositos.SuppressClearInGetMulti = False
				_alreadyFetchedUsrBanDepositos = True
			End If
			Return _usrBanDepositos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrBanDepositos'. These settings will be taken into account
		''' when the property UsrBanDepositos is requested or GetMultiUsrBanDepositos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrBanDepositos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrBanDepositos.SortClauses=sortClauses
			_usrBanDepositos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
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
				_usrCxppagosProveedores.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
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
	
	
		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'BeneficiarioEntity'</returns>
		Public Function GetMultiBeneficiarioCollectionViaCheque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Return GetMultiBeneficiarioCollectionViaCheque(forceFetch, _beneficiarioCollectionViaCheque.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiBeneficiarioCollectionViaCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			If ( Not _alreadyFetchedBeneficiarioCollectionViaCheque Or forceFetch Or _alwaysFetchBeneficiarioCollectionViaCheque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _beneficiarioCollectionViaCheque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_beneficiarioCollectionViaCheque)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaId, "__CuentaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_beneficiarioCollectionViaCheque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_beneficiarioCollectionViaCheque.EntityFactoryToUse = entityFactoryToUse
				End If
				_beneficiarioCollectionViaCheque.GetMulti(Filter, relations)
				_beneficiarioCollectionViaCheque.SuppressClearInGetMulti = False
				_alreadyFetchedBeneficiarioCollectionViaCheque = True
			End If
			Return _beneficiarioCollectionViaCheque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'BeneficiarioCollectionViaCheque'. These settings will be taken into account
		''' when the property BeneficiarioCollectionViaCheque is requested or GetMultiBeneficiarioCollectionViaCheque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersBeneficiarioCollectionViaCheque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_beneficiarioCollectionViaCheque.SortClauses=sortClauses
			_beneficiarioCollectionViaCheque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'BeneficiarioEntity'</returns>
		Public Function GetMultiBeneficiarioCollectionViaCheque_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Return GetMultiBeneficiarioCollectionViaCheque_(forceFetch, _beneficiarioCollectionViaCheque_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiBeneficiarioCollectionViaCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			If ( Not _alreadyFetchedBeneficiarioCollectionViaCheque_ Or forceFetch Or _alwaysFetchBeneficiarioCollectionViaCheque_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _beneficiarioCollectionViaCheque_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_beneficiarioCollectionViaCheque_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, "__CuentaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_beneficiarioCollectionViaCheque_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_beneficiarioCollectionViaCheque_.EntityFactoryToUse = entityFactoryToUse
				End If
				_beneficiarioCollectionViaCheque_.GetMulti(Filter, relations)
				_beneficiarioCollectionViaCheque_.SuppressClearInGetMulti = False
				_alreadyFetchedBeneficiarioCollectionViaCheque_ = True
			End If
			Return _beneficiarioCollectionViaCheque_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'BeneficiarioCollectionViaCheque_'. These settings will be taken into account
		''' when the property BeneficiarioCollectionViaCheque_ is requested or GetMultiBeneficiarioCollectionViaCheque_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersBeneficiarioCollectionViaCheque_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_beneficiarioCollectionViaCheque_.SortClauses=sortClauses
			_beneficiarioCollectionViaCheque_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaCheque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaCheque(forceFetch, _polizaCollectionViaCheque.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaCheque Or forceFetch Or _alwaysFetchPolizaCollectionViaCheque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaCheque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaCheque)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaId, "__CuentaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaCheque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaCheque.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaCheque.GetMulti(Filter, relations)
				_polizaCollectionViaCheque.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaCheque = True
			End If
			Return _polizaCollectionViaCheque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaCheque'. These settings will be taken into account
		''' when the property PolizaCollectionViaCheque is requested or GetMultiPolizaCollectionViaCheque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaCheque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaCheque.SortClauses=sortClauses
			_polizaCollectionViaCheque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaCheque__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaCheque__(forceFetch, _polizaCollectionViaCheque__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaCheque__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaCheque__ Or forceFetch Or _alwaysFetchPolizaCollectionViaCheque__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaCheque__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaCheque__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaId, "__CuentaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaCheque__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaCheque__.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaCheque__.GetMulti(Filter, relations)
				_polizaCollectionViaCheque__.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaCheque__ = True
			End If
			Return _polizaCollectionViaCheque__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaCheque__'. These settings will be taken into account
		''' when the property PolizaCollectionViaCheque__ is requested or GetMultiPolizaCollectionViaCheque__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaCheque__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaCheque__.SortClauses=sortClauses
			_polizaCollectionViaCheque__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaCheque_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaCheque_(forceFetch, _polizaCollectionViaCheque_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaCheque_ Or forceFetch Or _alwaysFetchPolizaCollectionViaCheque_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaCheque_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaCheque_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, "__CuentaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaCheque_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaCheque_.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaCheque_.GetMulti(Filter, relations)
				_polizaCollectionViaCheque_.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaCheque_ = True
			End If
			Return _polizaCollectionViaCheque_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaCheque_'. These settings will be taken into account
		''' when the property PolizaCollectionViaCheque_ is requested or GetMultiPolizaCollectionViaCheque_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaCheque_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaCheque_.SortClauses=sortClauses
			_polizaCollectionViaCheque_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaCheque___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaCheque___(forceFetch, _polizaCollectionViaCheque___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaCheque___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaCheque___ Or forceFetch Or _alwaysFetchPolizaCollectionViaCheque___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaCheque___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaCheque___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, "__CuentaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaCheque___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaCheque___.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaCheque___.GetMulti(Filter, relations)
				_polizaCollectionViaCheque___.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaCheque___ = True
			End If
			Return _polizaCollectionViaCheque___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaCheque___'. These settings will be taken into account
		''' when the property PolizaCollectionViaCheque___ is requested or GetMultiPolizaCollectionViaCheque___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaCheque___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaCheque___.SortClauses=sortClauses
			_polizaCollectionViaCheque___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaUsrBanDepositos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaUsrBanDepositos(forceFetch, _polizaCollectionViaUsrBanDepositos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaUsrBanDepositos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaUsrBanDepositos Or forceFetch Or _alwaysFetchPolizaCollectionViaUsrBanDepositos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaUsrBanDepositos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaUsrBanDepositos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.UsrBanDepositosEntityUsingCuentaId, "__CuentaEntity__", "UsrBanDepositos_", JoinHint.None)
				relations.Add(UsrBanDepositosEntity.Relations.PolizaEntityUsingPolizaIdCancelacion, "UsrBanDepositos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaUsrBanDepositos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaUsrBanDepositos.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaUsrBanDepositos.GetMulti(Filter, relations)
				_polizaCollectionViaUsrBanDepositos.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaUsrBanDepositos = True
			End If
			Return _polizaCollectionViaUsrBanDepositos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaUsrBanDepositos'. These settings will be taken into account
		''' when the property PolizaCollectionViaUsrBanDepositos is requested or GetMultiPolizaCollectionViaUsrBanDepositos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaUsrBanDepositos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaUsrBanDepositos.SortClauses=sortClauses
			_polizaCollectionViaUsrBanDepositos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaUsrBanDepositos_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaUsrBanDepositos_(forceFetch, _polizaCollectionViaUsrBanDepositos_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaUsrBanDepositos_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaUsrBanDepositos_ Or forceFetch Or _alwaysFetchPolizaCollectionViaUsrBanDepositos_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaUsrBanDepositos_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaUsrBanDepositos_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.UsrBanDepositosEntityUsingCuentaId, "__CuentaEntity__", "UsrBanDepositos_", JoinHint.None)
				relations.Add(UsrBanDepositosEntity.Relations.PolizaEntityUsingPolizaId, "UsrBanDepositos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaUsrBanDepositos_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaUsrBanDepositos_.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaUsrBanDepositos_.GetMulti(Filter, relations)
				_polizaCollectionViaUsrBanDepositos_.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaUsrBanDepositos_ = True
			End If
			Return _polizaCollectionViaUsrBanDepositos_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaUsrBanDepositos_'. These settings will be taken into account
		''' when the property PolizaCollectionViaUsrBanDepositos_ is requested or GetMultiPolizaCollectionViaUsrBanDepositos_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaUsrBanDepositos_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaUsrBanDepositos_.SortClauses=sortClauses
			_polizaCollectionViaUsrBanDepositos_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaUsrCxppagosProveedores(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaUsrCxppagosProveedores(forceFetch, _proveedorCollectionViaUsrCxppagosProveedores.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaUsrCxppagosProveedores(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores Or forceFetch Or _alwaysFetchProveedorCollectionViaUsrCxppagosProveedores) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaUsrCxppagosProveedores.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaUsrCxppagosProveedores)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.UsrCxppagosProveedoresEntityUsingCuentaBancariaId, "__CuentaEntity__", "UsrCxppagosProveedores_", JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.ProveedorEntityUsingIdProveedor, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_proveedorCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaUsrCxppagosProveedores.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaUsrCxppagosProveedores.GetMulti(Filter, relations)
				_proveedorCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = True
			End If
			Return _proveedorCollectionViaUsrCxppagosProveedores
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaUsrCxppagosProveedores'. These settings will be taken into account
		''' when the property ProveedorCollectionViaUsrCxppagosProveedores is requested or GetMultiProveedorCollectionViaUsrCxppagosProveedores is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaUsrCxppagosProveedores(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaUsrCxppagosProveedores.SortClauses=sortClauses
			_proveedorCollectionViaUsrCxppagosProveedores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaUsrCxppagosProveedores(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaUsrCxppagosProveedores(forceFetch, _polizaCollectionViaUsrCxppagosProveedores.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaUsrCxppagosProveedores(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores Or forceFetch Or _alwaysFetchPolizaCollectionViaUsrCxppagosProveedores) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaUsrCxppagosProveedores.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaUsrCxppagosProveedores)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaEntity.Relations.UsrCxppagosProveedoresEntityUsingCuentaBancariaId, "__CuentaEntity__", "UsrCxppagosProveedores_", JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.PolizaEntityUsingPolizaId, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaUsrCxppagosProveedores.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaUsrCxppagosProveedores.GetMulti(Filter, relations)
				_polizaCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = True
			End If
			Return _polizaCollectionViaUsrCxppagosProveedores
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaUsrCxppagosProveedores'. These settings will be taken into account
		''' when the property PolizaCollectionViaUsrCxppagosProveedores is requested or GetMultiPolizaCollectionViaUsrCxppagosProveedores is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaUsrCxppagosProveedores(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaUsrCxppagosProveedores.SortClauses=sortClauses
			_polizaCollectionViaUsrCxppagosProveedores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'TipoMonedaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoMonedaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoMoneda() As TipoMonedaEntity
			Return GetSingleTipoMoneda(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoMonedaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoMonedaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoMoneda(forceFetch As Boolean) As TipoMonedaEntity
			If ( Not _alreadyFetchedTipoMoneda Or forceFetch Or _alwaysFetchTipoMoneda) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoMonedaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId) Then
					fetchResult = newEntity.FetchUsingPK(Me.TipomonedaId)
				End If
				If Not _tipoMonedaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoMoneda = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoMonedaEntity)
					End If
					Me.TipoMoneda = newEntity
					_alreadyFetchedTipoMoneda = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoMoneda
		End Function
	
		''' <summary>Retrieves the related entity of type 'BancosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'BancosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleBancos() As BancosEntity
			Return GetSingleBancos(False)
		End Function

		''' <summary>Retrieves the related entity of type 'BancosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'BancosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleBancos(forceFetch As Boolean) As BancosEntity
			If ( Not _alreadyFetchedBancos Or forceFetch Or _alwaysFetchBancos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New BancosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CuentaEntity.Relations.BancosEntityUsingBancoId) Then
					fetchResult = newEntity.FetchUsingPK(Me.BancoId)
				End If
				If Not _bancosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Bancos = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), BancosEntity)
					End If
					Me.Bancos = newEntity
					_alreadyFetchedBancos = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _bancos
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
				If MyBase.CheckIfLazyLoadingShouldOccur(CuentaEntity.Relations.CuentaContableEntityUsingCuentacontableId) Then
					fetchResult = newEntity.FetchUsingPK(Me.CuentacontableId)
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
	
	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(CuentaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CuentaFieldIndex)

					Case CuentaFieldIndex.CuentacontableId
						DesetupSyncCuentaContable(True, False)
						_alreadyFetchedCuentaContable = False

					Case CuentaFieldIndex.BancoId
						DesetupSyncBancos(True, False)
						_alreadyFetchedBancos = False
					Case CuentaFieldIndex.TipomonedaId
						DesetupSyncTipoMoneda(True, False)
						_alreadyFetchedTipoMoneda = False









					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_mveCta.ActiveContext = MyBase.ActiveContext
			_cheque.ActiveContext = MyBase.ActiveContext
			_cheque_.ActiveContext = MyBase.ActiveContext
			_usrBanDepositos.ActiveContext = MyBase.ActiveContext
			_usrCxppagosProveedores.ActiveContext = MyBase.ActiveContext
			_beneficiarioCollectionViaCheque.ActiveContext = MyBase.ActiveContext
			_beneficiarioCollectionViaCheque_.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaCheque.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaCheque__.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaCheque_.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaCheque___.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaUsrBanDepositos.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaUsrBanDepositos_.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaUsrCxppagosProveedores.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaUsrCxppagosProveedores.ActiveContext = MyBase.ActiveContext
		If Not _tipoMoneda Is Nothing Then
				_tipoMoneda.ActiveContext = MyBase.ActiveContext
			End If
		If Not _bancos Is Nothing Then
				_bancos.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaContable Is Nothing Then
				_cuentaContable.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CuentaDAO = CType(CreateDAOInstance(), CuentaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CuentaDAO = CType(CreateDAOInstance(), CuentaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CuentaDAO = CType(CreateDAOInstance(), CuentaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CuentaEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Cuenta which data should be fetched into this Cuenta Object</param>
		''' <param name="validator">The validator Object for this CuentaEntity</param>
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
			_mveCta = New Integralab.ORM.CollectionClasses.MveCtaCollection(New MveCtaEntityFactory())
			_mveCta.SetContainingEntityInfo(Me, "Cuenta")
			_alwaysFetchMveCta = False
			_alreadyFetchedMveCta = False
			_cheque = New Integralab.ORM.CollectionClasses.ChequeCollection(New ChequeEntityFactory())
			_cheque.SetContainingEntityInfo(Me, "Cuenta")
			_alwaysFetchCheque = False
			_alreadyFetchedCheque = False
			_cheque_ = New Integralab.ORM.CollectionClasses.ChequeCollection(New ChequeEntityFactory())
			_cheque_.SetContainingEntityInfo(Me, "CuentaDestino")
			_alwaysFetchCheque_ = False
			_alreadyFetchedCheque_ = False
			_usrBanDepositos = New Integralab.ORM.CollectionClasses.UsrBanDepositosCollection(New UsrBanDepositosEntityFactory())
			_usrBanDepositos.SetContainingEntityInfo(Me, "Cuenta_")
			_alwaysFetchUsrBanDepositos = False
			_alreadyFetchedUsrBanDepositos = False
			_usrCxppagosProveedores = New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection(New UsrCxppagosProveedoresEntityFactory())
			_usrCxppagosProveedores.SetContainingEntityInfo(Me, "Cuenta")
			_alwaysFetchUsrCxppagosProveedores = False
			_alreadyFetchedUsrCxppagosProveedores = False
			_beneficiarioCollectionViaCheque = New Integralab.ORM.CollectionClasses.BeneficiarioCollection(New BeneficiarioEntityFactory())
			_alwaysFetchBeneficiarioCollectionViaCheque = False
			_alreadyFetchedBeneficiarioCollectionViaCheque = False
			_beneficiarioCollectionViaCheque_ = New Integralab.ORM.CollectionClasses.BeneficiarioCollection(New BeneficiarioEntityFactory())
			_alwaysFetchBeneficiarioCollectionViaCheque_ = False
			_alreadyFetchedBeneficiarioCollectionViaCheque_ = False
			_polizaCollectionViaCheque = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaCheque = False
			_alreadyFetchedPolizaCollectionViaCheque = False
			_polizaCollectionViaCheque__ = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaCheque__ = False
			_alreadyFetchedPolizaCollectionViaCheque__ = False
			_polizaCollectionViaCheque_ = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaCheque_ = False
			_alreadyFetchedPolizaCollectionViaCheque_ = False
			_polizaCollectionViaCheque___ = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaCheque___ = False
			_alreadyFetchedPolizaCollectionViaCheque___ = False
			_polizaCollectionViaUsrBanDepositos = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaUsrBanDepositos = False
			_alreadyFetchedPolizaCollectionViaUsrBanDepositos = False
			_polizaCollectionViaUsrBanDepositos_ = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaUsrBanDepositos_ = False
			_alreadyFetchedPolizaCollectionViaUsrBanDepositos_ = False
			_proveedorCollectionViaUsrCxppagosProveedores = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores = False
			_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = False
			_polizaCollectionViaUsrCxppagosProveedores = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores = False
			_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = False
			_tipoMoneda = Nothing
			_tipoMonedaReturnsNewIfNotFound = True
			_alwaysFetchTipoMoneda = False
			_alreadyFetchedTipoMoneda = False
			_bancos = Nothing
			_bancosReturnsNewIfNotFound = True
			_alwaysFetchBancos = False
			_alreadyFetchedBancos = False
			_cuentaContable = Nothing
			_cuentaContableReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False

			
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

			_fieldsCustomProperties.Add("CuentacontableId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EmpresaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BancoId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipomonedaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Folioactual", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cuenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cuentahabiente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Saldoinicial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Saldodiaant", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Saldoreal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Saldoactual", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _tipoMoneda</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoMoneda(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId, True, signalRelatedEntity, "Cuenta", resetFKFields, New Integer() { CInt(CuentaFieldIndex.TipomonedaId) } )
			_tipoMoneda = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoMoneda</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoMoneda(relatedEntity As IEntity)
			DesetupSyncTipoMoneda(True, True)
			_tipoMoneda = CType(relatedEntity, TipoMonedaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId, True, _alreadyFetchedTipoMoneda, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoMonedaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _bancos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncBancos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _bancos, AddressOf OnBancosPropertyChanged, "Bancos", CuentaEntity.Relations.BancosEntityUsingBancoId, True, signalRelatedEntity, "Cuenta", resetFKFields, New Integer() { CInt(CuentaFieldIndex.BancoId) } )
			_bancos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _bancos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncBancos(relatedEntity As IEntity)
			DesetupSyncBancos(True, True)
			_bancos = CType(relatedEntity, BancosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _bancos, AddressOf OnBancosPropertyChanged, "Bancos", CuentaEntity.Relations.BancosEntityUsingBancoId, True, _alreadyFetchedBancos, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnBancosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cuentaContable</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", CuentaEntity.Relations.CuentaContableEntityUsingCuentacontableId, True, signalRelatedEntity, "Cuenta", resetFKFields, New Integer() { CInt(CuentaFieldIndex.CuentacontableId) } )
			_cuentaContable = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable(relatedEntity As IEntity)
			DesetupSyncCuentaContable(True, True)
			_cuentaContable = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", CuentaEntity.Relations.CuentaContableEntityUsingCuentacontableId, True, _alreadyFetchedCuentaContable, New String() {  } )
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



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Cuenta which data should be fetched into this Cuenta Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CuentaFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCuentaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CuentaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CuentaRelations
			Get	
				Return New CuentaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MveCta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMveCta() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MveCtaCollection(), _
					CuentaEntity.Relations.MveCtaEntityUsingIdCuenta, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.MveCtaEntity, Integer), 0, Nothing, Nothing, Nothing, "MveCta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cheque' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCheque() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequeCollection(), _
					CuentaEntity.Relations.ChequeEntityUsingCuentaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.ChequeEntity, Integer), 0, Nothing, Nothing, Nothing, "Cheque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cheque' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCheque_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequeCollection(), _
					CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.ChequeEntity, Integer), 0, Nothing, Nothing, Nothing, "Cheque_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrBanDepositos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrBanDepositos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrBanDepositosCollection(), _
					CuentaEntity.Relations.UsrBanDepositosEntityUsingCuentaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.UsrBanDepositosEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrBanDepositos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxppagosProveedores' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection(), _
					CuentaEntity.Relations.UsrCxppagosProveedoresEntityUsingCuentaBancariaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxppagosProveedoresEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Beneficiario' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBeneficiarioCollectionViaCheque() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BeneficiarioCollection(), _
					CuentaEntity.Relations.ChequeEntityUsingCuentaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), 0, Nothing, Nothing, relations, "BeneficiarioCollectionViaCheque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Beneficiario' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBeneficiarioCollectionViaCheque_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BeneficiarioCollection(), _
					CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), 0, Nothing, Nothing, relations, "BeneficiarioCollectionViaCheque_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaCheque() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CuentaEntity.Relations.ChequeEntityUsingCuentaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaCheque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaCheque__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CuentaEntity.Relations.ChequeEntityUsingCuentaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaCheque__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaCheque_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaCheque_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaCheque___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CuentaEntity.Relations.ChequeEntityUsingCuentaDestinoId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaCheque___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaUsrBanDepositos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.UsrBanDepositosEntityUsingCuentaId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrBanDepositosEntity.Relations.PolizaEntityUsingPolizaIdCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CuentaEntity.Relations.UsrBanDepositosEntityUsingCuentaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaUsrBanDepositos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaUsrBanDepositos_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.UsrBanDepositosEntityUsingCuentaId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrBanDepositosEntity.Relations.PolizaEntityUsingPolizaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CuentaEntity.Relations.UsrBanDepositosEntityUsingCuentaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaUsrBanDepositos_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.UsrCxppagosProveedoresEntityUsingCuentaBancariaId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.ProveedorEntityUsingIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					CuentaEntity.Relations.UsrCxppagosProveedoresEntityUsingCuentaBancariaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaUsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaEntity.Relations.UsrCxppagosProveedoresEntityUsingCuentaBancariaId, "__CuentaEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.PolizaEntityUsingPolizaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CuentaEntity.Relations.UsrCxppagosProveedoresEntityUsingCuentaBancariaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaUsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMoneda() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoMoneda", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bancos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBancos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BancosCollection(), _
					CuentaEntity.Relations.BancosEntityUsingBancoId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.BancosEntity, Integer), 0, Nothing, Nothing, Nothing, "Bancos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CuentaEntity.Relations.CuentaContableEntityUsingCuentacontableId, _
					CType(Integralab.ORM.EntityType.CuentaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CuentaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CuentaEntity.CustomProperties
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
				Return CuentaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentacontableId property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."cuentacontableId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CuentacontableId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.CuentacontableId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.CuentacontableId, Integer), value)
			End Set
		End Property
	
		''' <summary>The EmpresaId property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."empresaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EmpresaId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.EmpresaId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.EmpresaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The BancoId property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."bancoId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BancoId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.BancoId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.BancoId, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipomonedaId property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."tipomonedaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipomonedaId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.TipomonedaId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.TipomonedaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Folioactual property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."folioactual"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Folioactual]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Folioactual, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Folioactual, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cuenta property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."cuenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cuenta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Cuenta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Cuenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cuentahabiente property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."cuentahabiente"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cuentahabiente]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Cuentahabiente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Cuentahabiente, Integer), value)
			End Set
		End Property
	
		''' <summary>The Saldoinicial property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."saldoinicial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Saldoinicial]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Saldoinicial, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Saldoinicial, Integer), value)
			End Set
		End Property
	
		''' <summary>The Saldodiaant property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."saldodiaant"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Saldodiaant]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Saldodiaant, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Saldodiaant, Integer), value)
			End Set
		End Property
	
		''' <summary>The Saldoreal property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."saldoreal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Saldoreal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Saldoreal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Saldoreal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Saldoactual property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."saldoactual"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Saldoactual]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Saldoactual, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Saldoactual, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Cuenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanCuentas"."estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CuentaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MveCtaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMveCta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MveCta]() As Integralab.ORM.CollectionClasses.MveCtaCollection
			Get
				Return GetMultiMveCta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MveCta. When set to true, MveCta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MveCta is accessed. You can always execute
		''' a forced fetch by calling GetMultiMveCta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMveCta As Boolean
			Get
				Return _alwaysFetchMveCta
			End Get
			Set
				_alwaysFetchMveCta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCheque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cheque]() As Integralab.ORM.CollectionClasses.ChequeCollection
			Get
				Return GetMultiCheque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cheque. When set to true, Cheque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cheque is accessed. You can always execute
		''' a forced fetch by calling GetMultiCheque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCheque As Boolean
			Get
				Return _alwaysFetchCheque
			End Get
			Set
				_alwaysFetchCheque = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCheque_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cheque_]() As Integralab.ORM.CollectionClasses.ChequeCollection
			Get
				Return GetMultiCheque_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cheque_. When set to true, Cheque_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cheque_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCheque_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCheque_ As Boolean
			Get
				Return _alwaysFetchCheque_
			End Get
			Set
				_alwaysFetchCheque_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrBanDepositos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrBanDepositos]() As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Get
				Return GetMultiUsrBanDepositos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrBanDepositos. When set to true, UsrBanDepositos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrBanDepositos is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrBanDepositos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrBanDepositos As Boolean
			Get
				Return _alwaysFetchUsrBanDepositos
			End Get
			Set
				_alwaysFetchUsrBanDepositos = value
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
	
	
		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBeneficiarioCollectionViaCheque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [BeneficiarioCollectionViaCheque]() As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Get
				Return GetMultiBeneficiarioCollectionViaCheque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for BeneficiarioCollectionViaCheque. When set to true, BeneficiarioCollectionViaCheque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time BeneficiarioCollectionViaCheque is accessed. You can always execute
		''' a forced fetch by calling GetMultiBeneficiarioCollectionViaCheque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBeneficiarioCollectionViaCheque As Boolean
			Get
				Return _alwaysFetchBeneficiarioCollectionViaCheque
			End Get
			Set
				_alwaysFetchBeneficiarioCollectionViaCheque = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBeneficiarioCollectionViaCheque_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [BeneficiarioCollectionViaCheque_]() As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Get
				Return GetMultiBeneficiarioCollectionViaCheque_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for BeneficiarioCollectionViaCheque_. When set to true, BeneficiarioCollectionViaCheque_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time BeneficiarioCollectionViaCheque_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiBeneficiarioCollectionViaCheque_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBeneficiarioCollectionViaCheque_ As Boolean
			Get
				Return _alwaysFetchBeneficiarioCollectionViaCheque_
			End Get
			Set
				_alwaysFetchBeneficiarioCollectionViaCheque_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaCheque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaCheque]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaCheque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaCheque. When set to true, PolizaCollectionViaCheque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaCheque is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaCheque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaCheque As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaCheque
			End Get
			Set
				_alwaysFetchPolizaCollectionViaCheque = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaCheque__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaCheque__]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaCheque__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaCheque__. When set to true, PolizaCollectionViaCheque__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaCheque__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaCheque__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaCheque__ As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaCheque__
			End Get
			Set
				_alwaysFetchPolizaCollectionViaCheque__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaCheque_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaCheque_]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaCheque_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaCheque_. When set to true, PolizaCollectionViaCheque_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaCheque_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaCheque_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaCheque_ As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaCheque_
			End Get
			Set
				_alwaysFetchPolizaCollectionViaCheque_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaCheque___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaCheque___]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaCheque___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaCheque___. When set to true, PolizaCollectionViaCheque___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaCheque___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaCheque___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaCheque___ As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaCheque___
			End Get
			Set
				_alwaysFetchPolizaCollectionViaCheque___ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaUsrBanDepositos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaUsrBanDepositos]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaUsrBanDepositos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaUsrBanDepositos. When set to true, PolizaCollectionViaUsrBanDepositos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaUsrBanDepositos is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaUsrBanDepositos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaUsrBanDepositos As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaUsrBanDepositos
			End Get
			Set
				_alwaysFetchPolizaCollectionViaUsrBanDepositos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaUsrBanDepositos_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaUsrBanDepositos_]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaUsrBanDepositos_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaUsrBanDepositos_. When set to true, PolizaCollectionViaUsrBanDepositos_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaUsrBanDepositos_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaUsrBanDepositos_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaUsrBanDepositos_ As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaUsrBanDepositos_
			End Get
			Set
				_alwaysFetchPolizaCollectionViaUsrBanDepositos_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaUsrCxppagosProveedores()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaUsrCxppagosProveedores]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaUsrCxppagosProveedores(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaUsrCxppagosProveedores. When set to true, ProveedorCollectionViaUsrCxppagosProveedores is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaUsrCxppagosProveedores is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaUsrCxppagosProveedores(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaUsrCxppagosProveedores As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaUsrCxppagosProveedores
			End Get
			Set
				_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaUsrCxppagosProveedores()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaUsrCxppagosProveedores]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaUsrCxppagosProveedores(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaUsrCxppagosProveedores. When set to true, PolizaCollectionViaUsrCxppagosProveedores is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaUsrCxppagosProveedores is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaUsrCxppagosProveedores(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaUsrCxppagosProveedores As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaUsrCxppagosProveedores
			End Get
			Set
				_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'TipoMonedaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoMoneda()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoMoneda]() As TipoMonedaEntity
			Get
				Return GetSingleTipoMoneda(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoMoneda(value)
				Else
					If value Is Nothing Then
						If Not _tipoMoneda Is Nothing Then
							_tipoMoneda.UnsetRelatedEntity(Me, "Cuenta")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cuenta")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMoneda. When set to true, TipoMoneda is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMoneda is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoMoneda(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMoneda As Boolean
			Get
				Return _alwaysFetchTipoMoneda
			End Get
			Set
				_alwaysFetchTipoMoneda = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoMoneda is not found
		''' in the database. When set to true, TipoMoneda will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoMonedaReturnsNewIfNotFound As Boolean
			Get
				Return _tipoMonedaReturnsNewIfNotFound
			End Get
			Set
				_tipoMonedaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'BancosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBancos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Bancos]() As BancosEntity
			Get
				Return GetSingleBancos(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncBancos(value)
				Else
					If value Is Nothing Then
						If Not _bancos Is Nothing Then
							_bancos.UnsetRelatedEntity(Me, "Cuenta")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cuenta")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Bancos. When set to true, Bancos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Bancos is accessed. You can always execute
		''' a forced fetch by calling GetSingleBancos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBancos As Boolean
			Get
				Return _alwaysFetchBancos
			End Get
			Set
				_alwaysFetchBancos = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Bancos is not found
		''' in the database. When set to true, Bancos will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property BancosReturnsNewIfNotFound As Boolean
			Get
				Return _bancosReturnsNewIfNotFound
			End Get
			Set
				_bancosReturnsNewIfNotFound = value
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
							_cuentaContable.UnsetRelatedEntity(Me, "Cuenta")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cuenta")
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
				Return CInt(Integralab.ORM.EntityType.CuentaEntity)
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
