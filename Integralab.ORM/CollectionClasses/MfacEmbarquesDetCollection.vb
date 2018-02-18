﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 11:55:33
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.Data
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Xml
#If Not CF Then
Imports System.Runtime.Serialization
#End If

Imports Integralab.ORM.EntityClasses
Imports Integralab.ORM.FactoryClasses
Imports Integralab.ORM.DaoClasses
Imports Integralab.ORM.HelperClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses

' __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
' __LLBLGENPRO_USER_CODE_REGION_END
Namespace Integralab.ORM.CollectionClasses
	''' <summary>
	''' Collection class for storing and retrieving collections of MfacEmbarquesDetEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MfacEmbarquesDetCollection 
#Else
	<Serializable()> _
	Public Class MfacEmbarquesDetCollection 
#End If
		Inherits EntityCollectionBase(Of MfacEmbarquesDetEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New MfacEmbarquesDetEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of MfacEmbarquesDetEntity))
			MyBase.New(initialContents)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		Public Sub New(entityFactoryToUse As IEntityFactory)
			MyBase.New(entityFactoryToUse)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
		End Sub

	
		''' <summary>Retrieves in this MfacEmbarquesDetCollection Object all MfacEmbarquesDetEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mfacEmbarquesCabInstance">MfacEmbarquesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="msccatProductosInstance">MsccatProductosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(facturasClientesCabInstance As IEntity, mfacEmbarquesCabInstance As IEntity, msccatProductosInstance As IEntity, mscmovtosAlmacenCabInstance As IEntity, registroSacrificiosDecomisosInstance As IEntity) As Boolean
			Return GetMultiManyToOne(facturasClientesCabInstance, mfacEmbarquesCabInstance, msccatProductosInstance, mscmovtosAlmacenCabInstance, registroSacrificiosDecomisosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesDetCollection Object all MfacEmbarquesDetEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mfacEmbarquesCabInstance">MfacEmbarquesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="msccatProductosInstance">MsccatProductosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(facturasClientesCabInstance As IEntity, mfacEmbarquesCabInstance As IEntity, msccatProductosInstance As IEntity, mscmovtosAlmacenCabInstance As IEntity, registroSacrificiosDecomisosInstance As IEntity, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(facturasClientesCabInstance, mfacEmbarquesCabInstance, msccatProductosInstance, mscmovtosAlmacenCabInstance, registroSacrificiosDecomisosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesDetCollection Object all MfacEmbarquesDetEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mfacEmbarquesCabInstance">MfacEmbarquesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="msccatProductosInstance">MsccatProductosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(facturasClientesCabInstance As IEntity, mfacEmbarquesCabInstance As IEntity, msccatProductosInstance As IEntity, mscmovtosAlmacenCabInstance As IEntity, registroSacrificiosDecomisosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(facturasClientesCabInstance, mfacEmbarquesCabInstance, msccatProductosInstance, mscmovtosAlmacenCabInstance, registroSacrificiosDecomisosInstance, maxNumberOfItemsToReturn, sortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesDetCollection Object all MfacEmbarquesDetEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mfacEmbarquesCabInstance">MfacEmbarquesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="msccatProductosInstance">MsccatProductosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Overridable Function GetMultiManyToOne(facturasClientesCabInstance As IEntity, mfacEmbarquesCabInstance As IEntity, msccatProductosInstance As IEntity, mscmovtosAlmacenCabInstance As IEntity, registroSacrificiosDecomisosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim validParameters As Boolean = False
			validParameters = validParameters Or Not (facturasClientesCabInstance Is Nothing)
			validParameters = validParameters Or Not (mfacEmbarquesCabInstance Is Nothing)
			validParameters = validParameters Or Not (msccatProductosInstance Is Nothing)
			validParameters = validParameters Or Not (mscmovtosAlmacenCabInstance Is Nothing)
			validParameters = validParameters Or Not (registroSacrificiosDecomisosInstance Is Nothing)
			If Not validParameters Then
				Return GetMulti(Filter, maxNumberOfItemsToReturn, sortClauses, Nothing, pageNumber, pageSize)
			End If
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If
			Dim dao As MfacEmbarquesDetDAO = DAOFactory.CreateMfacEmbarquesDetDAO()
			Return dao.GetMulti(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, Filter, facturasClientesCabInstance, mfacEmbarquesCabInstance, msccatProductosInstance, mscmovtosAlmacenCabInstance, registroSacrificiosDecomisosInstance, pageNumber, pageSize)
		End Function

		''' <summary>Deletes from the persistent storage all MfacEmbarquesDet entities which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.</summary>
		''' <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mfacEmbarquesCabInstance">MfacEmbarquesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="msccatProductosInstance">MsccatProductosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMultiManyToOne(facturasClientesCabInstance As IEntity, mfacEmbarquesCabInstance As IEntity, msccatProductosInstance As IEntity, mscmovtosAlmacenCabInstance As IEntity, registroSacrificiosDecomisosInstance As IEntity) As Integer
			Dim dao As MfacEmbarquesDetDAO = DAOFactory.CreateMfacEmbarquesDetDAO()
			Return dao.DeleteMulti(MyBase.Transaction, facturasClientesCabInstance, mfacEmbarquesCabInstance, msccatProductosInstance, mscmovtosAlmacenCabInstance, registroSacrificiosDecomisosInstance)
		End Function


		''' <summary>Updates in the persistent storage all MfacEmbarquesDet entities which have data in common with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.
		''' Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">MfacEmbarquesDetEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mfacEmbarquesCabInstance">MfacEmbarquesCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="msccatProductosInstance">MsccatProductosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity instance to use as a filter for the MfacEmbarquesDetEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMultiManyToOne(entityWithNewValues As MfacEmbarquesDetEntity, facturasClientesCabInstance As IEntity, mfacEmbarquesCabInstance As IEntity, msccatProductosInstance As IEntity, mscmovtosAlmacenCabInstance As IEntity, registroSacrificiosDecomisosInstance As IEntity) As Integer
			Dim dao As MfacEmbarquesDetDAO = DAOFactory.CreateMfacEmbarquesDetDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, facturasClientesCabInstance, mfacEmbarquesCabInstance, msccatProductosInstance, mscmovtosAlmacenCabInstance, registroSacrificiosDecomisosInstance)
		End Function
	
	

		''' <summary>Retrieves MfacEmbarquesDetEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves MfacEmbarquesDetEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves MfacEmbarquesDetEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As MfacEmbarquesDetDAO = DAOFactory.CreateMfacEmbarquesDetDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all MfacEmbarquesDet entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all MfacEmbarquesDet entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As MfacEmbarquesDetDAO = DAOFactory.CreateMfacEmbarquesDetDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all MfacEmbarquesDet entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As MfacEmbarquesDetDAO = DAOFactory.CreateMfacEmbarquesDetDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MfacEmbarquesDetFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MfacEmbarquesDetFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MfacEmbarquesDetFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MfacEmbarquesDetFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, groupByClause)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="relations">The relations to walk</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Overridable Function GetScalar(fieldIndex As MfacEmbarquesDetFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As MfacEmbarquesDetDAO = DAOFactory.CreateMfacEmbarquesDetDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified MfacEmbarquesDetEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">MfacEmbarquesDetEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all MfacEmbarquesDet entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As MfacEmbarquesDetEntity, updateFilter As IPredicate) As Integer
			Dim dao As MfacEmbarquesDetDAO = DAOFactory.CreateMfacEmbarquesDetDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified MfacEmbarquesDetEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">MfacEmbarquesDetEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As MfacEmbarquesDetEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As MfacEmbarquesDetDAO = DAOFactory.CreateMfacEmbarquesDetDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMfacEmbarquesDetDAO()
		End Function
		
		''' <summary>Creates a New transaction Object</summary>
		''' <param name="levelOfIsolation">The level of isolation.</param>
		''' <param name="name">The name.</param>
		Protected Overrides Overloads Function CreateTransaction( levelOfIsolation As IsolationLevel, name As String) As ITransaction 
			Return New Transaction(levelOfIsolation, name)
		End Function


#Region "Custom EntityCollection code"
		
		' __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCollectionCode
		' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

#Region "Included Code"

#End Region
	End Class
End Namespace
