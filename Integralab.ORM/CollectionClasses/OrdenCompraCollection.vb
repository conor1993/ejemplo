﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:42:45
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
	''' Collection class for storing and retrieving collections of OrdenCompraEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class OrdenCompraCollection 
#Else
	<Serializable()> _
	Public Class OrdenCompraCollection 
#End If
		Inherits EntityCollectionBase(Of OrdenCompraEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New OrdenCompraEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of OrdenCompraEntity))
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

	
		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="sucursalInstance">SucursalEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(proveedorInstance As IEntity, sucursalInstance As IEntity, tipoMonedaInstance As IEntity) As Boolean
			Return GetMultiManyToOne(proveedorInstance, sucursalInstance, tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="sucursalInstance">SucursalEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(proveedorInstance As IEntity, sucursalInstance As IEntity, tipoMonedaInstance As IEntity, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(proveedorInstance, sucursalInstance, tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="sucursalInstance">SucursalEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(proveedorInstance As IEntity, sucursalInstance As IEntity, tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(proveedorInstance, sucursalInstance, tipoMonedaInstance, maxNumberOfItemsToReturn, sortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="sucursalInstance">SucursalEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Overridable Function GetMultiManyToOne(proveedorInstance As IEntity, sucursalInstance As IEntity, tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim validParameters As Boolean = False
			validParameters = validParameters Or Not (proveedorInstance Is Nothing)
			validParameters = validParameters Or Not (sucursalInstance Is Nothing)
			validParameters = validParameters Or Not (tipoMonedaInstance Is Nothing)
			If Not validParameters Then
				Return GetMulti(Filter, maxNumberOfItemsToReturn, sortClauses, Nothing, pageNumber, pageSize)
			End If
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If
			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMulti(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, Filter, proveedorInstance, sucursalInstance, tipoMonedaInstance, pageNumber, pageSize)
		End Function

		''' <summary>Deletes from the persistent storage all OrdenCompra entities which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.</summary>
		''' <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="sucursalInstance">SucursalEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMultiManyToOne(proveedorInstance As IEntity, sucursalInstance As IEntity, tipoMonedaInstance As IEntity) As Integer
			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.DeleteMulti(MyBase.Transaction, proveedorInstance, sucursalInstance, tipoMonedaInstance)
		End Function


		''' <summary>Updates in the persistent storage all OrdenCompra entities which have data in common with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.
		''' Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">OrdenCompraEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="proveedorInstance">ProveedorEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="sucursalInstance">SucursalEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity instance to use as a filter for the OrdenCompraEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMultiManyToOne(entityWithNewValues As OrdenCompraEntity, proveedorInstance As IEntity, sucursalInstance As IEntity, tipoMonedaInstance As IEntity) As Integer
			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, proveedorInstance, sucursalInstance, tipoMonedaInstance)
		End Function
	
	
		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaOrdenCompraDetalle(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaOrdenCompraDetalle(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaOrdenCompraDetalle(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaOrdenCompraDetalle(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaOrdenCompraDetalle(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingProductoCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaOrdenCompraDetalle(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaOrdenCompraDetalle(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaOrdenCompraDetalle(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingProductoCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
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

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingTipoMonedaCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMonedaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMonedaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMonedaInstance">TipoMonedaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoMonedaCollectionViaOrdenCompraDetalle(tipoMonedaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
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

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingTipoMonedaCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMonedaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
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

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingCotizacionCompraCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcomCotizacionCompraInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McomCotizacionCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcomCotizacionCompraInstance">McomCotizacionCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCotizacionCompraCollectionViaOrdenCompraDetalle(mcomCotizacionCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
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

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingCotizacionCompraCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcomCotizacionCompraInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
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

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingSolicitudProductoCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, solicitudProductoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SolicitudProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="solicitudProductoInstance">SolicitudProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingSolicitudProductoCollectionViaOrdenCompraDetalle(solicitudProductoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
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

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingSolicitudProductoCollectionViaOrdenCompraDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, solicitudProductoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, motivoCancelacionInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this OrdenCompraCollection Object all OrdenCompraEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, motivoCancelacionInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves OrdenCompraEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves OrdenCompraEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves OrdenCompraEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all OrdenCompra entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all OrdenCompra entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all OrdenCompra entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As OrdenCompraFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As OrdenCompraFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As OrdenCompraFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As OrdenCompraFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As OrdenCompraFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified OrdenCompraEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">OrdenCompraEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all OrdenCompra entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As OrdenCompraEntity, updateFilter As IPredicate) As Integer
			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified OrdenCompraEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">OrdenCompraEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As OrdenCompraEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As OrdenCompraDAO = DAOFactory.CreateOrdenCompraDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateOrdenCompraDAO()
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
