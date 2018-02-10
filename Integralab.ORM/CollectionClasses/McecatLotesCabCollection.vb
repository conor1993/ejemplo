' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 9 de febrero de 2018 17:51:00
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
	''' Collection class for storing and retrieving collections of McecatLotesCabEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McecatLotesCabCollection 
#Else
	<Serializable()> _
	Public Class McecatLotesCabCollection 
#End If
		Inherits EntityCollectionBase(Of McecatLotesCabEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New McecatLotesCabEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of McecatLotesCabEntity))
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

	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cierreLote_Instance">CierreLoteEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(cierreLote_Instance As IEntity, mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToOne(cierreLote_Instance, mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cierreLote_Instance">CierreLoteEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(cierreLote_Instance As IEntity, mcecatCorralesCabInstance As IEntity, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(cierreLote_Instance, mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cierreLote_Instance">CierreLoteEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(cierreLote_Instance As IEntity, mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(cierreLote_Instance, mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cierreLote_Instance">CierreLoteEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Overridable Function GetMultiManyToOne(cierreLote_Instance As IEntity, mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim validParameters As Boolean = False
			validParameters = validParameters Or Not (cierreLote_Instance Is Nothing)
			validParameters = validParameters Or Not (mcecatCorralesCabInstance Is Nothing)
			If Not validParameters Then
				Return GetMulti(Filter, maxNumberOfItemsToReturn, sortClauses, Nothing, pageNumber, pageSize)
			End If
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If
			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMulti(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, Filter, cierreLote_Instance, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function

		''' <summary>Deletes from the persistent storage all McecatLotesCab entities which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.</summary>
		''' <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		''' <param name="cierreLote_Instance">CierreLoteEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMultiManyToOne(cierreLote_Instance As IEntity, mcecatCorralesCabInstance As IEntity) As Integer
			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, cierreLote_Instance, mcecatCorralesCabInstance)
		End Function


		''' <summary>Updates in the persistent storage all McecatLotesCab entities which have data in common with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.
		''' Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">McecatLotesCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="cierreLote_Instance">CierreLoteEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the McecatLotesCabEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMultiManyToOne(entityWithNewValues As McecatLotesCabEntity, cierreLote_Instance As IEntity, mcecatCorralesCabInstance As IEntity) As Integer
			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, cierreLote_Instance, mcecatCorralesCabInstance)
		End Function
	
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingAplicMediDetCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediDetInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingAplicMediDetCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediDetInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingCabAplForCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabAplForInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingCabAplForCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabAplForInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingCabProMedCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabProMedInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingCabProMedCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabProMedInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in DetProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detProMedInstance">DetProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in DetProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detProMedInstance">DetProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in DetProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detProMedInstance">DetProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingDetProMedCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, detProMedInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in DetProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detProMedInstance">DetProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in DetProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detProMedInstance">DetProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingDetProMedCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, detProMedInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetDproMed(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetDproMed(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetDproMed(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetDproMed(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetDproMed(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetDproMed(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetDproMed(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaDetDproMed(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaMcecatLotesCabFor(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaMcecatLotesCabFor(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaMcecatLotesCabFor(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaMcecatLotesCabFor(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaMcecatLotesCabFor(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaMcecatLotesCabFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaMcecatLotesCabFor(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaMcecatLotesCabFor(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaMcecatLotesCabFor(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaMcecatLotesCabFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(mcgcatTiposdeGanadoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(mcgcatTiposdeGanadoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(mcgcatTiposdeGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatCausasMuerteInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatCausasMuerteInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingCatRastrosCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catRastrosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingCatRastrosCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catRastrosInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingPolizaCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingPolizaCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatLotesDetCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesDetInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcecatLotesDetCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesDetInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(salidaGanadoCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(salidaGanadoCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(salidaGanadoCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatLotesCabCollection Object all McecatLotesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves McecatLotesCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves McecatLotesCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves McecatLotesCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all McecatLotesCab entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all McecatLotesCab entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all McecatLotesCab entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As McecatLotesCabFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As McecatLotesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As McecatLotesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As McecatLotesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As McecatLotesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified McecatLotesCabEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">McecatLotesCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all McecatLotesCab entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As McecatLotesCabEntity, updateFilter As IPredicate) As Integer
			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified McecatLotesCabEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">McecatLotesCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As McecatLotesCabEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As McecatLotesCabDAO = DAOFactory.CreateMcecatLotesCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcecatLotesCabDAO()
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
