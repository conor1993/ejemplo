' ///////////////////////////////////////////////////////////////
' This is generated code. If you modify this code, be aware
' of the fact that when you re-generate the code, your changes
' are lost. If you want to keep your changes, make this file read-only
' when you have finished your changes, however it is recommended that
' you inherit from this class to extend the functionality of this generated
' class or you modify / extend the templates used to generate this code.
' //////////////////////////////////////////////////////////////
' Code is generated using LLBLGen Pro version: 2.0.0.0
' Code is generated on: viernes, 2 de marzo de 2018 10:17:25
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
	''' General DAO class for the Almacen Entity. It will perform database oriented actions for
	''' a entity of type 'AlmacenEntity'. This DAO works on an EntityFields object. 
	''' </summary>
	Public Class AlmacenDAO 
		Inherits DaoBase
		
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(InheritanceInfoProviderSingleton.GetInstance(), New DynamicQueryEngine(), InheritanceHierarchyType.None, "AlmacenEntity", New AlmacenEntityFactory())
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
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects to return</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects to return</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects to return</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects to return</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		Public Overloads Function GetMulti(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression, plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			MyBase.EntityFactoryToUse = entityFactoryToUse
			Dim fieldsToReturn  As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim selectFilter As IPredicateExpression= CreateFilterUsingForeignKeys(plaza_Instance, almacen_Instance, tipoAlmacen_Instance, cuentaContableInstance, fieldsToReturn)
			If Not Filter Is Nothing Then
				' add contents to select filter, with AND
				selectFilter.AddWithAnd(Filter)
			End If
			Return MyBase.PerformGetMultiAction(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, Nothing, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves entities of the type 'AlmacenEntity' in a datatable which match the specified filter. It will always create a new connection to the database.
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Return MyBase.PerformGetMultiAsDataTableAction(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function

	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in LineaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="lineaInstance">LineaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingLineaCollectionViaAlmacenesFamilias(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, lineaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AlmacenesFamiliasEntityUsingCodigoAlmacen, "AlmacenesFamilias_")
			relations.Add(AlmacenesFamiliasEntity.Relations.LineaEntityUsingCodigoLinea, "AlmacenesFamilias_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(lineaInstance.Fields(CInt(LineaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in LineaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="lineaInstance">LineaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingLineaCollectionViaAlmacenesFamilias(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, lineaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AlmacenesFamiliasEntityUsingCodigoAlmacen, "AlmacenesFamilias_")
			relations.Add(AlmacenesFamiliasEntity.Relations.LineaEntityUsingCodigoLinea, "AlmacenesFamilias_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(lineaInstance.Fields(CInt(LineaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, "AplicMedi_")
			relations.Add(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, "AplicMedi_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, "AplicMedi_")
			relations.Add(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, "AplicMedi_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, "AplicMedi_")
			relations.Add(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "AplicMedi_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, "AplicMedi_")
			relations.Add(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "AplicMedi_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, "CabAplFor_")
			relations.Add(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, "CabAplFor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, "CabAplFor_")
			relations.Add(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, "CabAplFor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, "CabAplFor_")
			relations.Add(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "CabAplFor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, "CabAplFor_")
			relations.Add(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "CabAplFor_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaCabPrepForm(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaCabPrepForm(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaCabPrepForm_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaCabPrepForm_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingPlazaCollectionViaCabPrepForm(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, plazaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingPlazaCollectionViaCabPrepForm(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "CabPrepForm_")
			relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabProMed(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabProMedEntityUsingIdAlmacen, "CabProMed_")
			relations.Add(CabProMedEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, "CabProMed_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabProMed(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.CabProMedEntityUsingIdAlmacen, "CabProMed_")
			relations.Add(CabProMedEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, "CabProMed_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaInvHistorialPv(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InvHistorialPvEntityUsingIdAlmacen, "InvHistorialPv_")
			relations.Add(InvHistorialPvEntity.Relations.ProductoEntityUsingIdProducto, "InvHistorialPv_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaInvHistorialPv(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InvHistorialPvEntityUsingIdAlmacen, "InvHistorialPv_")
			relations.Add(InvHistorialPvEntity.Relations.ProductoEntityUsingIdProducto, "InvHistorialPv_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_")
			relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_")
			relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(plazaInstance.Fields(CInt(PlazaFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_")
			relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoAlmacenInstance.Fields(CInt(TipoAlmacenFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_")
			relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoAlmacenInstance.Fields(CInt(TipoAlmacenFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCuentaContableCollectionViaAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cuentaContableInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_")
			relations.Add(AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cuentaContableInstance.Fields(CInt(CuentaContableFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCuentaContableCollectionViaAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cuentaContableInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_")
			relations.Add(AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable, "Almacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cuentaContableInstance.Fields(CInt(CuentaContableFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, motivoCancelacionInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, "RecepcionOrdenCompra_")
			relations.Add(RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(motivoCancelacionInstance.Fields(CInt(MotivoCancelacionFieldIndex.IdMotivo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, motivoCancelacionInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, "RecepcionOrdenCompra_")
			relations.Add(RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(motivoCancelacionInstance.Fields(CInt(MotivoCancelacionFieldIndex.IdMotivo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="ordenCompraInstance">OrdenCompraEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingOrdenCompraCollectionViaRecepcionOrdenCompra(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, ordenCompraInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, "RecepcionOrdenCompra_")
			relations.Add(RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(ordenCompraInstance.Fields(CInt(OrdenCompraFieldIndex.IdOrdenCompra)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="ordenCompraInstance">OrdenCompraEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingOrdenCompraCollectionViaRecepcionOrdenCompra(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, ordenCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, "RecepcionOrdenCompra_")
			relations.Add(RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(ordenCompraInstance.Fields(CInt(OrdenCompraFieldIndex.IdOrdenCompra)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaInventarioAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioAlmacenEntityUsingAlmacenId, "InventarioAlmacen_")
			relations.Add(InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId, "InventarioAlmacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaInventarioAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioAlmacenEntityUsingAlmacenId, "InventarioAlmacen_")
			relations.Add(InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId, "InventarioAlmacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViainventarioAlmacenLotes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, "inventarioAlmacenLotes_")
			relations.Add(inventarioAlmacenLotesEntity.Relations.ProductoEntityUsingProductoId, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViainventarioAlmacenLotes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, "inventarioAlmacenLotes_")
			relations.Add(inventarioAlmacenLotesEntity.Relations.ProductoEntityUsingProductoId, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, "inventarioAlmacenLotes_")
			relations.Add(inventarioAlmacenLotesEntity.Relations.InventarioAlmacenEntityUsingAlmacenIdProductoIdAñoMes, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioAlmacenInstance.Fields(CInt(InventarioAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioAlmacenInstance.Fields(CInt(InventarioAlmacenFieldIndex.ProductoId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioAlmacenInstance.Fields(CInt(InventarioAlmacenFieldIndex.Año)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioAlmacenInstance.Fields(CInt(InventarioAlmacenFieldIndex.Mes)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, "inventarioAlmacenLotes_")
			relations.Add(inventarioAlmacenLotesEntity.Relations.InventarioAlmacenEntityUsingAlmacenIdProductoIdAñoMes, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioAlmacenInstance.Fields(CInt(InventarioAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioAlmacenInstance.Fields(CInt(InventarioAlmacenFieldIndex.ProductoId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioAlmacenInstance.Fields(CInt(InventarioAlmacenFieldIndex.Año)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioAlmacenInstance.Fields(CInt(InventarioAlmacenFieldIndex.Mes)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenId, "InventarioMovimientoAlmacen_")
			relations.Add(InventarioMovimientoAlmacenEntity.Relations.TipoMovimientoAlmacenEntityUsingTipoMovimientoId, "InventarioMovimientoAlmacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMovimientoAlmacenInstance.Fields(CInt(TipoMovimientoAlmacenFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenId, "InventarioMovimientoAlmacen_")
			relations.Add(InventarioMovimientoAlmacenEntity.Relations.TipoMovimientoAlmacenEntityUsingTipoMovimientoId, "InventarioMovimientoAlmacen_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMovimientoAlmacenInstance.Fields(CInt(TipoMovimientoAlmacenFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, "InventarioMovimientoAlmacenDetalles_")
			relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.ProductoEntityUsingProductoId, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, "InventarioMovimientoAlmacenDetalles_")
			relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.ProductoEntityUsingProductoId, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, "InventarioMovimientoAlmacenDetalles_")
			relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenIdFolioMovimiento, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, "InventarioMovimientoAlmacenDetalles_")
			relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenIdFolioMovimiento, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatMovimientosAlmacenPvEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catMovimientosAlmacenPvInstance">CatMovimientosAlmacenPvEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catMovimientosAlmacenPvInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenId, "MinvMovimientosAlmacenPv_")
			relations.Add(MinvMovimientosAlmacenPvEntity.Relations.CatMovimientosAlmacenPvEntityUsingTipoMovimientoId, "MinvMovimientosAlmacenPv_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catMovimientosAlmacenPvInstance.Fields(CInt(CatMovimientosAlmacenPvFieldIndex.IdMov)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CatMovimientosAlmacenPvEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="catMovimientosAlmacenPvInstance">CatMovimientosAlmacenPvEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, catMovimientosAlmacenPvInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenId, "MinvMovimientosAlmacenPv_")
			relations.Add(MinvMovimientosAlmacenPvEntity.Relations.CatMovimientosAlmacenPvEntityUsingTipoMovimientoId, "MinvMovimientosAlmacenPv_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(catMovimientosAlmacenPvInstance.Fields(CInt(CatMovimientosAlmacenPvFieldIndex.IdMov)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, "MinvMovimientosAlmacenPvdetalles_")
			relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, "MinvMovimientosAlmacenPvdetalles_")
			relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, minvMovimientosAlmacenPvInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, "MinvMovimientosAlmacenPvdetalles_")
			relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(minvMovimientosAlmacenPvInstance.Fields(CInt(MinvMovimientosAlmacenPvFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(minvMovimientosAlmacenPvInstance.Fields(CInt(MinvMovimientosAlmacenPvFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, minvMovimientosAlmacenPvInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, "MinvMovimientosAlmacenPvdetalles_")
			relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(minvMovimientosAlmacenPvInstance.Fields(CInt(MinvMovimientosAlmacenPvFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(minvMovimientosAlmacenPvInstance.Fields(CInt(MinvMovimientosAlmacenPvFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, minvTransferenciaAlmacenSalidaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(minvTransferenciaAlmacenSalidaInstance.Fields(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, minvTransferenciaAlmacenSalidaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(minvTransferenciaAlmacenSalidaInstance.Fields(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, minvTransferenciaAlmacenSalidaInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(minvTransferenciaAlmacenSalidaInstance.Fields(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, minvTransferenciaAlmacenSalidaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(minvTransferenciaAlmacenSalidaInstance.Fields(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MinvTransferenciaAlmacenProdEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="minvTransferenciaAlmacenProdInstance">MinvTransferenciaAlmacenProdEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, minvTransferenciaAlmacenProdInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenProdDetalleEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenProdDetalle_")
			relations.Add(MinvTransferenciaAlmacenProdDetalleEntity.Relations.MinvTransferenciaAlmacenProdEntityUsingFolioTransferencia, "MinvTransferenciaAlmacenProdDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(minvTransferenciaAlmacenProdInstance.Fields(CInt(MinvTransferenciaAlmacenProdFieldIndex.FolioTransferencia)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MinvTransferenciaAlmacenProdEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="minvTransferenciaAlmacenProdInstance">MinvTransferenciaAlmacenProdEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, minvTransferenciaAlmacenProdInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenProdDetalleEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenProdDetalle_")
			relations.Add(MinvTransferenciaAlmacenProdDetalleEntity.Relations.MinvTransferenciaAlmacenProdEntityUsingFolioTransferencia, "MinvTransferenciaAlmacenProdDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(minvTransferenciaAlmacenProdInstance.Fields(CInt(MinvTransferenciaAlmacenProdFieldIndex.FolioTransferencia)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenSalida_")
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenSalida_")
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenSalida_")
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenSalida_")
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenSalida_")
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenSalida_")
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenSalida_")
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenSalida_")
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMovimientoAlmacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodAlmacen, "MscmovtosAlmacenCab_")
			relations.Add(MscmovtosAlmacenCabEntity.Relations.TipoMovimientoAlmacenEntityUsingIdCodMovimiento, "MscmovtosAlmacenCab_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMovimientoAlmacenInstance.Fields(CInt(TipoMovimientoAlmacenFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, tipoMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodAlmacen, "MscmovtosAlmacenCab_")
			relations.Add(MscmovtosAlmacenCabEntity.Relations.TipoMovimientoAlmacenEntityUsingIdCodMovimiento, "MscmovtosAlmacenCab_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(tipoMovimientoAlmacenInstance.Fields(CInt(TipoMovimientoAlmacenFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaUsrAlmInvFisico(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioFisicoEntityUsingAlmacenId, "InventarioFisico_")
			relations.Add(InventarioFisicoEntity.Relations.ProductoEntityUsingProductoId, "InventarioFisico_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaUsrAlmInvFisico(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.InventarioFisicoEntityUsingAlmacenId, "InventarioFisico_")
			relations.Add(InventarioFisicoEntity.Relations.ProductoEntityUsingProductoId, "InventarioFisico_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mscmovtosAlmacenCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, "RegistroSacrificiosDecomisos_")
			relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen, "RegistroSacrificiosDecomisos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mscmovtosAlmacenCabInstance.Fields(CInt(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mscmovtosAlmacenCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, "RegistroSacrificiosDecomisos_")
			relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen, "RegistroSacrificiosDecomisos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mscmovtosAlmacenCabInstance.Fields(CInt(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mscmovtosAlmacenCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As New RelationCollection()
			relations.Add(AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, "RegistroSacrificiosDecomisos_")
			relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen, "RegistroSacrificiosDecomisos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mscmovtosAlmacenCabInstance.Fields(CInt(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling AlmacenCollection object all AlmacenEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mscmovtosAlmacenCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim relations As  New RelationCollection()
			relations.Add(AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, "RegistroSacrificiosDecomisos_")
			relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen, "RegistroSacrificiosDecomisos_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mscmovtosAlmacenCabInstance.Fields(CInt(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	

	
		''' <summary>
		''' Deletes from the persistent storage all 'Almacen' entities which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects to delete</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects to delete</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects to delete</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects to delete</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMulti(containingTransaction As ITransaction, plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim deleteFilter As IPredicateExpression = CreateFilterUsingForeignKeys(plaza_Instance, almacen_Instance, tipoAlmacen_Instance, cuentaContableInstance, fields)
			Return MyBase.DeleteMulti(containingTransaction, deleteFilter)
		End Function

		''' <summary>
		''' Updates all entities of the same type or subtype of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		''' supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. Entities of a subtype of the type
		''' of <i>entityWithNewValues</i> which are affected by the filterBucket's filter will thus also be updated. 
		''' </summary>
		''' <param name="entityWithNewValues">IEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects to update</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects to update</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects to update</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects to update</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As IEntity, containingTransaction As ITransaction, plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
			Dim updateFilter As IPredicateExpression = CreateFilterUsingForeignKeys(plaza_Instance, almacen_Instance, tipoAlmacen_Instance, cuentaContableInstance, fields)
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
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects</param>
		''' <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the fieldset of the target entity.</param>
		''' <returns>A ready to use PredicateExpression based on the passed in foreign key value holders.</returns>
		Private Function CreateFilterUsingForeignKeys(plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity, fieldsToReturn As IEntityFields) As IPredicateExpression
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			
			If Not plaza_Instance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(AlmacenFieldIndex.Plaza)), ComparisonOperator.Equal, CType(plaza_Instance, PlazaEntity).Codigo))
			End If
			If Not almacen_Instance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(AlmacenFieldIndex.Almacen)), ComparisonOperator.Equal, CType(almacen_Instance, AlmacenEntity).AlmacenId))
			End If
			If Not tipoAlmacen_Instance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(AlmacenFieldIndex.TipoAlmacen)), ComparisonOperator.Equal, CType(tipoAlmacen_Instance, TipoAlmacenEntity).Codigo))
			End If
			If Not cuentaContableInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(AlmacenFieldIndex.IdCuentaContable)), ComparisonOperator.Equal, CType(cuentaContableInstance, CuentaContableEntity).Codigo))
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
