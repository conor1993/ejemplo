' ///////////////////////////////////////////////////////////////
' This is generated code. If you modify this code, be aware
' of the fact that when you re-generate the code, your changes
' are lost. If you want to keep your changes, make this file read-only
' when you have finished your changes, however it is recommended that
' you inherit from this class to extend the functionality of this generated
' class or you modify / extend the templates used to generate this code.
' //////////////////////////////////////////////////////////////
' Code is generated using LLBLGen Pro version: 2.0.0.0
' Code is generated on: jueves, 25 de enero de 2018 09:23:41
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
	''' General DAO class for the McgcatTiposdeGanado Entity. It will perform database oriented actions for
	''' a entity of type 'McgcatTiposdeGanadoEntity'. This DAO works on an EntityFields object. 
	''' </summary>
	Public Class McgcatTiposdeGanadoDAO 
		Inherits DaoBase
		
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(InheritanceInfoProviderSingleton.GetInstance(), New DynamicQueryEngine(), InheritanceHierarchyType.None, "McgcatTiposdeGanadoEntity", New McgcatTiposdeGanadoEntityFactory())
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
		''' Retrieves entities of the type 'McgcatTiposdeGanadoEntity' in a datatable which match the specified filter. It will always create a new connection to the database.
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
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Return MyBase.PerformGetMultiAsDataTableAction(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function

	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabFacturasEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabFacturasInstance">CabFacturasEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabFacturasCollectionViaDetFacturas(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabFacturasInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.DetFacturasEntityUsingCveGanado, "DetFacturas_")
			relations.Add(DetFacturasEntity.Relations.CabFacturasEntityUsingFolFactura, "DetFacturas_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabFacturasInstance.Fields(CInt(CabFacturasFieldIndex.FolFactura)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabFacturasEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabFacturasInstance">CabFacturasEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabFacturasCollectionViaDetFacturas(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabFacturasInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.DetFacturasEntityUsingCveGanado, "DetFacturas_")
			relations.Add(DetFacturasEntity.Relations.CabFacturasEntityUsingFolFactura, "DetFacturas_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabFacturasInstance.Fields(CInt(CabFacturasFieldIndex.FolFactura)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
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
		Public Function GetMultiUsingCabMovGanCollectionViaDetMovGan(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabMovGanInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.DetMovGanEntityUsingCveGanado, "DetMovGan_")
			relations.Add(DetMovGanEntity.Relations.CabMovGanEntityUsingFolMovGan, "DetMovGan_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabMovGanInstance.Fields(CInt(CabMovGanFieldIndex.FolMovGan)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
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
		Public Function GetMultiUsingCabMovGanCollectionViaDetMovGan(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabMovGanInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.DetMovGanEntityUsingCveGanado, "DetMovGan_")
			relations.Add(DetMovGanEntity.Relations.CabMovGanEntityUsingFolMovGan, "DetMovGan_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabMovGanInstance.Fields(CInt(CabMovGanFieldIndex.FolMovGan)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabRegComEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabRegComInstance">CabRegComEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabRegComCollectionViaDetRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabRegComInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.DetRegComEntityUsingCveGanado, "DetRegCom_")
			relations.Add(DetRegComEntity.Relations.CabRegComEntityUsingFolRecep, "DetRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabRegComInstance.Fields(CInt(CabRegComFieldIndex.FolRecep)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in CabRegComEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="cabRegComInstance">CabRegComEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingCabRegComCollectionViaDetRegCom(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, cabRegComInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.DetRegComEntityUsingCveGanado, "DetRegCom_")
			relations.Add(DetRegComEntity.Relations.CabRegComEntityUsingFolRecep, "DetRegCom_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(cabRegComInstance.Fields(CInt(CabRegComFieldIndex.FolRecep)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
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
		Public Function GetMultiUsingMcecatCorralesCabCollectionViaMcecatCorralesDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatCorralesCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.McecatCorralesDetEntityUsingIdTipoGanado, "McecatCorralesDet_")
			relations.Add(McecatCorralesDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "McecatCorralesDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatCorralesCabInstance.Fields(CInt(McecatCorralesCabFieldIndex.IdCorral)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
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
		Public Function GetMultiUsingMcecatCorralesCabCollectionViaMcecatCorralesDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.McecatCorralesDetEntityUsingIdTipoGanado, "McecatCorralesDet_")
			relations.Add(McecatCorralesDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "McecatCorralesDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatCorralesCabInstance.Fields(CInt(McecatCorralesCabFieldIndex.IdCorral)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcecatLotesCabCollectionViaMcecatLotesDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatLotesCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.McecatLotesDetEntityUsingIdTipoGanado, "McecatLotesDet_")
			relations.Add(McecatLotesDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "McecatLotesDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatLotesCabInstance.Fields(CInt(McecatLotesCabFieldIndex.IdLote)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcecatLotesCabCollectionViaMcecatLotesDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.McecatLotesDetEntityUsingIdTipoGanado, "McecatLotesDet_")
			relations.Add(McecatLotesDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "McecatLotesDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatLotesCabInstance.Fields(CInt(McecatLotesCabFieldIndex.IdLote)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcecatLotesCabCollectionViaSalidaGanadoDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatLotesCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "SalidaGanadoDet_")
			relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "SalidaGanadoDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatLotesCabInstance.Fields(CInt(McecatLotesCabFieldIndex.IdLote)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcecatLotesCabCollectionViaSalidaGanadoDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "SalidaGanadoDet_")
			relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "SalidaGanadoDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatLotesCabInstance.Fields(CInt(McecatLotesCabFieldIndex.IdLote)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcecatLotesDetCollectionViaSalidaGanadoDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatLotesDetInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "SalidaGanadoDet_")
			relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesDetEntityUsingIdMcecatLotesDet, "SalidaGanadoDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatLotesDetInstance.Fields(CInt(McecatLotesDetFieldIndex.IdMcecatLotesDet)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMcecatLotesDetCollectionViaSalidaGanadoDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, mcecatLotesDetInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "SalidaGanadoDet_")
			relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesDetEntityUsingIdMcecatLotesDet, "SalidaGanadoDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(mcecatLotesDetInstance.Fields(CInt(McecatLotesDetFieldIndex.IdMcecatLotesDet)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, salidaGanadoCabInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "SalidaGanadoDet_")
			relations.Add(SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab, "SalidaGanadoDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(salidaGanadoCabInstance.Fields(CInt(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, salidaGanadoCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "SalidaGanadoDet_")
			relations.Add(SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab, "SalidaGanadoDet_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(salidaGanadoCabInstance.Fields(CInt(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaUsrProdRecepcionDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "UsrProdRecepcionDetalle_")
			relations.Add(UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
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
		Public Function GetMultiUsingProductoCollectionViaUsrProdRecepcionDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "UsrProdRecepcionDetalle_")
			relations.Add(UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(productoInstance.Fields(CInt(ProductoFieldIndex.Codigo)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="msccatProductosInstance">MsccatProductosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMsccatProductosCollectionViaUsrProdRecepcionDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, msccatProductosInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "UsrProdRecepcionDetalle_")
			relations.Add(UsrProdRecepcionDetalleEntity.Relations.MsccatProductosEntityUsingIdProducto, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(msccatProductosInstance.Fields(CInt(MsccatProductosFieldIndex.IdProducto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="msccatProductosInstance">MsccatProductosEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingMsccatProductosCollectionViaUsrProdRecepcionDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, msccatProductosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "UsrProdRecepcionDetalle_")
			relations.Add(UsrProdRecepcionDetalleEntity.Relations.MsccatProductosEntityUsingIdProducto, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(msccatProductosInstance.Fields(CInt(MsccatProductosFieldIndex.IdProducto)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
		End Function
	
		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in RecepcionGanadoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="recepcionGanadoInstance">RecepcionGanadoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, recepcionGanadoInstance As IEntity, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "UsrProdRecepcionDetalle_")
			relations.Add(UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(recepcionGanadoInstance.Fields(CInt(RecepcionGanadoFieldIndex.LoteRecepcion)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, pageNumber, pageSize)
		End Function

		''' <summary>
		''' Retrieves in the calling McgcatTiposdeGanadoCollection object all McgcatTiposdeGanadoEntity objects
		''' which are related via a relation of type 'm:n' with the passed in RecepcionGanadoEntity. 
		''' </summary>
		''' <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or Nothing if not.</param>
		''' <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		''' <param name="recepcionGanadoInstance">RecepcionGanadoEntity object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(containingTransaction As ITransaction, collectionToFill As IEntityCollection, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, entityFactoryToUse As IEntityFactory, recepcionGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Dim fieldsToReturn As IEntityFields = EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
			Dim relations As  New RelationCollection()
			relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "UsrProdRecepcionDetalle_")
			relations.Add(UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
			Dim selectFilter As IPredicateExpression = New PredicateExpression()
			selectFilter.Add(New FieldCompareValuePredicate(recepcionGanadoInstance.Fields(CInt(RecepcionGanadoFieldIndex.LoteRecepcion)), ComparisonOperator.Equal))
			Return GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse)
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



#Region "Custom DAO code"
		
		' __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		' __LLBLGENPRO_USER_CODE_REGION_END
#End Region
		
#Region "Included Code"

#End Region

	End Class
End Namespace
