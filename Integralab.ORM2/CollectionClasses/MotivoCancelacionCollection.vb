' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:14
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
	''' Collection class for storing and retrieving collections of MotivoCancelacionEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MotivoCancelacionCollection 
#Else
	<Serializable()> _
	Public Class MotivoCancelacionCollection 
#End If
		Inherits EntityCollectionBase(Of MotivoCancelacionEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New MotivoCancelacionEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of MotivoCancelacionEntity))
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

	
	
		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ModuloEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="moduloInstance">ModuloEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingModuloCollectionViaMotivosCancelacionDetalle(moduloInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingModuloCollectionViaMotivosCancelacionDetalle(moduloInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ModuloEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="moduloInstance">ModuloEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingModuloCollectionViaMotivosCancelacionDetalle(moduloInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingModuloCollectionViaMotivosCancelacionDetalle(moduloInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ModuloEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="moduloInstance">ModuloEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingModuloCollectionViaMotivosCancelacionDetalle(moduloInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetMultiUsingModuloCollectionViaMotivosCancelacionDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, moduloInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ModuloEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="moduloInstance">ModuloEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingModuloCollectionViaMotivosCancelacionDetalle(moduloInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingModuloCollectionViaMotivosCancelacionDetalle(moduloInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ModuloEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="moduloInstance">ModuloEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingModuloCollectionViaMotivosCancelacionDetalle(moduloInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetMultiUsingModuloCollectionViaMotivosCancelacionDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, moduloInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoPresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoPresupuestoInstance">TipoPresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoPresupuestoCollectionViaMcomPresupuesto(tipoPresupuestoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingTipoPresupuestoCollectionViaMcomPresupuesto(tipoPresupuestoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoPresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoPresupuestoInstance">TipoPresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoPresupuestoCollectionViaMcomPresupuesto(tipoPresupuestoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingTipoPresupuestoCollectionViaMcomPresupuesto(tipoPresupuestoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoPresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoPresupuestoInstance">TipoPresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoPresupuestoCollectionViaMcomPresupuesto(tipoPresupuestoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetMultiUsingTipoPresupuestoCollectionViaMcomPresupuesto(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoPresupuestoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in TipoPresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoPresupuestoInstance">TipoPresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingTipoPresupuestoCollectionViaMcomPresupuesto(tipoPresupuestoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingTipoPresupuestoCollectionViaMcomPresupuesto(tipoPresupuestoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in TipoPresupuestoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="tipoPresupuestoInstance">TipoPresupuestoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingTipoPresupuestoCollectionViaMcomPresupuesto(tipoPresupuestoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetMultiUsingTipoPresupuestoCollectionViaMcomPresupuesto(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, tipoPresupuestoInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
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

			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in AlmacenEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="almacenInstance">AlmacenEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingAlmacenCollectionViaRecepcionOrdenCompra(almacenInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
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

			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetMultiUsingAlmacenCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, almacenInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
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

			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetMultiUsingOrdenCompraCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, ordenCompraInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in OrdenCompraEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="ordenCompraInstance">OrdenCompraEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingOrdenCompraCollectionViaRecepcionOrdenCompra(ordenCompraInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MotivoCancelacionCollection Object all MotivoCancelacionEntity objects which are related via a 
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

			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetMultiUsingOrdenCompraCollectionViaRecepcionOrdenCompra(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, ordenCompraInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves MotivoCancelacionEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves MotivoCancelacionEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves MotivoCancelacionEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all MotivoCancelacion entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all MotivoCancelacion entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all MotivoCancelacion entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MotivoCancelacionFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MotivoCancelacionFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MotivoCancelacionFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MotivoCancelacionFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As MotivoCancelacionFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified MotivoCancelacionEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">MotivoCancelacionEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all MotivoCancelacion entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As MotivoCancelacionEntity, updateFilter As IPredicate) As Integer
			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified MotivoCancelacionEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">MotivoCancelacionEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As MotivoCancelacionEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As MotivoCancelacionDAO = DAOFactory.CreateMotivoCancelacionDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMotivoCancelacionDAO()
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
