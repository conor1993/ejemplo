' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 31 de enero de 2018 11:15:14
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
	''' Collection class for storing and retrieving collections of McecatCorralesCabEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McecatCorralesCabCollection 
#Else
	<Serializable()> _
	Public Class McecatCorralesCabCollection 
#End If
		Inherits EntityCollectionBase(Of McecatCorralesCabEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New McecatCorralesCabEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of McecatCorralesCabEntity))
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

	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatTiposCorralInstance">McecatTiposCorralEntity instance to use as a filter for the McecatCorralesCabEntity objects to Return</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(mcecatTiposCorralInstance As IEntity) As Boolean
			Return GetMultiManyToOne(mcecatTiposCorralInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatTiposCorralInstance">McecatTiposCorralEntity instance to use as a filter for the McecatCorralesCabEntity objects to Return</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(mcecatTiposCorralInstance As IEntity, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(mcecatTiposCorralInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatTiposCorralInstance">McecatTiposCorralEntity instance to use as a filter for the McecatCorralesCabEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(mcecatTiposCorralInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(mcecatTiposCorralInstance, maxNumberOfItemsToReturn, sortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatTiposCorralInstance">McecatTiposCorralEntity instance to use as a filter for the McecatCorralesCabEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Overridable Function GetMultiManyToOne(mcecatTiposCorralInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim validParameters As Boolean = False
			validParameters = validParameters Or Not (mcecatTiposCorralInstance Is Nothing)
			If Not validParameters Then
				Return GetMulti(Filter, maxNumberOfItemsToReturn, sortClauses, Nothing, pageNumber, pageSize)
			End If
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If
			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMulti(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, Filter, mcecatTiposCorralInstance, pageNumber, pageSize)
		End Function

		''' <summary>Deletes from the persistent storage all McecatCorralesCab entities which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.</summary>
		''' <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		''' <param name="mcecatTiposCorralInstance">McecatTiposCorralEntity instance to use as a filter for the McecatCorralesCabEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMultiManyToOne(mcecatTiposCorralInstance As IEntity) As Integer
			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, mcecatTiposCorralInstance)
		End Function


		''' <summary>Updates in the persistent storage all McecatCorralesCab entities which have data in common with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.
		''' Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">McecatCorralesCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="mcecatTiposCorralInstance">McecatTiposCorralEntity instance to use as a filter for the McecatCorralesCabEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMultiManyToOne(entityWithNewValues As McecatCorralesCabEntity, mcecatTiposCorralInstance As IEntity) As Integer
			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, mcecatTiposCorralInstance)
		End Function
	
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDet(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingAplicMediDetCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediDetInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingAplicMediDetCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediDetInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaAplicMediDetDet(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom(cabMovGanInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom(cabMovGanInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaCabRegCom(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom(cabMovGanInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaCabRegCom(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom_(cabMovGanInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom_(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom_(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom_(cabMovGanInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom_(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaCabRegCom_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom_(cabMovGanInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom_(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabMovGanCollectionViaCabRegCom_(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaCabRegCom_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaCabRegCom(catLugaresDeCompraInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaCabRegCom(catLugaresDeCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaCabRegCom(catLugaresDeCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaCabRegCom(catLugaresDeCompraInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaCabRegCom(catLugaresDeCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCatLugaresDeCompraCollectionViaCabRegCom(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catLugaresDeCompraInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaCabRegCom(catLugaresDeCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaCabRegCom(catLugaresDeCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatLugaresDeCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catLugaresDeCompraInstance">CatLugaresDeCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCatLugaresDeCompraCollectionViaCabRegCom(catLugaresDeCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCatLugaresDeCompraCollectionViaCabRegCom(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catLugaresDeCompraInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaCabRegCom(proveedorInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaCabRegCom(proveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaCabRegCom(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaCabRegCom(proveedorInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaCabRegCom(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingProveedorCollectionViaCabRegCom(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, proveedorInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaCabRegCom(proveedorInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaCabRegCom(proveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProveedorCollectionViaCabRegCom(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingProveedorCollectionViaCabRegCom(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, proveedorInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatCompradoresdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(mcgcatCompradoresdeGanadoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(mcgcatCompradoresdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatCompradoresdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(mcgcatCompradoresdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(mcgcatCompradoresdeGanadoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatCompradoresdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(mcgcatCompradoresdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatCompradoresdeGanadoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatCompradoresdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(mcgcatCompradoresdeGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(mcgcatCompradoresdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatCompradoresdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCompradoresdeGanadoInstance">McgcatCompradoresdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(mcgcatCompradoresdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcgcatCompradoresdeGanadoCollectionViaCabRegCom(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatCompradoresdeGanadoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCabAplForCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabAplForInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCabAplForCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabAplForInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetAplFor(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(mcgcatTiposdeGanadoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(mcgcatTiposdeGanadoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(mcgcatTiposdeGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CierreLoteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cierreLoteInstance">CierreLoteEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCierreLoteCollectionViaMcecatLotesCab(cierreLoteInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCierreLoteCollectionViaMcecatLotesCab(cierreLoteInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CierreLoteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cierreLoteInstance">CierreLoteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCierreLoteCollectionViaMcecatLotesCab(cierreLoteInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCierreLoteCollectionViaMcecatLotesCab(cierreLoteInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CierreLoteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cierreLoteInstance">CierreLoteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCierreLoteCollectionViaMcecatLotesCab(cierreLoteInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCierreLoteCollectionViaMcecatLotesCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cierreLoteInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CierreLoteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cierreLoteInstance">CierreLoteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCierreLoteCollectionViaMcecatLotesCab(cierreLoteInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCierreLoteCollectionViaMcecatLotesCab(cierreLoteInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CierreLoteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cierreLoteInstance">CierreLoteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCierreLoteCollectionViaMcecatLotesCab(cierreLoteInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCierreLoteCollectionViaMcecatLotesCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cierreLoteInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatProveedoresEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catProveedoresInstance">CatProveedoresEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatProveedoresCollectionViaMcgcompraGanadoCab(catProveedoresInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCatProveedoresCollectionViaMcgcompraGanadoCab(catProveedoresInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatProveedoresEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catProveedoresInstance">CatProveedoresEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatProveedoresCollectionViaMcgcompraGanadoCab(catProveedoresInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCatProveedoresCollectionViaMcgcompraGanadoCab(catProveedoresInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatProveedoresEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catProveedoresInstance">CatProveedoresEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatProveedoresCollectionViaMcgcompraGanadoCab(catProveedoresInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCatProveedoresCollectionViaMcgcompraGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catProveedoresInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatProveedoresEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catProveedoresInstance">CatProveedoresEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatProveedoresCollectionViaMcgcompraGanadoCab(catProveedoresInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCatProveedoresCollectionViaMcgcompraGanadoCab(catProveedoresInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatProveedoresEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catProveedoresInstance">CatProveedoresEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCatProveedoresCollectionViaMcgcompraGanadoCab(catProveedoresInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCatProveedoresCollectionViaMcgcompraGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catProveedoresInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaProrraRec(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatCausasMuerteInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatCausasMuerteInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCatRastrosCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catRastrosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingCatRastrosCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catRastrosInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingPolizaCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaSalidaGanadoCab(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this McecatCorralesCabCollection Object all McecatCorralesCabEntity objects which are related via a 
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

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiUsingPolizaCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves McecatCorralesCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves McecatCorralesCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves McecatCorralesCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all McecatCorralesCab entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all McecatCorralesCab entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all McecatCorralesCab entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As McecatCorralesCabFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As McecatCorralesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As McecatCorralesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As McecatCorralesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As McecatCorralesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified McecatCorralesCabEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">McecatCorralesCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all McecatCorralesCab entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As McecatCorralesCabEntity, updateFilter As IPredicate) As Integer
			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified McecatCorralesCabEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">McecatCorralesCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As McecatCorralesCabEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As McecatCorralesCabDAO = DAOFactory.CreateMcecatCorralesCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcecatCorralesCabDAO()
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
