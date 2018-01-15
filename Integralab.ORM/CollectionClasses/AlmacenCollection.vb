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
	''' Collection class for storing and retrieving collections of AlmacenEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class AlmacenCollection 
#Else
	<Serializable()> _
	Public Class AlmacenCollection 
#End If
		Inherits EntityCollectionBase(Of AlmacenEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New AlmacenEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of AlmacenEntity))
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

	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity) As Boolean
			Return GetMultiManyToOne(plaza_Instance, almacen_Instance, tipoAlmacen_Instance, cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(plaza_Instance, almacen_Instance, tipoAlmacen_Instance, cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(plaza_Instance, almacen_Instance, tipoAlmacen_Instance, cuentaContableInstance, maxNumberOfItemsToReturn, sortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Overridable Function GetMultiManyToOne(plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim validParameters As Boolean = False
			validParameters = validParameters Or Not (plaza_Instance Is Nothing)
			validParameters = validParameters Or Not (almacen_Instance Is Nothing)
			validParameters = validParameters Or Not (tipoAlmacen_Instance Is Nothing)
			validParameters = validParameters Or Not (cuentaContableInstance Is Nothing)
			If Not validParameters Then
				Return GetMulti(Filter, maxNumberOfItemsToReturn, sortClauses, Nothing, pageNumber, pageSize)
			End If
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If
			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMulti(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, Filter, plaza_Instance, almacen_Instance, tipoAlmacen_Instance, cuentaContableInstance, pageNumber, pageSize)
		End Function

		''' <summary>Deletes from the persistent storage all Almacen entities which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.</summary>
		''' <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMultiManyToOne(plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity) As Integer
			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.DeleteMulti(MyBase.Transaction, plaza_Instance, almacen_Instance, tipoAlmacen_Instance, cuentaContableInstance)
		End Function


		''' <summary>Updates in the persistent storage all Almacen entities which have data in common with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.
		''' Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">AlmacenEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="plaza_Instance">PlazaEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="almacen_Instance">AlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="tipoAlmacen_Instance">TipoAlmacenEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <param name="cuentaContableInstance">CuentaContableEntity instance to use as a filter for the AlmacenEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMultiManyToOne(entityWithNewValues As AlmacenEntity, plaza_Instance As IEntity, almacen_Instance As IEntity, tipoAlmacen_Instance As IEntity, cuentaContableInstance As IEntity) As Integer
			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, plaza_Instance, almacen_Instance, tipoAlmacen_Instance, cuentaContableInstance)
		End Function
	
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in LineaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="lineaInstance">LineaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingLineaCollectionViaAlmacenesFamilias(lineaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingLineaCollectionViaAlmacenesFamilias(lineaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in LineaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="lineaInstance">LineaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingLineaCollectionViaAlmacenesFamilias(lineaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingLineaCollectionViaAlmacenesFamilias(lineaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in LineaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="lineaInstance">LineaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingLineaCollectionViaAlmacenesFamilias(lineaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingLineaCollectionViaAlmacenesFamilias(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, lineaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in LineaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="lineaInstance">LineaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingLineaCollectionViaAlmacenesFamilias(lineaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingLineaCollectionViaAlmacenesFamilias(lineaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in LineaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="lineaInstance">LineaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingLineaCollectionViaAlmacenesFamilias(lineaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingLineaCollectionViaAlmacenesFamilias(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, lineaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaAplicMedi(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaAplicMedi_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabAplFor(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabAplFor_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaCabPrepForm_(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingPlazaCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaCabPrepForm(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingPlazaCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabPrepForm___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabProMed(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabProMed(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabProMed(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabProMed(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabProMed(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabProMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabProMed(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabProMed(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaCabProMed(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaCabProMed(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInvHistorialPv(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaInvHistorialPv(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInvHistorialPv(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaInvHistorialPv(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInvHistorialPv(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaInvHistorialPv(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInvHistorialPv(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaInvHistorialPv(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaInvHistorialPv(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaInvHistorialPv(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingPlazaCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PlazaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="plazaInstance">PlazaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPlazaCollectionViaAlmacen(plazaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingPlazaCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, plazaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingTipoAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoAlmacenInstance">TipoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoAlmacenCollectionViaAlmacen(tipoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingTipoAlmacenCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaAlmacen(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, motivoCancelacionInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MotivoCancelacionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="motivoCancelacionInstance">MotivoCancelacionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(motivoCancelacionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMotivoCancelacionCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, motivoCancelacionInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingOrdenCompraCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, ordenCompraInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingOrdenCompraCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, ordenCompraInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInventarioAlmacen(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaInventarioAlmacen(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInventarioAlmacen(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaInventarioAlmacen(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInventarioAlmacen(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaInventarioAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInventarioAlmacen(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaInventarioAlmacen(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaInventarioAlmacen(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaInventarioAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViainventarioAlmacenLotes(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViainventarioAlmacenLotes(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViainventarioAlmacenLotes(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViainventarioAlmacenLotes(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViainventarioAlmacenLotes(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViainventarioAlmacenLotes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViainventarioAlmacenLotes(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViainventarioAlmacenLotes(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViainventarioAlmacenLotes(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViainventarioAlmacenLotes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioAlmacenInstance">InventarioAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(inventarioAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioAlmacenCollectionViainventarioAlmacenLotes(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(tipoMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(tipoMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(tipoMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(tipoMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(tipoMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(tipoMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(tipoMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(tipoMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaInventarioMovimientoAlmacenDetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catMovimientosAlmacenPvInstance">CatMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(catMovimientosAlmacenPvInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(catMovimientosAlmacenPvInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catMovimientosAlmacenPvInstance">CatMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(catMovimientosAlmacenPvInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(catMovimientosAlmacenPvInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catMovimientosAlmacenPvInstance">CatMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(catMovimientosAlmacenPvInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catMovimientosAlmacenPvInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catMovimientosAlmacenPvInstance">CatMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(catMovimientosAlmacenPvInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(catMovimientosAlmacenPvInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catMovimientosAlmacenPvInstance">CatMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(catMovimientosAlmacenPvInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catMovimientosAlmacenPvInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaMinvMovimientosAlmacenPvdetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvMovimientosAlmacenPvInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvMovimientosAlmacenPvEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvMovimientosAlmacenPvInstance">MinvMovimientosAlmacenPvEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(minvMovimientosAlmacenPvInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
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

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvMovimientosAlmacenPvInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(minvTransferenciaAlmacenSalidaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(minvTransferenciaAlmacenSalidaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(minvTransferenciaAlmacenSalidaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(minvTransferenciaAlmacenSalidaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(minvTransferenciaAlmacenSalidaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenSalidaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(minvTransferenciaAlmacenSalidaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(minvTransferenciaAlmacenSalidaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(minvTransferenciaAlmacenSalidaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenSalidaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(minvTransferenciaAlmacenSalidaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(minvTransferenciaAlmacenSalidaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(minvTransferenciaAlmacenSalidaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(minvTransferenciaAlmacenSalidaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(minvTransferenciaAlmacenSalidaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenSalidaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(minvTransferenciaAlmacenSalidaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(minvTransferenciaAlmacenSalidaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenSalidaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenSalidaInstance">MinvTransferenciaAlmacenSalidaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(minvTransferenciaAlmacenSalidaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenSalidaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenProdEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenProdInstance">MinvTransferenciaAlmacenProdEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(minvTransferenciaAlmacenProdInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(minvTransferenciaAlmacenProdInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenProdEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenProdInstance">MinvTransferenciaAlmacenProdEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(minvTransferenciaAlmacenProdInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(minvTransferenciaAlmacenProdInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenProdEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenProdInstance">MinvTransferenciaAlmacenProdEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(minvTransferenciaAlmacenProdInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenProdInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MinvTransferenciaAlmacenProdEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenProdInstance">MinvTransferenciaAlmacenProdEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(minvTransferenciaAlmacenProdInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(minvTransferenciaAlmacenProdInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MinvTransferenciaAlmacenProdEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="minvTransferenciaAlmacenProdInstance">MinvTransferenciaAlmacenProdEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(minvTransferenciaAlmacenProdInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, minvTransferenciaAlmacenProdInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(inventarioMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(inventarioMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(inventarioMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(inventarioMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in InventarioMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="inventarioMovimientoAlmacenInstance">InventarioMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(inventarioMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, inventarioMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(tipoMovimientoAlmacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(tipoMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(tipoMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(tipoMovimientoAlmacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(tipoMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMovimientoAlmacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(tipoMovimientoAlmacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(tipoMovimientoAlmacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoMovimientoAlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoMovimientoAlmacenInstance">TipoMovimientoAlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(tipoMovimientoAlmacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoMovimientoAlmacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaUsrAlmInvFisico(productoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaUsrAlmInvFisico(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaUsrAlmInvFisico(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaUsrAlmInvFisico(productoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaUsrAlmInvFisico(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaUsrAlmInvFisico(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProductoCollectionViaUsrAlmInvFisico(productoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProductoCollectionViaUsrAlmInvFisico(productoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProductoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="productoInstance">ProductoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProductoCollectionViaUsrAlmInvFisico(productoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingProductoCollectionViaUsrAlmInvFisico(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, productoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(mscmovtosAlmacenCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(mscmovtosAlmacenCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(mscmovtosAlmacenCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(mscmovtosAlmacenCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(mscmovtosAlmacenCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mscmovtosAlmacenCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(mscmovtosAlmacenCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(mscmovtosAlmacenCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(mscmovtosAlmacenCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mscmovtosAlmacenCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(mscmovtosAlmacenCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(mscmovtosAlmacenCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(mscmovtosAlmacenCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(mscmovtosAlmacenCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(mscmovtosAlmacenCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mscmovtosAlmacenCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(mscmovtosAlmacenCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(mscmovtosAlmacenCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this AlmacenCollection Object all AlmacenEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(mscmovtosAlmacenCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiUsingMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mscmovtosAlmacenCabInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves AlmacenEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves AlmacenEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves AlmacenEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all Almacen entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all Almacen entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all Almacen entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As AlmacenFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As AlmacenFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As AlmacenFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As AlmacenFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As AlmacenFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified AlmacenEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">AlmacenEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all Almacen entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As AlmacenEntity, updateFilter As IPredicate) As Integer
			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified AlmacenEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">AlmacenEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As AlmacenEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As AlmacenDAO = DAOFactory.CreateAlmacenDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateAlmacenDAO()
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
