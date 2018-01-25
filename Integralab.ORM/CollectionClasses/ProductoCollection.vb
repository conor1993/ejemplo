' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:19
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
	''' Collection class for storing and retrieving collections of ProductoEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ProductoCollection 
#Else
	<Serializable()> _
	Public Class ProductoCollection 
#End If
		Inherits EntityCollectionBase(Of ProductoEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New ProductoEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of ProductoEntity))
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

	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="lineaInstance">LineaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="presentacionInstance">PresentacionEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="tipoProductoInstance">TipoProductoEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="unidadMedidaInstance">UnidadMedidaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="marcaInstance">MarcaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(lineaInstance As IEntity, presentacionInstance As IEntity, tipoProductoInstance As IEntity, unidadMedidaInstance As IEntity, marcaInstance As IEntity) As Boolean
			Return GetMultiManyToOne(lineaInstance, presentacionInstance, tipoProductoInstance, unidadMedidaInstance, marcaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="lineaInstance">LineaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="presentacionInstance">PresentacionEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="tipoProductoInstance">TipoProductoEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="unidadMedidaInstance">UnidadMedidaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="marcaInstance">MarcaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(lineaInstance As IEntity, presentacionInstance As IEntity, tipoProductoInstance As IEntity, unidadMedidaInstance As IEntity, marcaInstance As IEntity, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(lineaInstance, presentacionInstance, tipoProductoInstance, unidadMedidaInstance, marcaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="lineaInstance">LineaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="presentacionInstance">PresentacionEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="tipoProductoInstance">TipoProductoEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="unidadMedidaInstance">UnidadMedidaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="marcaInstance">MarcaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(lineaInstance As IEntity, presentacionInstance As IEntity, tipoProductoInstance As IEntity, unidadMedidaInstance As IEntity, marcaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(lineaInstance, presentacionInstance, tipoProductoInstance, unidadMedidaInstance, marcaInstance, maxNumberOfItemsToReturn, sortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="lineaInstance">LineaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="presentacionInstance">PresentacionEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="tipoProductoInstance">TipoProductoEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="unidadMedidaInstance">UnidadMedidaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="marcaInstance">MarcaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Overridable Function GetMultiManyToOne(lineaInstance As IEntity, presentacionInstance As IEntity, tipoProductoInstance As IEntity, unidadMedidaInstance As IEntity, marcaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim validParameters As Boolean = False
			validParameters = validParameters Or Not (lineaInstance Is Nothing)
			validParameters = validParameters Or Not (presentacionInstance Is Nothing)
			validParameters = validParameters Or Not (tipoProductoInstance Is Nothing)
			validParameters = validParameters Or Not (unidadMedidaInstance Is Nothing)
			validParameters = validParameters Or Not (marcaInstance Is Nothing)
			If Not validParameters Then
				Return GetMulti(Filter, maxNumberOfItemsToReturn, sortClauses, Nothing, pageNumber, pageSize)
			End If
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If
			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMulti(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, Filter, lineaInstance, presentacionInstance, tipoProductoInstance, unidadMedidaInstance, marcaInstance, pageNumber, pageSize)
		End Function

		''' <summary>Deletes from the persistent storage all Producto entities which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.</summary>
		''' <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		''' <param name="lineaInstance">LineaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="presentacionInstance">PresentacionEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="tipoProductoInstance">TipoProductoEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="unidadMedidaInstance">UnidadMedidaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="marcaInstance">MarcaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMultiManyToOne(lineaInstance As IEntity, presentacionInstance As IEntity, tipoProductoInstance As IEntity, unidadMedidaInstance As IEntity, marcaInstance As IEntity) As Integer
			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.DeleteMulti(MyBase.Transaction, lineaInstance, presentacionInstance, tipoProductoInstance, unidadMedidaInstance, marcaInstance)
		End Function


		''' <summary>Updates in the persistent storage all Producto entities which have data in common with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.
		''' Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">ProductoEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="lineaInstance">LineaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="presentacionInstance">PresentacionEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="tipoProductoInstance">TipoProductoEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="unidadMedidaInstance">UnidadMedidaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <param name="marcaInstance">MarcaEntity instance to use as a filter for the ProductoEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMultiManyToOne(entityWithNewValues As ProductoEntity, lineaInstance As IEntity, presentacionInstance As IEntity, tipoProductoInstance As IEntity, unidadMedidaInstance As IEntity, marcaInstance As IEntity) As Integer
			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, lineaInstance, presentacionInstance, tipoProductoInstance, unidadMedidaInstance, marcaInstance)
		End Function
	
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDet(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaAplicMediDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediInstance">AplicMediEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAplicMediCollectionViaAplicMediDetDet(aplicMediInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAplicMediCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAplicMediDetCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediDetInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AplicMediDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="aplicMediDetInstance">AplicMediDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAplicMediDetCollectionViaAplicMediDetDet(aplicMediDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAplicMediDetCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, aplicMediDetInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaAplicMediDetDet(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaAplicMediDetDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaAplicMediDetDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm_(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm_(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm_(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm_(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm_(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm_(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm_(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm_(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingPlazaCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingPlazaCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm_(plazaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm_(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm_(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm_(plazaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm_(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingPlazaCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm_(plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm_(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm_(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingPlazaCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm____(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm______(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatNutrientesEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catNutrientesInstance">CatNutrientesEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatNutrientesCollectionViaDetAlimentos(catNutrientesInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCatNutrientesCollectionViaDetAlimentos(catNutrientesInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatNutrientesEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catNutrientesInstance">CatNutrientesEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatNutrientesCollectionViaDetAlimentos(catNutrientesInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCatNutrientesCollectionViaDetAlimentos(catNutrientesInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatNutrientesEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catNutrientesInstance">CatNutrientesEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatNutrientesCollectionViaDetAlimentos(catNutrientesInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCatNutrientesCollectionViaDetAlimentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catNutrientesInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatNutrientesEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catNutrientesInstance">CatNutrientesEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatNutrientesCollectionViaDetAlimentos(catNutrientesInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCatNutrientesCollectionViaDetAlimentos(catNutrientesInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatNutrientesEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catNutrientesInstance">CatNutrientesEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCatNutrientesCollectionViaDetAlimentos(catNutrientesInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCatNutrientesCollectionViaDetAlimentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catNutrientesInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabAplForCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabAplForInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabAplForEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabAplForInstance">CabAplForEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabAplForCollectionViaDetAplFor(cabAplForInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabAplForCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabAplForInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaDetAplFor(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetAplFor(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaDetAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabProMedCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabProMedInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabProMedCollectionViaDetDproMed(cabProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabProMedCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabProMedInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in DetProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detProMedInstance">DetProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in DetProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detProMedInstance">DetProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingDetProMedCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, detProMedInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in DetProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detProMedInstance">DetProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingDetProMedCollectionViaDetDproMed(detProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
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

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingDetProMedCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, detProMedInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetDproMed(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetDproMed(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetDproMed(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetDproMed(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetDproMed(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetDproMed(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetDproMed(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaDetDproMed(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaDetDproMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabPrepFormCollectionViaDetPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabPrepFormInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabPrepFormCollectionViaDetPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabPrepFormInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepForm(plazaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaDetPrepForm(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepForm(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaDetPrepForm(plazaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepForm(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingPlazaCollectionViaDetPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepForm(plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaDetPrepForm(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepForm(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingPlazaCollectionViaDetPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabPrepFormCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabPrepFormInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabPrepFormCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabPrepFormInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in DetPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detPrepFormInstance">DetPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in DetPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detPrepFormInstance">DetPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in DetPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detPrepFormInstance">DetPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingDetPrepFormCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, detPrepFormInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in DetPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detPrepFormInstance">DetPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in DetPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detPrepFormInstance">DetPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingDetPrepFormCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, detPrepFormInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepFormLote(plazaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaDetPrepFormLote(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepFormLote(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaDetPrepFormLote(plazaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepFormLote(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingPlazaCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepFormLote(plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaDetPrepFormLote(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPlazaCollectionViaDetPrepFormLote(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingPlazaCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetProMed(cabProMedInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabProMedCollectionViaDetProMed(cabProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetProMed(cabProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabProMedCollectionViaDetProMed(cabProMedInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetProMed(cabProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabProMedCollectionViaDetProMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabProMedInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabProMedCollectionViaDetProMed(cabProMedInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabProMedCollectionViaDetProMed(cabProMedInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabProMedEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabProMedInstance">CabProMedEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCabProMedCollectionViaDetProMed(cabProMedInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCabProMedCollectionViaDetProMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabProMedInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInvHistorialPv(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaInvHistorialPv(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInvHistorialPv(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaInvHistorialPv(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInvHistorialPv(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaInvHistorialPv(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInvHistorialPv(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaInvHistorialPv(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViaInvHistorialPv(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaInvHistorialPv(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaCostoProductoProveedor(proveedorInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaCostoProductoProveedor(proveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaCostoProductoProveedor(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaCostoProductoProveedor(proveedorInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaCostoProductoProveedor(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingProveedorCollectionViaCostoProductoProveedor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, proveedorInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaCostoProductoProveedor(proveedorInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaCostoProductoProveedor(proveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProveedorCollectionViaCostoProductoProveedor(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingProveedorCollectionViaCostoProductoProveedor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, proveedorInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CostoIndirectoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="costoIndirectoInstance">CostoIndirectoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCostoIndirectoCollectionViaProductoCostoIndirecto(costoIndirectoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCostoIndirectoCollectionViaProductoCostoIndirecto(costoIndirectoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CostoIndirectoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="costoIndirectoInstance">CostoIndirectoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCostoIndirectoCollectionViaProductoCostoIndirecto(costoIndirectoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCostoIndirectoCollectionViaProductoCostoIndirecto(costoIndirectoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CostoIndirectoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="costoIndirectoInstance">CostoIndirectoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCostoIndirectoCollectionViaProductoCostoIndirecto(costoIndirectoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCostoIndirectoCollectionViaProductoCostoIndirecto(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, costoIndirectoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CostoIndirectoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="costoIndirectoInstance">CostoIndirectoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCostoIndirectoCollectionViaProductoCostoIndirecto(costoIndirectoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCostoIndirectoCollectionViaProductoCostoIndirecto(costoIndirectoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CostoIndirectoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="costoIndirectoInstance">CostoIndirectoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCostoIndirectoCollectionViaProductoCostoIndirecto(costoIndirectoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCostoIndirectoCollectionViaProductoCostoIndirecto(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, costoIndirectoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecioDetalle(listaPrecioInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecioDetalle(listaPrecioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecioDetalle(listaPrecioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecioDetalle(listaPrecioInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecioDetalle(listaPrecioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingListaPrecioCollectionViaListaPrecioDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, listaPrecioInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecioDetalle(listaPrecioInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecioDetalle(listaPrecioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecioDetalle(listaPrecioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingListaPrecioCollectionViaListaPrecioDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, listaPrecioInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaMcecatLotesCabFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SolicitudProductoDetalleEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoDetalleInstance">SolicitudProductoDetalleEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(solicitudProductoDetalleInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(solicitudProductoDetalleInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoDetalleEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoDetalleInstance">SolicitudProductoDetalleEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(solicitudProductoDetalleInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(solicitudProductoDetalleInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoDetalleEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoDetalleInstance">SolicitudProductoDetalleEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(solicitudProductoDetalleInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, solicitudProductoDetalleInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SolicitudProductoDetalleEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoDetalleInstance">SolicitudProductoDetalleEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(solicitudProductoDetalleInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(solicitudProductoDetalleInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoDetalleEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoDetalleInstance">SolicitudProductoDetalleEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(solicitudProductoDetalleInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, solicitudProductoDetalleInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(proveedorInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(proveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(proveedorInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, proveedorInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(proveedorInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(proveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, proveedorInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(tipoMonedaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(tipoMonedaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMonedaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(tipoMonedaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMonedaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcomCotizacionCompraInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcomCotizacionCompraInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McomCotizacionCompraProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraProveedorInstance">McomCotizacionCompraProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraProveedorInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraProveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraProveedorInstance">McomCotizacionCompraProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraProveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraProveedorInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraProveedorInstance">McomCotizacionCompraProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraProveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcomCotizacionCompraProveedorInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McomCotizacionCompraProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraProveedorInstance">McomCotizacionCompraProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraProveedorInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraProveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraProveedorInstance">McomCotizacionCompraProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(mcomCotizacionCompraProveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcomCotizacionCompraProveedorInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingTipoMonedaCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMonedaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingTipoMonedaCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMonedaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCotizacionCompraCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcomCotizacionCompraInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingCotizacionCompraCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcomCotizacionCompraInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaOrdenCompraDetalle(ordenCompraInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingOrdenCompraCollectionViaOrdenCompraDetalle(ordenCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaOrdenCompraDetalle(ordenCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingOrdenCompraCollectionViaOrdenCompraDetalle(ordenCompraInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaOrdenCompraDetalle(ordenCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingOrdenCompraCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, ordenCompraInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaOrdenCompraDetalle(ordenCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingOrdenCompraCollectionViaOrdenCompraDetalle(ordenCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingOrdenCompraCollectionViaOrdenCompraDetalle(ordenCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingOrdenCompraCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, ordenCompraInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingSolicitudProductoCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, solicitudProductoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingSolicitudProductoCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, solicitudProductoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="presupuestoInstance">PresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(presupuestoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(presupuestoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="presupuestoInstance">PresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(presupuestoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(presupuestoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="presupuestoInstance">PresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(presupuestoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, presupuestoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="presupuestoInstance">PresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(presupuestoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(presupuestoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="presupuestoInstance">PresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(presupuestoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcomPresupuestoCollectionViaMcomPresupuestoDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, presupuestoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(solicitudProductoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(solicitudProductoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(solicitudProductoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(solicitudProductoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(solicitudProductoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, solicitudProductoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(solicitudProductoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(solicitudProductoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(solicitudProductoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingSolicitudProductoCollectionViaSolicitudProductoDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, solicitudProductoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioAlmacen(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaInventarioAlmacen(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioAlmacen(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaInventarioAlmacen(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioAlmacen(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaInventarioAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioAlmacen(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaInventarioAlmacen(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioAlmacen(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaInventarioAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViainventarioAlmacenLotes(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViainventarioAlmacenLotes(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViainventarioAlmacenLotes(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViainventarioAlmacenLotes(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViainventarioAlmacenLotes(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViainventarioAlmacenLotes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViainventarioAlmacenLotes(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViainventarioAlmacenLotes(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViainventarioAlmacenLotes(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViainventarioAlmacenLotes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvMovimientosAlmacenPvInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvMovimientosAlmacenPvInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenEntradaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenEntradaInstance">MinvTransferenciaAlmacenEntradaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(minvTransferenciaAlmacenEntradaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(minvTransferenciaAlmacenEntradaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenEntradaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenEntradaInstance">MinvTransferenciaAlmacenEntradaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(minvTransferenciaAlmacenEntradaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(minvTransferenciaAlmacenEntradaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenEntradaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenEntradaInstance">MinvTransferenciaAlmacenEntradaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(minvTransferenciaAlmacenEntradaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenEntradaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenEntradaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenEntradaInstance">MinvTransferenciaAlmacenEntradaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(minvTransferenciaAlmacenEntradaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(minvTransferenciaAlmacenEntradaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenEntradaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenEntradaInstance">MinvTransferenciaAlmacenEntradaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(minvTransferenciaAlmacenEntradaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenEntradaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(minvTransferenciaAlmacenSalidaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(minvTransferenciaAlmacenSalidaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(minvTransferenciaAlmacenSalidaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(minvTransferenciaAlmacenSalidaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(minvTransferenciaAlmacenSalidaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenSalidaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(minvTransferenciaAlmacenSalidaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(minvTransferenciaAlmacenSalidaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(minvTransferenciaAlmacenSalidaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenSalidaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in NotaVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="notaVentaInstance">NotaVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(notaVentaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(notaVentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in NotaVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="notaVentaInstance">NotaVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(notaVentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(notaVentaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in NotaVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="notaVentaInstance">NotaVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(notaVentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, notaVentaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in NotaVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="notaVentaInstance">NotaVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(notaVentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(notaVentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in NotaVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="notaVentaInstance">NotaVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(notaVentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMventaNotasVentaCollectionViaMventaNotaVentaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, notaVentaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaUsrAlmInvFisico(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaUsrAlmInvFisico(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaUsrAlmInvFisico(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaUsrAlmInvFisico(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaUsrAlmInvFisico(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaUsrAlmInvFisico(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaUsrAlmInvFisico(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaUsrAlmInvFisico(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViaUsrAlmInvFisico(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaUsrAlmInvFisico(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(mcgcatTiposdeGanadoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(mcgcatTiposdeGanadoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(mcgcatTiposdeGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in RecepcionGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="recepcionGanadoInstance">RecepcionGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(recepcionGanadoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(recepcionGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in RecepcionGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="recepcionGanadoInstance">RecepcionGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(recepcionGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(recepcionGanadoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in RecepcionGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="recepcionGanadoInstance">RecepcionGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(recepcionGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, recepcionGanadoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in RecepcionGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="recepcionGanadoInstance">RecepcionGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(recepcionGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(recepcionGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this ProductoCollection Object all ProductoEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in RecepcionGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="recepcionGanadoInstance">RecepcionGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(recepcionGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiUsingRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, recepcionGanadoInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves ProductoEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves ProductoEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves ProductoEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all Producto entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all Producto entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all Producto entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As ProductoFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As ProductoFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As ProductoFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As ProductoFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As ProductoFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified ProductoEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">ProductoEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all Producto entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As ProductoEntity, updateFilter As IPredicate) As Integer
			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified ProductoEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">ProductoEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As ProductoEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As ProductoDAO = DAOFactory.CreateProductoDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateProductoDAO()
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
