' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 11 de enero de 2018 10:37:27
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
	''' Collection class for storing and retrieving collections of PlazaEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class PlazaCollection 
#Else
	<Serializable()> _
	Public Class PlazaCollection 
#End If
		Inherits EntityCollectionBase(Of PlazaEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New PlazaEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of PlazaEntity))
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

	
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaCabPrepForm(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingProductoCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingProductoCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingProductoCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingProductoCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCabPrepFormCollectionViaDetPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabPrepFormInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepForm(cabPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCabPrepFormCollectionViaDetPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabPrepFormInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetPrepForm(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetPrepForm(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetPrepForm(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetPrepForm(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetPrepForm(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetPrepForm(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetPrepForm(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaDetPrepForm(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCabPrepFormCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabPrepFormInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabPrepFormInstance">CabPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabPrepFormCollectionViaDetPrepFormLote(cabPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCabPrepFormCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabPrepFormInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in DetPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detPrepFormInstance">DetPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in DetPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detPrepFormInstance">DetPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingDetPrepFormCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, detPrepFormInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in DetPrepFormEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="detPrepFormInstance">DetPrepFormEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingDetPrepFormCollectionViaDetPrepFormLote(detPrepFormInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingDetPrepFormCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, detPrepFormInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetPrepFormLote(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetPrepFormLote(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetPrepFormLote(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetPrepFormLote(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetPrepFormLote(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaDetPrepFormLote(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaDetPrepFormLote(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaDetPrepFormLote(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingProductoCollectionViaDetPrepFormLote(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaAlmacen(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingTipoAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingTipoAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(cuentaContableInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(cuentaContableInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(cuentaContableInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaMcatCentroCostosAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingTipoComicionistaCollectionViaComicionista(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoComicionistaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoComicionistaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoComicionistaInstance">TipoComicionistaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoComicionistaCollectionViaComicionista(tipoComicionistaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
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

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingTipoComicionistaCollectionViaComicionista(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoComicionistaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaComicionista(cuentaContableInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaComicionista(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaComicionista(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaComicionista(cuentaContableInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaComicionista(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaComicionista(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaComicionista(cuentaContableInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaComicionista(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaContableCollectionViaComicionista(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaComicionista(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaCliente(listaPrecioInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingListaPrecioCollectionViaCliente(listaPrecioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaCliente(listaPrecioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingListaPrecioCollectionViaCliente(listaPrecioInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaCliente(listaPrecioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingListaPrecioCollectionViaCliente(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, listaPrecioInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaCliente(listaPrecioInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingListaPrecioCollectionViaCliente(listaPrecioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingListaPrecioCollectionViaCliente(listaPrecioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingListaPrecioCollectionViaCliente(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, listaPrecioInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoVentaInstance">TipoVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoVentaCollectionViaListaPrecio(tipoVentaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoVentaCollectionViaListaPrecio(tipoVentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoVentaInstance">TipoVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoVentaCollectionViaListaPrecio(tipoVentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoVentaCollectionViaListaPrecio(tipoVentaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoVentaInstance">TipoVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoVentaCollectionViaListaPrecio(tipoVentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingTipoVentaCollectionViaListaPrecio(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoVentaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoVentaInstance">TipoVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoVentaCollectionViaListaPrecio(tipoVentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoVentaCollectionViaListaPrecio(tipoVentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoVentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoVentaInstance">TipoVentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingTipoVentaCollectionViaListaPrecio(tipoVentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingTipoVentaCollectionViaListaPrecio(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoVentaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecio(listaPrecioInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecio(listaPrecioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecio(listaPrecioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecio(listaPrecioInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecio(listaPrecioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingListaPrecioCollectionViaListaPrecio(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, listaPrecioInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecio(listaPrecioInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecio(listaPrecioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PlazaCollection Object all PlazaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ListaPrecioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="listaPrecioInstance">ListaPrecioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingListaPrecioCollectionViaListaPrecio(listaPrecioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiUsingListaPrecioCollectionViaListaPrecio(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, listaPrecioInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves PlazaEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves PlazaEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves PlazaEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all Plaza entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all Plaza entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all Plaza entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As PlazaFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As PlazaFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As PlazaFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As PlazaFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As PlazaFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified PlazaEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">PlazaEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all Plaza entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As PlazaEntity, updateFilter As IPredicate) As Integer
			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified PlazaEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">PlazaEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As PlazaEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As PlazaDAO = DAOFactory.CreatePlazaDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreatePlazaDAO()
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
