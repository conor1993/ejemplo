' ///////////////////////////////////////////////////////////////
' This is generated code. If you modify this code, be aware
' of the fact that when you re-generate the code, your changes
' are lost. If you want to keep your changes, make this file read-only
' when you have finished your changes, however it is recommended that
' you inherit from this class to extend the functionality of this generated
' class or you modify / extend the templates used to generate this code.
' //////////////////////////////////////////////////////////////
' Code is generated using LLBLGen Pro version: 2.0.0.0
' Code is generated on: lunes, 23 de abril de 2018 15:21:52
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
	''' General DAO class for the CuentaContable Entity. It will perform database oriented actions for
	''' a entity of type 'CuentaContableEntity'. This DAO works on an EntityFields object. 
	''' </summary>
	Public Class CuentaContableDAO 
		Inherits DaoBase
		
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(InheritanceInfoProviderSingleton.GetInstance(), New DynamicQueryEngine(), InheritanceHierarchyType.None, "CuentaContableEntity", New CuentaContableEntityFactory())
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
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to return</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to return</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to return</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		Public Overloads Function GetMulti(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression, cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			MyBase.EntityFactoryToUse = entityFactoryToUse
			Dim fieldsToReturn  As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim selectFilter As IPredicateExpression= CreateFilterUsingForeignKeys(cuentaEntradaInstance, cuentaSalidaInstance, cuentaPadreInstance, fieldsToReturn)
			If Not Filter Is Nothing Then
				' add contents to select filter, with AND
				selectFilter.AddWithAnd(Filter)
			End If
			Return MyBase.PerformGetMultiAction(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, Nothing, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves entities of the type 'CuentaContableEntity' in a datatable which match the specified filter. It will always create a new connection to the database.
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Return MyBase.PerformGetMultiAsDataTableAction(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function

	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PeriodosContEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="periodosContInstance">PeriodosContEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPeriodosContCollectionViaAcumuladoCuentasContables(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, periodosContInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.AcumuladoCuentasContablesEntityUsingCodigo, "AcumuladoCuentasContables_")
			relations.Add(AcumuladoCuentasContablesEntity.Relations.PeriodosContEntityUsingEjercicio, "AcumuladoCuentasContables_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(periodosContInstance.Fields(CInt(PeriodosContFieldIndex.Ejercicio)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PeriodosContEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="periodosContInstance">PeriodosContEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPeriodosContCollectionViaAcumuladoCuentasContables(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, periodosContInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.AcumuladoCuentasContablesEntityUsingCodigo, "AcumuladoCuentasContables_")
			relations.Add(AcumuladoCuentasContablesEntity.Relations.PeriodosContEntityUsingEjercicio, "AcumuladoCuentasContables_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(periodosContInstance.Fields(CInt(PeriodosContFieldIndex.Ejercicio)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabBalanceEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabBalanceInstance">CabBalanceEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabBalanceCollectionViaDetBalance(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabBalanceInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.DetBalanceEntityUsingCveCuentaContable, "DetBalance_")
			relations.Add(DetBalanceEntity.Relations.CabBalanceEntityUsingCveBalance, "DetBalance_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabBalanceInstance.Fields(CInt(CabBalanceFieldIndex.CveBalance)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabBalanceEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabBalanceInstance">CabBalanceEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabBalanceCollectionViaDetBalance(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabBalanceInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.DetBalanceEntityUsingCveCuentaContable, "DetBalance_")
			relations.Add(DetBalanceEntity.Relations.CabBalanceEntityUsingCveBalance, "DetBalance_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabBalanceInstance.Fields(CInt(CabBalanceFieldIndex.CveBalance)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabEdoResEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabEdoResInstance">CabEdoResEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabEdoResCollectionViaDetEdoRes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabEdoResInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.DetEdoResEntityUsingCuentaContableId, "DetEdoRes_")
			relations.Add(DetEdoResEntity.Relations.CabEdoResEntityUsingCveEdoRes, "DetEdoRes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabEdoResInstance.Fields(CInt(CabEdoResFieldIndex.CveEdoRes)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabEdoResEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabEdoResInstance">CabEdoResEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabEdoResCollectionViaDetEdoRes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabEdoResInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.DetEdoResEntityUsingCuentaContableId, "DetEdoRes_")
			relations.Add(DetEdoResEntity.Relations.CabEdoResEntityUsingCveEdoRes, "DetEdoRes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabEdoResInstance.Fields(CInt(CabEdoResFieldIndex.CveEdoRes)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="metodoCabInstance">MetodoCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMetodoCabCollectionViaGastosDepartamentos(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, metodoCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, "GastosDepartamentos_")
			relations.Add(GastosDepartamentosEntity.Relations.MetodoCabEntityUsingIdMetodoProrrateo, "GastosDepartamentos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(metodoCabInstance.Fields(CInt(MetodoCabFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="metodoCabInstance">MetodoCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMetodoCabCollectionViaGastosDepartamentos(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, metodoCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, "GastosDepartamentos_")
			relations.Add(GastosDepartamentosEntity.Relations.MetodoCabEntityUsingIdMetodoProrrateo, "GastosDepartamentos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(metodoCabInstance.Fields(CInt(MetodoCabFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingPolizaCollectionViaGastosDepartamentos(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, polizaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, "GastosDepartamentos_")
			relations.Add(GastosDepartamentosEntity.Relations.PolizaEntityUsingIdPoliza, "GastosDepartamentos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(polizaInstance.Fields(CInt(PolizaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingPolizaCollectionViaGastosDepartamentos(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, polizaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, "GastosDepartamentos_")
			relations.Add(GastosDepartamentosEntity.Relations.PolizaEntityUsingIdPoliza, "GastosDepartamentos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(polizaInstance.Fields(CInt(PolizaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PlazaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="plazaInstance">PlazaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPlazaCollectionViaAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, plazaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "Almacen_")
			relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PlazaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="plazaInstance">PlazaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPlazaCollectionViaAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "Almacen_")
			relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in AlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="almacenInstance">AlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingAlmacenCollectionViaAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, almacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "Almacen_")
			relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(almacenInstance.Fields(CInt(AlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in AlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="almacenInstance">AlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingAlmacenCollectionViaAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "Almacen_")
			relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(almacenInstance.Fields(CInt(AlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoAlmacenCollectionViaAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "Almacen_")
			relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoAlmacenInstance.Fields(CInt(TipoAlmacenFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoAlmacenCollectionViaAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "Almacen_")
			relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoAlmacenInstance.Fields(CInt(TipoAlmacenFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PlazaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="plazaInstance">PlazaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPlazaCollectionViaMcatCentroCostosAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, plazaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.McatCentroCostosEntityUsingIdCuentaCont, "McatCentroCostos_")
			relations.Add(McatCentroCostosEntity.Relations.PlazaEntityUsingIdPlaza, "McatCentroCostos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PlazaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="plazaInstance">PlazaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPlazaCollectionViaMcatCentroCostosAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.McatCentroCostosEntityUsingIdCuentaCont, "McatCentroCostos_")
			relations.Add(McatCentroCostosEntity.Relations.PlazaEntityUsingIdPlaza, "McatCentroCostos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoComicionistaCollectionViaComicionista(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoComicionistaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, "Comicionista_")
			relations.Add(ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista, "Comicionista_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoComicionistaInstance.Fields(CInt(TipoComicionistaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoComicionistaCollectionViaComicionista(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoComicionistaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, "Comicionista_")
			relations.Add(ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista, "Comicionista_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoComicionistaInstance.Fields(CInt(TipoComicionistaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PlazaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="plazaInstance">PlazaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPlazaCollectionViaComicionista(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, plazaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, "Comicionista_")
			relations.Add(ComicionistaEntity.Relations.PlazaEntityUsingPlaza, "Comicionista_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PlazaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="plazaInstance">PlazaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPlazaCollectionViaComicionista(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, "Comicionista_")
			relations.Add(ComicionistaEntity.Relations.PlazaEntityUsingPlaza, "Comicionista_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingCatLugaresDeCompraCollectionViaProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catLugaresDeCompraInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catLugaresDeCompraInstance.Fields(CInt(CatLugaresDeCompraFieldIndex.IdLugarCompra)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingCatLugaresDeCompraCollectionViaProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catLugaresDeCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catLugaresDeCompraInstance.Fields(CInt(CatLugaresDeCompraFieldIndex.IdLugarCompra)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingCatLugaresDeCompraCollectionViaProveedor_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catLugaresDeCompraInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catLugaresDeCompraInstance.Fields(CInt(CatLugaresDeCompraFieldIndex.IdLugarCompra)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingCatLugaresDeCompraCollectionViaProveedor_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catLugaresDeCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catLugaresDeCompraInstance.Fields(CInt(CatLugaresDeCompraFieldIndex.IdLugarCompra)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingContDiotTiposOperacionCollectionViaProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, contDiotTiposOperacionInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(contDiotTiposOperacionInstance.Fields(CInt(ContDiotTiposOperacionFieldIndex.CodDiot)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingContDiotTiposOperacionCollectionViaProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, contDiotTiposOperacionInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(contDiotTiposOperacionInstance.Fields(CInt(ContDiotTiposOperacionFieldIndex.CodDiot)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingContDiotTiposOperacionCollectionViaProveedor_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, contDiotTiposOperacionInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(contDiotTiposOperacionInstance.Fields(CInt(ContDiotTiposOperacionFieldIndex.CodDiot)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingContDiotTiposOperacionCollectionViaProveedor_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, contDiotTiposOperacionInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(contDiotTiposOperacionInstance.Fields(CInt(ContDiotTiposOperacionFieldIndex.CodDiot)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingContDiotTiposTercerosCollectionViaProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, contDiotTiposTercerosInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(contDiotTiposTercerosInstance.Fields(CInt(ContDiotTiposTercerosFieldIndex.CodDiot)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingContDiotTiposTercerosCollectionViaProveedor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, contDiotTiposTercerosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(contDiotTiposTercerosInstance.Fields(CInt(ContDiotTiposTercerosFieldIndex.CodDiot)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingContDiotTiposTercerosCollectionViaProveedor_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, contDiotTiposTercerosInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(contDiotTiposTercerosInstance.Fields(CInt(ContDiotTiposTercerosFieldIndex.CodDiot)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingContDiotTiposTercerosCollectionViaProveedor_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, contDiotTiposTercerosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "Proveedor_")
			relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros, "Proveedor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(contDiotTiposTercerosInstance.Fields(CInt(ContDiotTiposTercerosFieldIndex.CodDiot)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatDeptosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catDeptosInstance">CatDeptosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatDeptosCollectionViaMfacCatClientes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catDeptosInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaContId, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.CatDeptosEntityUsingIdDepartamento, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catDeptosInstance.Fields(CInt(CatDeptosFieldIndex.CveDepto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatDeptosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catDeptosInstance">CatDeptosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatDeptosCollectionViaMfacCatClientes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catDeptosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaContId, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.CatDeptosEntityUsingIdDepartamento, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catDeptosInstance.Fields(CInt(CatDeptosFieldIndex.CveDepto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatDeptosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catDeptosInstance">CatDeptosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatDeptosCollectionViaMfacCatClientes_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catDeptosInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaAnticipoId, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.CatDeptosEntityUsingIdDepartamento, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catDeptosInstance.Fields(CInt(CatDeptosFieldIndex.CveDepto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatDeptosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catDeptosInstance">CatDeptosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatDeptosCollectionViaMfacCatClientes_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catDeptosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaAnticipoId, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.CatDeptosEntityUsingIdDepartamento, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catDeptosInstance.Fields(CInt(CatDeptosFieldIndex.CveDepto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatDeptosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catDeptosInstance">CatDeptosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatDeptosCollectionViaMfacCatClientes__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catDeptosInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingIdcuentaventa, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.CatDeptosEntityUsingIdDepartamento, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catDeptosInstance.Fields(CInt(CatDeptosFieldIndex.CveDepto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatDeptosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catDeptosInstance">CatDeptosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatDeptosCollectionViaMfacCatClientes__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catDeptosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingIdcuentaventa, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.CatDeptosEntityUsingIdDepartamento, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catDeptosInstance.Fields(CInt(CatDeptosFieldIndex.CveDepto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="comicionistaInstance">ComicionistaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingComicionistaCollectionViaMfacCatClientes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, comicionistaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaContId, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(comicionistaInstance.Fields(CInt(ComicionistaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="comicionistaInstance">ComicionistaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingComicionistaCollectionViaMfacCatClientes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, comicionistaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaContId, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(comicionistaInstance.Fields(CInt(ComicionistaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="comicionistaInstance">ComicionistaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingComicionistaCollectionViaMfacCatClientes_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, comicionistaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaAnticipoId, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(comicionistaInstance.Fields(CInt(ComicionistaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="comicionistaInstance">ComicionistaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingComicionistaCollectionViaMfacCatClientes_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, comicionistaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaAnticipoId, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(comicionistaInstance.Fields(CInt(ComicionistaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="comicionistaInstance">ComicionistaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingComicionistaCollectionViaMfacCatClientes__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, comicionistaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingIdcuentaventa, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(comicionistaInstance.Fields(CInt(ComicionistaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="comicionistaInstance">ComicionistaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingComicionistaCollectionViaMfacCatClientes__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, comicionistaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingIdcuentaventa, "MfacCatClientes_")
			relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, "MfacCatClientes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(comicionistaInstance.Fields(CInt(ComicionistaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PolizasModeloCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="polizasModeloCabInstance">PolizasModeloCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPolizasModeloCabCollectionViaPolizasModeloDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, polizasModeloCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.PolizasModeloDetEntityUsingIdCuentaContable, "PolizasModeloDet_")
			relations.Add(PolizasModeloDetEntity.Relations.PolizasModeloCabEntityUsingCodigo, "PolizasModeloDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(polizasModeloCabInstance.Fields(CInt(PolizasModeloCabFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in PolizasModeloCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="polizasModeloCabInstance">PolizasModeloCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingPolizasModeloCabCollectionViaPolizasModeloDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, polizasModeloCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.PolizasModeloDetEntityUsingIdCuentaContable, "PolizasModeloDet_")
			relations.Add(PolizasModeloDetEntity.Relations.PolizasModeloCabEntityUsingCodigo, "PolizasModeloDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(polizasModeloCabInstance.Fields(CInt(PolizasModeloCabFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingTipoMonedaCollectionViaCuenta(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, "Cuenta_")
			relations.Add(CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId, "Cuenta_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingTipoMonedaCollectionViaCuenta(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMonedaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, "Cuenta_")
			relations.Add(CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId, "Cuenta_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMonedaInstance.Fields(CInt(TipoMonedaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in BancosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="bancosInstance">BancosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingBancosCollectionViaCuenta(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, bancosInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, "Cuenta_")
			relations.Add(CuentaEntity.Relations.BancosEntityUsingBancoId, "Cuenta_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(bancosInstance.Fields(CInt(BancosFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in BancosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="bancosInstance">BancosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingBancosCollectionViaCuenta(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, bancosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, "Cuenta_")
			relations.Add(CuentaEntity.Relations.BancosEntityUsingBancoId, "Cuenta_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(bancosInstance.Fields(CInt(BancosFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ConceptoFlujoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="conceptoFlujoInstance">ConceptoFlujoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, conceptoFlujoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ConceptoFlujoCuentaEntityUsingCuentaContableId, "ConceptoFlujoCuenta_")
			relations.Add(ConceptoFlujoCuentaEntity.Relations.ConceptoFlujoEntityUsingConceptoFlujoId, "ConceptoFlujoCuenta_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(conceptoFlujoInstance.Fields(CInt(ConceptoFlujoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in ConceptoFlujoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="conceptoFlujoInstance">ConceptoFlujoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, conceptoFlujoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.ConceptoFlujoCuentaEntityUsingCuentaContableId, "ConceptoFlujoCuenta_")
			relations.Add(ConceptoFlujoCuentaEntity.Relations.ConceptoFlujoEntityUsingConceptoFlujoId, "ConceptoFlujoCuenta_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(conceptoFlujoInstance.Fields(CInt(ConceptoFlujoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingPolizaCollectionViaPolizaDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, polizaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.PolizaDetalleEntityUsingCuentaContableId, "PolizaDetalle_")
			relations.Add(PolizaDetalleEntity.Relations.PolizaEntityUsingPolizaId, "PolizaDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(polizaInstance.Fields(CInt(PolizaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
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
		Public Function GetMultiUsingPolizaCollectionViaPolizaDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, polizaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.PolizaDetalleEntityUsingCuentaContableId, "PolizaDetalle_")
			relations.Add(PolizaDetalleEntity.Relations.PolizaEntityUsingPolizaId, "PolizaDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(polizaInstance.Fields(CInt(PolizaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in UsrCxpfacturasCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="usrCxpfacturasCabInstance">UsrCxpfacturasCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, usrCxpfacturasCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.UsrCxpfacturasDetEntityUsingCuentaContableId, "UsrCxpfacturasDet_")
			relations.Add(UsrCxpfacturasDetEntity.Relations.UsrCxpfacturasCabEntityUsingEmpresaIdIdProveedorNoFactura, "UsrCxpfacturasDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(usrCxpfacturasCabInstance.Fields(CInt(UsrCxpfacturasCabFieldIndex.EmpresaId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(usrCxpfacturasCabInstance.Fields(CInt(UsrCxpfacturasCabFieldIndex.IdProveedor)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(usrCxpfacturasCabInstance.Fields(CInt(UsrCxpfacturasCabFieldIndex.NoFactura)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling CuentaContableCollection object all CuentaContableEntity objects
		''' which are related via a relation of type 'm:n' with the passed in UsrCxpfacturasCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="usrCxpfacturasCabInstance">UsrCxpfacturasCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, usrCxpfacturasCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim relations As  New RelationCollection()
			relations.Add(CuentaContableEntity.Relations.UsrCxpfacturasDetEntityUsingCuentaContableId, "UsrCxpfacturasDet_")
			relations.Add(UsrCxpfacturasDetEntity.Relations.UsrCxpfacturasCabEntityUsingEmpresaIdIdProveedorNoFactura, "UsrCxpfacturasDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(usrCxpfacturasCabInstance.Fields(CInt(UsrCxpfacturasCabFieldIndex.EmpresaId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(usrCxpfacturasCabInstance.Fields(CInt(UsrCxpfacturasCabFieldIndex.IdProveedor)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(usrCxpfacturasCabInstance.Fields(CInt(UsrCxpfacturasCabFieldIndex.NoFactura)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	

	
		''' <summary>
		''' Deletes from the persistent storage all 'CuentaContable' entities which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to delete</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to delete</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to delete</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMulti(containingTransaction As ITransaction, cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim deleteFilter As IPredicateExpression = CreateFilterUsingForeignKeys(cuentaEntradaInstance, cuentaSalidaInstance, cuentaPadreInstance, fields)
			Return MyBase.DeleteMulti(containingTransaction, deleteFilter)
		End Function

		''' <summary>
		''' Updates all entities of the same type or subtype of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		''' supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. Entities of a subtype of the type
		''' of <i>entityWithNewValues</i> which are affected by the filterBucket's filter will thus also be updated. 
		''' </summary>
		''' <param name="entityWithNewValues">IEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to update</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to update</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to update</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As IEntity, containingTransaction As ITransaction, cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
			Dim updateFilter As IPredicateExpression = CreateFilterUsingForeignKeys(cuentaEntradaInstance, cuentaSalidaInstance, cuentaPadreInstance, fields)
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
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects</param>
		''' <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the fieldset of the target entity.</param>
		''' <returns>A ready to use PredicateExpression based on the passed in foreign key value holders.</returns>
		Private Function CreateFilterUsingForeignKeys(cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity, fieldsToReturn As IEntityFields) As IPredicateExpression
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			
			If Not cuentaEntradaInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(CuentaContableFieldIndex.CtaEnt)), ComparisonOperator.Equal, CType(cuentaEntradaInstance, CuentaContableEntity).Codigo))
			End If
			If Not cuentaSalidaInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(CuentaContableFieldIndex.CtaSal)), ComparisonOperator.Equal, CType(cuentaSalidaInstance, CuentaContableEntity).Codigo))
			End If
			If Not cuentaPadreInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(CuentaContableFieldIndex.CtaPadre)), ComparisonOperator.Equal, CType(cuentaPadreInstance, CuentaContableEntity).Codigo))
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
