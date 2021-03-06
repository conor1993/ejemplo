﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:42:56
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.Data
Imports System.Data.Common

Imports Integralab.ORM.HelperClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports SD.LLBLGen.Pro.DQE.SqlServer


Namespace Integralab.ORM.DaoClasses
	''' <summary>Generic DAO class for usage with Typed list classes.</summary>
	Public Class TypedListDAO 
		Inherits DaoBase
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(InheritanceInfoProviderSingleton.GetInstance(), New DynamicQueryEngine(), InheritanceHierarchyType.None, String.Empty, Nothing)
		End Sub

		''' <summary>
		''' Retrieves rows in the datatable provided which match the specified filter, containing the fields specified. It will always create a new connection to the database.
		''' </summary>
		''' <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the resultset to return.</param>
		''' <param name="tableToFill">The datatable to fill with the rows retrieved</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		''' If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. When set to 0, no limitations are specified.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows or not</param>
		''' <param name="groupByClause">The list of fields to group by on. When not specified or an empty collection is specified, no group by clause
		''' is added to the query. A check is performed for each field in the selectList. If a field in the selectList is not present in the groupByClause collection, an exception is thrown.</param>
		''' <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Function GetMultiAsDataTable(fieldsToReturn As IEntityFields, tableToFill As DataTable, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, selectFilter As IPredicate, relations As IRelationCollection, allowDuplicates As Boolean, groupByClause As IGroupByCollection, transactionToUse As  ITransaction, pageNumber As Integer, pageSize As Integer) As Boolean
			Return MyBase.PerformGetMultiAsDataTableAction(fieldsToReturn, tableToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, allowDuplicates, groupByClause, transactionToUse, pageNumber, pageSize)
		End Function

		''' <summary>Determines the connection To use. If transaction To use Is null, a New connection Is created, otherwise the connection of the transaction Is used.</summary>
		''' <param name="transactionToUse">Transaction To use.</param>
		''' <returns>a ready To use connection Object.</returns>
		Protected Overrides Function DetermineConnectionToUse(transactionToUse As ITransaction) As IDbConnection
			Return DbUtils.DetermineConnectionToUse(transactionToUse)
		End Function
		
		''' <summary>Creates a New ADO.NET data adapter.</summary>
		''' <returns>ready To use ADO.NET data-adapter</returns>
		Protected Overrides Function CreateDataAdapter() As DbDataAdapter
			Return DbUtils.CreateDataAdapter()
		End Function

#Region "Included Code"

#End Region
	End Class
End Namespace
