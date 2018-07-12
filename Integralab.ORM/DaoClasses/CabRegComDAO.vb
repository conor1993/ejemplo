' ///////////////////////////////////////////////////////////////
' This is generated code. If you modify this code, be aware
' of the fact that when you re-generate the code, your changes
' are lost. If you want to keep your changes, make this file read-only
' when you have finished your changes, however it is recommended that
' you inherit from this class to extend the functionality of this generated
' class or you modify / extend the templates used to generate this code.
' //////////////////////////////////////////////////////////////
' Code is generated using LLBLGen Pro version: 2.0.0.0
' Code is generated on: jueves, 12 de julio de 2018 16:37:24
' Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' Templates vendor: Solutions Design.
' Templates version: 
' //////////////////////////////////////////////////////////////
Imports System
Imports System.Data
Imports System.Data.Common

Imports Integralab.ORM.EntityClasses
Imports Integralab.ORM.FactoryClasses
Imports Integralab.ORM.CollectionClasses
Imports Integralab.ORM.HelperClasses
Imports Integralab.ORM

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports SD.LLBLGen.Pro.DQE.SqlServer



' __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
' __LLBLGENPRO_USER_CODE_REGION_END
Namespace Integralab.ORM.DaoClasses

	''' <summary>
	''' General DAO class for the CabRegCom Entity. It will perform database oriented actions for
	''' a entity of type 'CabRegComEntity'. This DAO works on an EntityFields object. 
	''' </summary>
	Public Class CabRegComDAO 
		Inherits DaoBase
		
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(InheritanceInfoProviderSingleton.GetInstance(), New DynamicQueryEngine(), InheritanceHierarchyType.None, "CabRegComEntity", New CabRegComEntityFactory())
		End Sub
		
		''' <summary>CTor</summary>
		''' <param name="inheritanceInfoProviderToUse">Inheritance info provider to use.</param>
		''' <param name="dqeToUse">Dqe to use.</param>
		''' <param name="typeOfInheritance">Type of inheritance.</param>
		''' <param name="entityName">Name of the entity.</param>
		''' <param name="entityFactory">Entity factory.</param>
		Friend Sub New (inheritanceInfoProviderToUse As IInheritanceInfoProvider, dqeToUse As DynamicQueryEngineBase, typeOfInheritance As InheritanceHierarchyType, entityName As String, entityFactory As IEntityFactory)
			MyBase.New(inheritanceInfoProviderToUse, dqeToUse, typeOfInheritance, entityName, entityFactory)
		End Sub


		''' <summary>
		''' Retrieves in the calling CabRegComCollection object all CabRegComEntity objects which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the CabRegComEntity objects to return</param>
		''' <param name="cabMovGan_Instance">CabMovGanEntity instance to use as a filter for the CabRegComEntity objects to return</param>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity instance to use as a filter for the CabRegComEntity objects to return</param>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the CabRegComEntity objects to return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the CabRegComEntity objects to return</param>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity instance to use as a filter for the CabRegComEntity objects to return</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		Public Overloads Function GetMulti(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression, cabMovGanInstance As IEntity, cabMovGan_Instance As IEntity, catLugaresDeCompraInstance As IEntity, proveedorInstance As IEntity, mcecatCorralesCabInstance As IEntity, mcgcatCompradoresdeGanadoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			MyBase.EntityFactoryToUse = entityFactoryToUse
			Dim fieldsToReturn  As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabRegComEntity)
			Dim selectFilter As IPredicateExpression= CreateFilterUsingForeignKeys(cabMovGanInstance, cabMovGan_Instance, catLugaresDeCompraInstance, proveedorInstance, mcecatCorralesCabInstance, mcgcatCompradoresdeGanadoInstance, fieldsToReturn)
			If Not Filter Is Nothing Then
				' add contents to select filter, with AND
				selectFilter.AddWithAnd(Filter)
			End If
			Return MyBase.PerformGetMultiAction(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, Nothing, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves entities of the type 'CabRegComEntity' in a datatable which match the specified filter. It will always create a new connection to the database.
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>a filled datatable if succeeded, false otherwise</returns>
		Public Overridable Function GetMultiAsDataTable(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, selectFilter As IPredicate, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As  DataTable
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabRegComEntity)
			Return MyBase.PerformGetMultiAsDataTableAction(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function

	
		''' <summary>
		''' Retrieves in the calling CabRegComCollection object all CabRegComEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcgcatTiposdeGanadoCollectionViaDetRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcgcatTiposdeGanadoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabRegComEntity)
			Dim relations As New RelationCollection()
			relations.Add(CabRegComEntity.Relations.DetRegComEntityUsingFolRecep, "DetRegCom_")
			relations.Add(DetRegComEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado, "DetRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcgcatTiposdeGanadoInstance.Fields(CInt(McgcatTiposdeGanadoFieldIndex.IdTipoGanado)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CabRegComCollection object all CabRegComEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcgcatTiposdeGanadoCollectionViaDetRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcgcatTiposdeGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabRegComEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CabRegComEntity.Relations.DetRegComEntityUsingFolRecep, "DetRegCom_")
			relations.Add(DetRegComEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado, "DetRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcgcatTiposdeGanadoInstance.Fields(CInt(McgcatTiposdeGanadoFieldIndex.IdTipoGanado)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	

	
		''' <summary>
		''' Deletes from the persistent storage all 'CabRegCom' entities which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the CabRegComEntity objects to delete</param>
		''' <param name="cabMovGan_Instance">CabMovGanEntity instance to use as a filter for the CabRegComEntity objects to delete</param>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity instance to use as a filter for the CabRegComEntity objects to delete</param>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the CabRegComEntity objects to delete</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the CabRegComEntity objects to delete</param>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity instance to use as a filter for the CabRegComEntity objects to delete</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMulti(containingTransaction As ITransaction, cabMovGanInstance As IEntity, cabMovGan_Instance As IEntity, catLugaresDeCompraInstance As IEntity, proveedorInstance As IEntity, mcecatCorralesCabInstance As IEntity, mcgcatCompradoresdeGanadoInstance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabRegComEntity)
			Dim deleteFilter As IPredicateExpression = CreateFilterUsingForeignKeys(cabMovGanInstance, cabMovGan_Instance, catLugaresDeCompraInstance, proveedorInstance, mcecatCorralesCabInstance, mcgcatCompradoresdeGanadoInstance, fields)
			Return MyBase.DeleteMulti(containingTransaction, deleteFilter)
		End Function

		''' <summary>
		''' Updates all entities of the same type or subtype of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		''' supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. Entities of a subtype of the type
		''' of <i>entityWithNewValues</i> which are affected by the filterBucket's filter will thus also be updated. 
		''' </summary>
		''' <param name="entityWithNewValues">IEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the CabRegComEntity objects to update</param>
		''' <param name="cabMovGan_Instance">CabMovGanEntity instance to use as a filter for the CabRegComEntity objects to update</param>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity instance to use as a filter for the CabRegComEntity objects to update</param>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the CabRegComEntity objects to update</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the CabRegComEntity objects to update</param>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity instance to use as a filter for the CabRegComEntity objects to update</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As IEntity, containingTransaction As ITransaction, cabMovGanInstance As IEntity, cabMovGan_Instance As IEntity, catLugaresDeCompraInstance As IEntity, proveedorInstance As IEntity, mcecatCorralesCabInstance As IEntity, mcgcatCompradoresdeGanadoInstance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabRegComEntity)
			Dim updateFilter As IPredicateExpression = CreateFilterUsingForeignKeys(cabMovGanInstance, cabMovGan_Instance, catLugaresDeCompraInstance, proveedorInstance, mcecatCorralesCabInstance, mcgcatCompradoresdeGanadoInstance, fields)
			Return MyBase.UpdateMulti(entityWithNewValues, containingTransaction, updateFilter)
		End Function
	

		''' <summary>
		''' Determines the connection to use. If transaction to use is Nothing, a new connection is created, otherwise the connection of the transaction is used.
		''' </summary>
		''' <param name="transactionToUse">Transaction to use.</param>
		''' <returns>a ready to use connection object.</returns>
		Protected Overrides Function DetermineConnectionToUse(transactionToUse As ITransaction) As IDbConnection
			Return DbUtils.DetermineConnectionToUse(transactionToUse)
		End Function
		
		''' <summary>
		''' Creates a new ADO.NET data adapter.
		''' </summary>
		''' <returns>ready to use ADO.NET data-adapter</returns>
		Protected Overrides Function CreateDataAdapter() As  DbDataAdapter
			Return DbUtils.CreateDataAdapter()
		End Function


		''' <summary>
		''' Creates a PredicateExpression which should be used as a filter when any combination of available foreign keys is specified.
		''' </summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the CabRegComEntity objects</param>
		''' <param name="cabMovGan_Instance">CabMovGanEntity instance to use as a filter for the CabRegComEntity objects</param>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity instance to use as a filter for the CabRegComEntity objects</param>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the CabRegComEntity objects</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the CabRegComEntity objects</param>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity instance to use as a filter for the CabRegComEntity objects</param>
		''' <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the fieldset of the target entity.</param>
		''' <returns>A ready to use PredicateExpression based on the passed in foreign key value holders.</returns>
		Private Function CreateFilterUsingForeignKeys(cabMovGanInstance As IEntity, cabMovGan_Instance As IEntity, catLugaresDeCompraInstance As IEntity, proveedorInstance As IEntity, mcecatCorralesCabInstance As IEntity, mcgcatCompradoresdeGanadoInstance As IEntity, fieldsToReturn As IEntityFields) As IPredicateExpression
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			
			If Not cabMovGanInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(CabRegComFieldIndex.FolioMovimientoGanado)), ComparisonOperator.Equal, CType(cabMovGanInstance, CabMovGanEntity).FolMovGan))
			End If
			If Not cabMovGan_Instance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(CabRegComFieldIndex.FolioMovimientoGanadoCancelacion)), ComparisonOperator.Equal, CType(cabMovGan_Instance, CabMovGanEntity).FolMovGan))
			End If
			If Not catLugaresDeCompraInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(CabRegComFieldIndex.CveLugCom)), ComparisonOperator.Equal, CType(catLugaresDeCompraInstance, CatLugaresDeCompraEntity).IdLugarCompra))
			End If
			If Not proveedorInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(CabRegComFieldIndex.CveProveGan)), ComparisonOperator.Equal, CType(proveedorInstance, ProveedorEntity).Codigo))
			End If
			If Not mcecatCorralesCabInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(CabRegComFieldIndex.CveCorral)), ComparisonOperator.Equal, CType(mcecatCorralesCabInstance, McecatCorralesCabEntity).IdCorral))
			End If
			If Not mcgcatCompradoresdeGanadoInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(CabRegComFieldIndex.CveComiGan)), ComparisonOperator.Equal, CType(mcgcatCompradoresdeGanadoInstance, McgcatCompradoresdeGanadoEntity).IdComprador))
			End If
			Return selectFilter
		End Function


#Region "Custom DAO code"
		
		' __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		' __LLBLGENPRO_USER_CODE_REGION_END
#End Region
		
#Region "Included Code"

#End Region

	End Class
End Namespace
