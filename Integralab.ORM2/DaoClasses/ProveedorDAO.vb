﻿' ///////////////////////////////////////////////////////////////
' This is generated code. If you modify this code, be aware
' of the fact that when you re-generate the code, your changes
' are lost. If you want to keep your changes, make this file read-only
' when you have finished your changes, however it is recommended that
' you inherit from this class to extend the functionality of this generated
' class or you modify / extend the templates used to generate this code.
' //////////////////////////////////////////////////////////////
' Code is generated using LLBLGen Pro version: 2.0.0.0
' Code is generated on: lunes, 11 de diciembre de 2017 20:57:19
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
	''' General DAO class for the Proveedor Entity. It will perform database oriented actions for
	''' a entity of type 'ProveedorEntity'. This DAO works on an EntityFields object. 
	''' </summary>
	Public Class ProveedorDAO 
		Inherits DaoBase
		
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(InheritanceInfoProviderSingleton.GetInstance(), New DynamicQueryEngine(), InheritanceHierarchyType.None, "ProveedorEntity", New ProveedorEntityFactory())
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
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity instance to use as a filter for the ProveedorEntity objects to return</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the ProveedorEntity objects to return</param>
		''' <param name="cuentaContable_Instance">CuentaContableEntity instance to use as a filter for the ProveedorEntity objects to return</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		Public Overloads Function GetMulti(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression, catLugaresDeCompraInstance As IEntity, cuentaContableInstance As IEntity, cuentaContable_Instance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			MyBase.EntityFactoryToUse = entityFactoryToUse
			Dim fieldsToReturn  As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim selectFilter As IPredicateExpression= CreateFilterUsingForeignKeys(catLugaresDeCompraInstance, cuentaContableInstance, cuentaContable_Instance, fieldsToReturn)
			If Not Filter Is Nothing Then
				' add contents to select filter, with AND
				selectFilter.AddWithAnd(Filter)
			End If
			Return MyBase.PerformGetMultiAction(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, Nothing, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves entities of the type 'ProveedorEntity' in a datatable which match the specified filter. It will always create a new connection to the database.
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Return MyBase.PerformGetMultiAsDataTableAction(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function

	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabMovGanInstance">CabMovGanEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabMovGanCollectionViaCabRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabMovGanInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabMovGanInstance.Fields(CInt(CabMovGanFieldIndex.FolMovGan)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabMovGanInstance">CabMovGanEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabMovGanCollectionViaCabRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabMovGanInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabMovGanInstance.Fields(CInt(CabMovGanFieldIndex.FolMovGan)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabMovGanInstance">CabMovGanEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabMovGanCollectionViaCabRegCom_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabMovGanInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabMovGanInstance.Fields(CInt(CabMovGanFieldIndex.FolMovGan)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabMovGanInstance">CabMovGanEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabMovGanCollectionViaCabRegCom_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabMovGanInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabMovGanInstance.Fields(CInt(CabMovGanFieldIndex.FolMovGan)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatLugaresDeCompraCollectionViaCabRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catLugaresDeCompraInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catLugaresDeCompraInstance.Fields(CInt(CatLugaresDeCompraFieldIndex.IdLugarCompra)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatLugaresDeCompraCollectionViaCabRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catLugaresDeCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catLugaresDeCompraInstance.Fields(CInt(CatLugaresDeCompraFieldIndex.IdLugarCompra)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcecatCorralesCabCollectionViaCabRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatCorralesCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatCorralesCabInstance.Fields(CInt(McecatCorralesCabFieldIndex.IdCorral)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcecatCorralesCabCollectionViaCabRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatCorralesCabInstance.Fields(CInt(McecatCorralesCabFieldIndex.IdCorral)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McgcatCompradoresdeGanadoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcgcatCompradoresdeGanadoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcgcatCompradoresdeGanadoInstance.Fields(CInt(McgcatCompradoresdeGanadoFieldIndex.IdComprador)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McgcatCompradoresdeGanadoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcgcatCompradoresdeGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "CabRegCom_")
			relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, "CabRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcgcatCompradoresdeGanadoInstance.Fields(CInt(McgcatCompradoresdeGanadoFieldIndex.IdComprador)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ProductoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="productoInstance">ProductoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingProductoCollectionViaCostoProductoProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CostoProductoProveedorEntityUsingProveedor, "CostoProductoProveedor_")
			relations.Add(CostoProductoProveedorEntity.Relations.ProductoEntityUsingProducto, "CostoProductoProveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ProductoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="productoInstance">ProductoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingProductoCollectionViaCostoProductoProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CostoProductoProveedorEntityUsingProveedor, "CostoProductoProveedor_")
			relations.Add(CostoProductoProveedorEntity.Relations.ProductoEntityUsingProducto, "CostoProductoProveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcomCotizacionCompraInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdProveedor, "McomCotizacionCompraProveedor_")
			relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "McomCotizacionCompraProveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcomCotizacionCompraInstance.Fields(CInt(McomCotizacionCompraFieldIndex.IdCotizacion)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcomCotizacionCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdProveedor, "McomCotizacionCompraProveedor_")
			relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "McomCotizacionCompraProveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcomCotizacionCompraInstance.Fields(CInt(McomCotizacionCompraFieldIndex.IdCotizacion)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ProductoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="productoInstance">ProductoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingProductoCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ProductoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="productoInstance">ProductoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingProductoCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in SolicitudProductoDetalleEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="solicitudProductoDetalleInstance">SolicitudProductoDetalleEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, solicitudProductoDetalleInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(solicitudProductoDetalleInstance.Fields(CInt(SolicitudProductoDetalleFieldIndex.IdSolicitud)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(solicitudProductoDetalleInstance.Fields(CInt(SolicitudProductoDetalleFieldIndex.IdProducto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in SolicitudProductoDetalleEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="solicitudProductoDetalleInstance">SolicitudProductoDetalleEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, solicitudProductoDetalleInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(solicitudProductoDetalleInstance.Fields(CInt(SolicitudProductoDetalleFieldIndex.IdSolicitud)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(solicitudProductoDetalleInstance.Fields(CInt(SolicitudProductoDetalleFieldIndex.IdProducto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcomCotizacionCompraInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcomCotizacionCompraInstance.Fields(CInt(McomCotizacionCompraFieldIndex.IdCotizacion)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcomCotizacionCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcomCotizacionCompraInstance.Fields(CInt(McomCotizacionCompraFieldIndex.IdCotizacion)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McomCotizacionCompraProveedorEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcomCotizacionCompraProveedorInstance">McomCotizacionCompraProveedorEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcomCotizacionCompraProveedorInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcomCotizacionCompraProveedorInstance.Fields(CInt(McomCotizacionCompraProveedorFieldIndex.IdCotizacion)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(mcomCotizacionCompraProveedorInstance.Fields(CInt(McomCotizacionCompraProveedorFieldIndex.IdProveedor)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McomCotizacionCompraProveedorEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcomCotizacionCompraProveedorInstance">McomCotizacionCompraProveedorEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcomCotizacionCompraProveedorInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_")
			relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcomCotizacionCompraProveedorInstance.Fields(CInt(McomCotizacionCompraProveedorFieldIndex.IdCotizacion)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(mcomCotizacionCompraProveedorInstance.Fields(CInt(McomCotizacionCompraProveedorFieldIndex.IdProveedor)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMonedaCollectionViaOrdenCompra(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.OrdenCompraEntityUsingIdProveedor, "OrdenCompra_")
			relations.Add(OrdenCompraEntity.Relations.TipoMonedaEntityUsingIdMoneda, "OrdenCompra_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMonedaCollectionViaOrdenCompra(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.OrdenCompraEntityUsingIdProveedor, "OrdenCompra_")
			relations.Add(OrdenCompraEntity.Relations.TipoMonedaEntityUsingIdMoneda, "OrdenCompra_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMonedaCollectionViaCotizacionServicio(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CotizacionServicioEntityUsingProveedorId, "CotizacionServicio_")
			relations.Add(CotizacionServicioEntity.Relations.TipoMonedaEntityUsingTipoMonedaId, "CotizacionServicio_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMonedaCollectionViaCotizacionServicio(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.CotizacionServicioEntityUsingProveedorId, "CotizacionServicio_")
			relations.Add(CotizacionServicioEntity.Relations.TipoMonedaEntityUsingTipoMonedaId, "CotizacionServicio_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMonedaCollectionViaOrdenServicio(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.OrdenServicioEntityUsingProveedorId, "OrdenServicio_")
			relations.Add(OrdenServicioEntity.Relations.TipoMonedaEntityUsingMonedaId, "OrdenServicio_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMonedaCollectionViaOrdenServicio(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.OrdenServicioEntityUsingProveedorId, "OrdenServicio_")
			relations.Add(OrdenServicioEntity.Relations.TipoMonedaEntityUsingMonedaId, "OrdenServicio_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CuentaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cuentaInstance">CuentaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCuentaCollectionViaUsrCxppagosProveedores(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cuentaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, "UsrCxppagosProveedores_")
			relations.Add(UsrCxppagosProveedoresEntity.Relations.CuentaEntityUsingCuentaBancariaId, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cuentaInstance.Fields(CInt(CuentaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CuentaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cuentaInstance">CuentaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCuentaCollectionViaUsrCxppagosProveedores(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cuentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, "UsrCxppagosProveedores_")
			relations.Add(UsrCxppagosProveedoresEntity.Relations.CuentaEntityUsingCuentaBancariaId, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cuentaInstance.Fields(CInt(CuentaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PolizaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="polizaInstance">PolizaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPolizaCollectionViaUsrCxppagosProveedores(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, polizaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, "UsrCxppagosProveedores_")
			relations.Add(UsrCxppagosProveedoresEntity.Relations.PolizaEntityUsingPolizaId, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(polizaInstance.Fields(CInt(PolizaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PolizaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="polizaInstance">PolizaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPolizaCollectionViaUsrCxppagosProveedores(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, polizaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, "UsrCxppagosProveedores_")
			relations.Add(UsrCxppagosProveedoresEntity.Relations.PolizaEntityUsingPolizaId, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(polizaInstance.Fields(CInt(PolizaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
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
		Public Function GetMultiUsingMcgcatTiposdeGanadoCollectionViaRecepcionGanado(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcgcatTiposdeGanadoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As New RelationCollection()
			relations.Add(ProveedorEntity.Relations.RecepcionGanadoEntityUsingIdProveedor, "RecepcionGanado_")
			relations.Add(RecepcionGanadoEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, "RecepcionGanado_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcgcatTiposdeGanadoInstance.Fields(CInt(McgcatTiposdeGanadoFieldIndex.IdTipoGanado)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling ProveedorCollection object all ProveedorEntity objects
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
		Public Function GetMultiUsingMcgcatTiposdeGanadoCollectionViaRecepcionGanado(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcgcatTiposdeGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim relations As  New RelationCollection()
			relations.Add(ProveedorEntity.Relations.RecepcionGanadoEntityUsingIdProveedor, "RecepcionGanado_")
			relations.Add(RecepcionGanadoEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, "RecepcionGanado_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcgcatTiposdeGanadoInstance.Fields(CInt(McgcatTiposdeGanadoFieldIndex.IdTipoGanado)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	

	
		''' <summary>
		''' Deletes from the persistent storage all 'Proveedor' entities which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity instance to use as a filter for the ProveedorEntity objects to delete</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the ProveedorEntity objects to delete</param>
		''' <param name="cuentaContable_Instance">CuentaContableEntity instance to use as a filter for the ProveedorEntity objects to delete</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMulti(containingTransaction As ITransaction, catLugaresDeCompraInstance As IEntity, cuentaContableInstance As IEntity, cuentaContable_Instance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim deleteFilter As IPredicateExpression = CreateFilterUsingForeignKeys(catLugaresDeCompraInstance, cuentaContableInstance, cuentaContable_Instance, fields)
			Return MyBase.DeleteMulti(containingTransaction, deleteFilter)
		End Function

		''' <summary>
		''' Updates all entities of the same type or subtype of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		''' supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. Entities of a subtype of the type
		''' of <i>entityWithNewValues</i> which are affected by the filterBucket's filter will thus also be updated. 
		''' </summary>
		''' <param name="entityWithNewValues">IEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity instance to use as a filter for the ProveedorEntity objects to update</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the ProveedorEntity objects to update</param>
		''' <param name="cuentaContable_Instance">CuentaContableEntity instance to use as a filter for the ProveedorEntity objects to update</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As IEntity, containingTransaction As ITransaction, catLugaresDeCompraInstance As IEntity, cuentaContableInstance As IEntity, cuentaContable_Instance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
			Dim updateFilter As IPredicateExpression = CreateFilterUsingForeignKeys(catLugaresDeCompraInstance, cuentaContableInstance, cuentaContable_Instance, fields)
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
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity instance to use as a filter for the ProveedorEntity objects</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the ProveedorEntity objects</param>
		''' <param name="cuentaContable_Instance">CuentaContableEntity instance to use as a filter for the ProveedorEntity objects</param>
		''' <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the fieldset of the target entity.</param>
		''' <returns>A ready to use PredicateExpression based on the passed in foreign key value holders.</returns>
		Private Function CreateFilterUsingForeignKeys(catLugaresDeCompraInstance As IEntity, cuentaContableInstance As IEntity, cuentaContable_Instance As IEntity, fieldsToReturn As IEntityFields) As IPredicateExpression
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			
			If Not catLugaresDeCompraInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(ProveedorFieldIndex.IdLugarCompra)), ComparisonOperator.Equal, CType(catLugaresDeCompraInstance, CatLugaresDeCompraEntity).IdLugarCompra))
			End If
			If Not cuentaContableInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(ProveedorFieldIndex.CuentaContId)), ComparisonOperator.Equal, CType(cuentaContableInstance, CuentaContableEntity).Codigo))
			End If
			If Not cuentaContable_Instance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(ProveedorFieldIndex.PrCuentaAnt)), ComparisonOperator.Equal, CType(cuentaContable_Instance, CuentaContableEntity).Codigo))
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
