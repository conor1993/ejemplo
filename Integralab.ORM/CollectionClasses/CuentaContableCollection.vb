' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 8 de febrero de 2018 12:25:12
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
	''' Collection class for storing and retrieving collections of CuentaContableEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CuentaContableCollection 
#Else
	<Serializable()> _
	Public Class CuentaContableCollection 
#End If
		Inherits EntityCollectionBase(Of CuentaContableEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New CuentaContableEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of CuentaContableEntity))
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

	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity) As Boolean
			Return GetMultiManyToOne(cuentaEntradaInstance, cuentaSalidaInstance, cuentaPadreInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(cuentaEntradaInstance, cuentaSalidaInstance, cuentaPadreInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(cuentaEntradaInstance, cuentaSalidaInstance, cuentaPadreInstance, maxNumberOfItemsToReturn, sortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Overridable Function GetMultiManyToOne(cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim validParameters As Boolean = False
			validParameters = validParameters Or Not (cuentaEntradaInstance Is Nothing)
			validParameters = validParameters Or Not (cuentaSalidaInstance Is Nothing)
			validParameters = validParameters Or Not (cuentaPadreInstance Is Nothing)
			If Not validParameters Then
				Return GetMulti(Filter, maxNumberOfItemsToReturn, sortClauses, Nothing, pageNumber, pageSize)
			End If
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If
			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMulti(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, Filter, cuentaEntradaInstance, cuentaSalidaInstance, cuentaPadreInstance, pageNumber, pageSize)
		End Function

		''' <summary>Deletes from the persistent storage all CuentaContable entities which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.</summary>
		''' <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMultiManyToOne(cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity) As Integer
			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.DeleteMulti(MyBase.Transaction, cuentaEntradaInstance, cuentaSalidaInstance, cuentaPadreInstance)
		End Function


		''' <summary>Updates in the persistent storage all CuentaContable entities which have data in common with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.
		''' Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">CuentaContableEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="cuentaEntradaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaSalidaInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <param name="cuentaPadreInstance">CuentaContableEntity instance to use as a filter for the CuentaContableEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMultiManyToOne(entityWithNewValues As CuentaContableEntity, cuentaEntradaInstance As IEntity, cuentaSalidaInstance As IEntity, cuentaPadreInstance As IEntity) As Integer
			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, cuentaEntradaInstance, cuentaSalidaInstance, cuentaPadreInstance)
		End Function
	
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PeriodosContEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="periodosContInstance">PeriodosContEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPeriodosContCollectionViaAcumuladoCuentasContables(periodosContInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPeriodosContCollectionViaAcumuladoCuentasContables(periodosContInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PeriodosContEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="periodosContInstance">PeriodosContEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPeriodosContCollectionViaAcumuladoCuentasContables(periodosContInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPeriodosContCollectionViaAcumuladoCuentasContables(periodosContInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PeriodosContEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="periodosContInstance">PeriodosContEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPeriodosContCollectionViaAcumuladoCuentasContables(periodosContInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPeriodosContCollectionViaAcumuladoCuentasContables(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, periodosContInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PeriodosContEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="periodosContInstance">PeriodosContEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPeriodosContCollectionViaAcumuladoCuentasContables(periodosContInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPeriodosContCollectionViaAcumuladoCuentasContables(periodosContInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PeriodosContEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="periodosContInstance">PeriodosContEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPeriodosContCollectionViaAcumuladoCuentasContables(periodosContInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPeriodosContCollectionViaAcumuladoCuentasContables(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, periodosContInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabBalanceEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabBalanceInstance">CabBalanceEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabBalanceCollectionViaDetBalance(cabBalanceInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabBalanceCollectionViaDetBalance(cabBalanceInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabBalanceEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabBalanceInstance">CabBalanceEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabBalanceCollectionViaDetBalance(cabBalanceInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabBalanceCollectionViaDetBalance(cabBalanceInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabBalanceEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabBalanceInstance">CabBalanceEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabBalanceCollectionViaDetBalance(cabBalanceInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingCabBalanceCollectionViaDetBalance(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabBalanceInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabBalanceEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabBalanceInstance">CabBalanceEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabBalanceCollectionViaDetBalance(cabBalanceInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabBalanceCollectionViaDetBalance(cabBalanceInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabBalanceEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabBalanceInstance">CabBalanceEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabBalanceCollectionViaDetBalance(cabBalanceInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingCabBalanceCollectionViaDetBalance(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabBalanceInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabEdoResEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabEdoResInstance">CabEdoResEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabEdoResCollectionViaDetEdoRes(cabEdoResInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabEdoResCollectionViaDetEdoRes(cabEdoResInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabEdoResEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabEdoResInstance">CabEdoResEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabEdoResCollectionViaDetEdoRes(cabEdoResInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabEdoResCollectionViaDetEdoRes(cabEdoResInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabEdoResEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabEdoResInstance">CabEdoResEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabEdoResCollectionViaDetEdoRes(cabEdoResInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingCabEdoResCollectionViaDetEdoRes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabEdoResInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabEdoResEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabEdoResInstance">CabEdoResEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabEdoResCollectionViaDetEdoRes(cabEdoResInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabEdoResCollectionViaDetEdoRes(cabEdoResInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabEdoResEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabEdoResInstance">CabEdoResEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabEdoResCollectionViaDetEdoRes(cabEdoResInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingCabEdoResCollectionViaDetEdoRes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabEdoResInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="metodoCabInstance">MetodoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="metodoCabInstance">MetodoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="metodoCabInstance">MetodoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingMetodoCabCollectionViaGastosDepartamentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, metodoCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="metodoCabInstance">MetodoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="metodoCabInstance">MetodoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingMetodoCabCollectionViaGastosDepartamentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, metodoCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaGastosDepartamentos(polizaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaGastosDepartamentos(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaGastosDepartamentos(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaGastosDepartamentos(polizaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaGastosDepartamentos(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPolizaCollectionViaGastosDepartamentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaGastosDepartamentos(polizaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaGastosDepartamentos(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPolizaCollectionViaGastosDepartamentos(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPolizaCollectionViaGastosDepartamentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPlazaCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPlazaCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingTipoAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingTipoAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaMcatCentroCostosAlmacen(plazaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaMcatCentroCostosAlmacen(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaMcatCentroCostosAlmacen(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaMcatCentroCostosAlmacen(plazaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaMcatCentroCostosAlmacen(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPlazaCollectionViaMcatCentroCostosAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaMcatCentroCostosAlmacen(plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaMcatCentroCostosAlmacen(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPlazaCollectionViaMcatCentroCostosAlmacen(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPlazaCollectionViaMcatCentroCostosAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingTipoComicionistaCollectionViaComicionista(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoComicionistaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingTipoComicionistaCollectionViaComicionista(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoComicionistaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaComicionista(plazaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaComicionista(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaComicionista(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaComicionista(plazaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaComicionista(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPlazaCollectionViaComicionista(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaComicionista(plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaComicionista(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPlazaCollectionViaComicionista(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPlazaCollectionViaComicionista(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor(catLugaresDeCompraInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor(catLugaresDeCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor(catLugaresDeCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor(catLugaresDeCompraInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor(catLugaresDeCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingCatLugaresDeCompraCollectionViaProveedor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catLugaresDeCompraInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor(catLugaresDeCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor(catLugaresDeCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor(catLugaresDeCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingCatLugaresDeCompraCollectionViaProveedor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catLugaresDeCompraInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor_(catLugaresDeCompraInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor_(catLugaresDeCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor_(catLugaresDeCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor_(catLugaresDeCompraInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor_(catLugaresDeCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingCatLugaresDeCompraCollectionViaProveedor_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catLugaresDeCompraInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor_(catLugaresDeCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor_(catLugaresDeCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaProveedor_(catLugaresDeCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingCatLugaresDeCompraCollectionViaProveedor_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catLugaresDeCompraInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor(contDiotTiposOperacionInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor(contDiotTiposOperacionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor(contDiotTiposOperacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor(contDiotTiposOperacionInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor(contDiotTiposOperacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingContDiotTiposOperacionCollectionViaProveedor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, contDiotTiposOperacionInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor(contDiotTiposOperacionInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor(contDiotTiposOperacionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor(contDiotTiposOperacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingContDiotTiposOperacionCollectionViaProveedor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, contDiotTiposOperacionInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor_(contDiotTiposOperacionInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor_(contDiotTiposOperacionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor_(contDiotTiposOperacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor_(contDiotTiposOperacionInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor_(contDiotTiposOperacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingContDiotTiposOperacionCollectionViaProveedor_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, contDiotTiposOperacionInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor_(contDiotTiposOperacionInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor_(contDiotTiposOperacionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposOperacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposOperacionInstance">ContDiotTiposOperacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingContDiotTiposOperacionCollectionViaProveedor_(contDiotTiposOperacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingContDiotTiposOperacionCollectionViaProveedor_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, contDiotTiposOperacionInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor(contDiotTiposTercerosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor(contDiotTiposTercerosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor(contDiotTiposTercerosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor(contDiotTiposTercerosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor(contDiotTiposTercerosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingContDiotTiposTercerosCollectionViaProveedor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, contDiotTiposTercerosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor(contDiotTiposTercerosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor(contDiotTiposTercerosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor(contDiotTiposTercerosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingContDiotTiposTercerosCollectionViaProveedor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, contDiotTiposTercerosInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor_(contDiotTiposTercerosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor_(contDiotTiposTercerosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor_(contDiotTiposTercerosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor_(contDiotTiposTercerosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor_(contDiotTiposTercerosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingContDiotTiposTercerosCollectionViaProveedor_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, contDiotTiposTercerosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor_(contDiotTiposTercerosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor_(contDiotTiposTercerosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ContDiotTiposTercerosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="contDiotTiposTercerosInstance">ContDiotTiposTercerosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingContDiotTiposTercerosCollectionViaProveedor_(contDiotTiposTercerosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingContDiotTiposTercerosCollectionViaProveedor_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, contDiotTiposTercerosInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes(comicionistaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes(comicionistaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes(comicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes(comicionistaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes(comicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingComicionistaCollectionViaMfacCatClientes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, comicionistaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes(comicionistaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes(comicionistaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes(comicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingComicionistaCollectionViaMfacCatClientes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, comicionistaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes_(comicionistaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes_(comicionistaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes_(comicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes_(comicionistaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes_(comicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingComicionistaCollectionViaMfacCatClientes_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, comicionistaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes_(comicionistaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes_(comicionistaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="comicionistaInstance">ComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingComicionistaCollectionViaMfacCatClientes_(comicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingComicionistaCollectionViaMfacCatClientes_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, comicionistaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizasModeloCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizasModeloCabInstance">PolizasModeloCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizasModeloCabCollectionViaPolizasModeloDet(polizasModeloCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPolizasModeloCabCollectionViaPolizasModeloDet(polizasModeloCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizasModeloCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizasModeloCabInstance">PolizasModeloCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizasModeloCabCollectionViaPolizasModeloDet(polizasModeloCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPolizasModeloCabCollectionViaPolizasModeloDet(polizasModeloCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizasModeloCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizasModeloCabInstance">PolizasModeloCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizasModeloCabCollectionViaPolizasModeloDet(polizasModeloCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPolizasModeloCabCollectionViaPolizasModeloDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizasModeloCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizasModeloCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizasModeloCabInstance">PolizasModeloCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizasModeloCabCollectionViaPolizasModeloDet(polizasModeloCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPolizasModeloCabCollectionViaPolizasModeloDet(polizasModeloCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizasModeloCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizasModeloCabInstance">PolizasModeloCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPolizasModeloCabCollectionViaPolizasModeloDet(polizasModeloCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPolizasModeloCabCollectionViaPolizasModeloDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizasModeloCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaCuenta(tipoMonedaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaCuenta(tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaCuenta(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaCuenta(tipoMonedaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaCuenta(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingTipoMonedaCollectionViaCuenta(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMonedaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaCuenta(tipoMonedaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaCuenta(tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingTipoMonedaCollectionViaCuenta(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingTipoMonedaCollectionViaCuenta(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMonedaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in BancosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="bancosInstance">BancosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBancosCollectionViaCuenta(bancosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingBancosCollectionViaCuenta(bancosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in BancosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="bancosInstance">BancosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBancosCollectionViaCuenta(bancosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingBancosCollectionViaCuenta(bancosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in BancosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="bancosInstance">BancosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBancosCollectionViaCuenta(bancosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingBancosCollectionViaCuenta(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, bancosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in BancosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="bancosInstance">BancosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBancosCollectionViaCuenta(bancosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingBancosCollectionViaCuenta(bancosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in BancosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="bancosInstance">BancosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingBancosCollectionViaCuenta(bancosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingBancosCollectionViaCuenta(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, bancosInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ConceptoFlujoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="conceptoFlujoInstance">ConceptoFlujoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(conceptoFlujoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(conceptoFlujoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ConceptoFlujoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="conceptoFlujoInstance">ConceptoFlujoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(conceptoFlujoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(conceptoFlujoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ConceptoFlujoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="conceptoFlujoInstance">ConceptoFlujoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(conceptoFlujoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, conceptoFlujoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ConceptoFlujoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="conceptoFlujoInstance">ConceptoFlujoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(conceptoFlujoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(conceptoFlujoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ConceptoFlujoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="conceptoFlujoInstance">ConceptoFlujoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(conceptoFlujoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, conceptoFlujoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaPolizaDetalle(polizaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaPolizaDetalle(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaPolizaDetalle(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaPolizaDetalle(polizaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaPolizaDetalle(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPolizaCollectionViaPolizaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaPolizaDetalle(polizaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaPolizaDetalle(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPolizaCollectionViaPolizaDetalle(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingPolizaCollectionViaPolizaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in UsrCxpfacturasCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="usrCxpfacturasCabInstance">UsrCxpfacturasCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(usrCxpfacturasCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(usrCxpfacturasCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in UsrCxpfacturasCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="usrCxpfacturasCabInstance">UsrCxpfacturasCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(usrCxpfacturasCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(usrCxpfacturasCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in UsrCxpfacturasCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="usrCxpfacturasCabInstance">UsrCxpfacturasCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(usrCxpfacturasCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, usrCxpfacturasCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in UsrCxpfacturasCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="usrCxpfacturasCabInstance">UsrCxpfacturasCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(usrCxpfacturasCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(usrCxpfacturasCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this CuentaContableCollection Object all CuentaContableEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in UsrCxpfacturasCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="usrCxpfacturasCabInstance">UsrCxpfacturasCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(usrCxpfacturasCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiUsingUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, usrCxpfacturasCabInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves CuentaContableEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves CuentaContableEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves CuentaContableEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all CuentaContable entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all CuentaContable entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all CuentaContable entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As CuentaContableFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As CuentaContableFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As CuentaContableFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As CuentaContableFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As CuentaContableFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified CuentaContableEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">CuentaContableEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all CuentaContable entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As CuentaContableEntity, updateFilter As IPredicate) As Integer
			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified CuentaContableEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">CuentaContableEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As CuentaContableEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As CuentaContableDAO = DAOFactory.CreateCuentaContableDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCuentaContableDAO()
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
