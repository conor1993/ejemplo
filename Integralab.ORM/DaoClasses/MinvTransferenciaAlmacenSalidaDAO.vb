' ///////////////////////////////////////////////////////////////
' This is generated code. If you modify this code, be aware
' of the fact that when you re-generate the code, your changes
' are lost. If you want to keep your changes, make this file read-only
' when you have finished your changes, however it is recommended that
' you inherit from this class to extend the functionality of this generated
' class or you modify / extend the templates used to generate this code.
' //////////////////////////////////////////////////////////////
' Code is generated using LLBLGen Pro version: 2.0.0.0
' Code is generated on: miércoles, 31 de enero de 2018 11:15:17
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
	''' General DAO class for the MinvTransferenciaAlmacenSalida Entity. It will perform database oriented actions for
	''' a entity of type 'MinvTransferenciaAlmacenSalidaEntity'. This DAO works on an EntityFields object. 
	''' </summary>
	Public Class MinvTransferenciaAlmacenSalidaDAO 
		Inherits DaoBase
		
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(InheritanceInfoProviderSingleton.GetInstance(), New DynamicQueryEngine(), InheritanceHierarchyType.None, "MinvTransferenciaAlmacenSalidaEntity", New MinvTransferenciaAlmacenSalidaEntityFactory())
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
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="almacenDestinoInstance">AlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to return</param>
		''' <param name="almacenOrigenInstance">AlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to return</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to return</param>
		''' <param name="inventarioMovimientoAlmacen_Instance">InventarioMovimientoAlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to return</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		Public Overloads Function GetMulti(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression, almacenDestinoInstance As IEntity, almacenOrigenInstance As IEntity, inventarioMovimientoAlmacenInstance As IEntity, inventarioMovimientoAlmacen_Instance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			MyBase.EntityFactoryToUse = entityFactoryToUse
			Dim fieldsToReturn  As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim selectFilter As IPredicateExpression= CreateFilterUsingForeignKeys(almacenDestinoInstance, almacenOrigenInstance, inventarioMovimientoAlmacenInstance, inventarioMovimientoAlmacen_Instance, fieldsToReturn)
			If Not Filter Is Nothing Then
				' add contents to select filter, with AND
				selectFilter.AddWithAnd(Filter)
			End If
			Return MyBase.PerformGetMultiAction(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, Nothing, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves entities of the type 'MinvTransferenciaAlmacenSalidaEntity' in a datatable which match the specified filter. It will always create a new connection to the database.
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Return MyBase.PerformGetMultiAsDataTableAction(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function

	
		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
		Public Function GetMultiUsingAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, almacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(almacenInstance.Fields(CInt(AlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
		Public Function GetMultiUsingAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As  New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(almacenInstance.Fields(CInt(AlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
		Public Function GetMultiUsingAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, almacenInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(almacenInstance.Fields(CInt(AlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
		Public Function GetMultiUsingAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As  New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(almacenInstance.Fields(CInt(AlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As  New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As  New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_")
			relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)), ComparisonOperator.Equal))
selectFilter.Add(New FieldCompareValuePredicate(inventarioMovimientoAlmacenInstance.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingFolioTransferencia, "MinvTransferenciaAlmacenSalidaDetalle_")
			relations.Add(MinvTransferenciaAlmacenSalidaDetalleEntity.Relations.ProductoEntityUsingIdProducto, "MinvTransferenciaAlmacenSalidaDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling MinvTransferenciaAlmacenSalidaCollection object all MinvTransferenciaAlmacenSalidaEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim relations As  New RelationCollection()
			relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingFolioTransferencia, "MinvTransferenciaAlmacenSalidaDetalle_")
			relations.Add(MinvTransferenciaAlmacenSalidaDetalleEntity.Relations.ProductoEntityUsingIdProducto, "MinvTransferenciaAlmacenSalidaDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	

	
		''' <summary>
		''' Deletes from the persistent storage all 'MinvTransferenciaAlmacenSalida' entities which have data in common
		''' with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="almacenDestinoInstance">AlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to delete</param>
		''' <param name="almacenOrigenInstance">AlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to delete</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to delete</param>
		''' <param name="inventarioMovimientoAlmacen_Instance">InventarioMovimientoAlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to delete</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMulti(containingTransaction As ITransaction, almacenDestinoInstance As IEntity, almacenOrigenInstance As IEntity, inventarioMovimientoAlmacenInstance As IEntity, inventarioMovimientoAlmacen_Instance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim deleteFilter As IPredicateExpression = CreateFilterUsingForeignKeys(almacenDestinoInstance, almacenOrigenInstance, inventarioMovimientoAlmacenInstance, inventarioMovimientoAlmacen_Instance, fields)
			Return MyBase.DeleteMulti(containingTransaction, deleteFilter)
		End Function

		''' <summary>
		''' Updates all entities of the same type or subtype of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		''' supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. Entities of a subtype of the type
		''' of <i>entityWithNewValues</i> which are affected by the filterBucket's filter will thus also be updated. 
		''' </summary>
		''' <param name="entityWithNewValues">IEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="almacenDestinoInstance">AlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to update</param>
		''' <param name="almacenOrigenInstance">AlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to update</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to update</param>
		''' <param name="inventarioMovimientoAlmacen_Instance">InventarioMovimientoAlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects to update</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As IEntity, containingTransaction As ITransaction, almacenDestinoInstance As IEntity, almacenOrigenInstance As IEntity, inventarioMovimientoAlmacenInstance As IEntity, inventarioMovimientoAlmacen_Instance As IEntity) As Integer
			Dim fields As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			Dim updateFilter As IPredicateExpression = CreateFilterUsingForeignKeys(almacenDestinoInstance, almacenOrigenInstance, inventarioMovimientoAlmacenInstance, inventarioMovimientoAlmacen_Instance, fields)
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
		''' <param name="almacenDestinoInstance">AlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects</param>
		''' <param name="almacenOrigenInstance">AlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects</param>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects</param>
		''' <param name="inventarioMovimientoAlmacen_Instance">InventarioMovimientoAlmacenEntity instance to use as a filter for the MinvTransferenciaAlmacenSalidaEntity objects</param>
		''' <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the fieldset of the target entity.</param>
		''' <returns>A ready to use PredicateExpression based on the passed in foreign key value holders.</returns>
		Private Function CreateFilterUsingForeignKeys(almacenDestinoInstance As IEntity, almacenOrigenInstance As IEntity, inventarioMovimientoAlmacenInstance As IEntity, inventarioMovimientoAlmacen_Instance As IEntity, fieldsToReturn As IEntityFields) As IPredicateExpression
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			
			If Not almacenDestinoInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenDestino)), ComparisonOperator.Equal, CType(almacenDestinoInstance, AlmacenEntity).AlmacenId))
			End If
			If Not almacenOrigenInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen)), ComparisonOperator.Equal, CType(almacenOrigenInstance, AlmacenEntity).AlmacenId))
			End If
			If Not inventarioMovimientoAlmacenInstance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen)), ComparisonOperator.Equal, CType(inventarioMovimientoAlmacenInstance, InventarioMovimientoAlmacenEntity).AlmacenId))
selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimiento)), ComparisonOperator.Equal, CType(inventarioMovimientoAlmacenInstance, InventarioMovimientoAlmacenEntity).FolioMovimiento))
			End If
			If Not inventarioMovimientoAlmacen_Instance Is Nothing Then
				selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen)), ComparisonOperator.Equal, CType(inventarioMovimientoAlmacen_Instance, InventarioMovimientoAlmacenEntity).AlmacenId))
selectFilter.Add(New FieldCompareValuePredicate(fieldsToReturn(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimientoCancelacion)), ComparisonOperator.Equal, CType(inventarioMovimientoAlmacen_Instance, InventarioMovimientoAlmacenEntity).FolioMovimiento))
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
