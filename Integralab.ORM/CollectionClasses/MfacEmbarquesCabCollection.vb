' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 11:59:43
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
	''' Collection class for storing and retrieving collections of MfacEmbarquesCabEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MfacEmbarquesCabCollection 
#Else
	<Serializable()> _
	Public Class MfacEmbarquesCabCollection 
#End If
		Inherits EntityCollectionBase(Of MfacEmbarquesCabEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New MfacEmbarquesCabEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of MfacEmbarquesCabEntity))
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

	
		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="mfacCatClientesInstance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <param name="mfacCatClientes_Instance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(mfacCatClientesInstance As IEntity, mfacCatClientes_Instance As IEntity) As Boolean
			Return GetMultiManyToOne(mfacCatClientesInstance, mfacCatClientes_Instance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="mfacCatClientesInstance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <param name="mfacCatClientes_Instance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(mfacCatClientesInstance As IEntity, mfacCatClientes_Instance As IEntity, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(mfacCatClientesInstance, mfacCatClientes_Instance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="mfacCatClientesInstance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <param name="mfacCatClientes_Instance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(mfacCatClientesInstance As IEntity, mfacCatClientes_Instance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(mfacCatClientesInstance, mfacCatClientes_Instance, maxNumberOfItemsToReturn, sortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="mfacCatClientesInstance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <param name="mfacCatClientes_Instance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Overridable Function GetMultiManyToOne(mfacCatClientesInstance As IEntity, mfacCatClientes_Instance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim validParameters As Boolean = False
			validParameters = validParameters Or Not (mfacCatClientesInstance Is Nothing)
			validParameters = validParameters Or Not (mfacCatClientes_Instance Is Nothing)
			If Not validParameters Then
				Return GetMulti(Filter, maxNumberOfItemsToReturn, sortClauses, Nothing, pageNumber, pageSize)
			End If
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If
			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMulti(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, Filter, mfacCatClientesInstance, mfacCatClientes_Instance, pageNumber, pageSize)
		End Function

		''' <summary>Deletes from the persistent storage all MfacEmbarquesCab entities which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.</summary>
		''' <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		''' <param name="mfacCatClientesInstance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <param name="mfacCatClientes_Instance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMultiManyToOne(mfacCatClientesInstance As IEntity, mfacCatClientes_Instance As IEntity) As Integer
			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, mfacCatClientesInstance, mfacCatClientes_Instance)
		End Function


		''' <summary>Updates in the persistent storage all MfacEmbarquesCab entities which have data in common with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.
		''' Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">MfacEmbarquesCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="mfacCatClientesInstance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <param name="mfacCatClientes_Instance">MfacCatClientesEntity instance to use as a filter for the MfacEmbarquesCabEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMultiManyToOne(entityWithNewValues As MfacEmbarquesCabEntity, mfacCatClientesInstance As IEntity, mfacCatClientes_Instance As IEntity) As Integer
			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, mfacCatClientesInstance, mfacCatClientes_Instance)
		End Function
	
	
		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in FacturasClientesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(facturasClientesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(facturasClientesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in FacturasClientesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(facturasClientesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(facturasClientesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in FacturasClientesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(facturasClientesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, facturasClientesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in FacturasClientesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(facturasClientesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(facturasClientesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in FacturasClientesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="facturasClientesCabInstance">FacturasClientesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(facturasClientesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingFacturasClientesCabCollectionViaMfacEmbarquesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, facturasClientesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatProductosCollectionViaMfacEmbarquesDet(msccatProductosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMsccatProductosCollectionViaMfacEmbarquesDet(msccatProductosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatProductosCollectionViaMfacEmbarquesDet(msccatProductosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMsccatProductosCollectionViaMfacEmbarquesDet(msccatProductosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatProductosCollectionViaMfacEmbarquesDet(msccatProductosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingMsccatProductosCollectionViaMfacEmbarquesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, msccatProductosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatProductosCollectionViaMfacEmbarquesDet(msccatProductosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMsccatProductosCollectionViaMfacEmbarquesDet(msccatProductosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMsccatProductosCollectionViaMfacEmbarquesDet(msccatProductosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingMsccatProductosCollectionViaMfacEmbarquesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, msccatProductosInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(mscmovtosAlmacenCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(mscmovtosAlmacenCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(mscmovtosAlmacenCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(mscmovtosAlmacenCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(mscmovtosAlmacenCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mscmovtosAlmacenCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(mscmovtosAlmacenCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(mscmovtosAlmacenCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MscmovtosAlmacenCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mscmovtosAlmacenCabInstance">MscmovtosAlmacenCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(mscmovtosAlmacenCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mscmovtosAlmacenCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in RegistroSacrificiosDecomisosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(registroSacrificiosDecomisosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(registroSacrificiosDecomisosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in RegistroSacrificiosDecomisosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(registroSacrificiosDecomisosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(registroSacrificiosDecomisosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in RegistroSacrificiosDecomisosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(registroSacrificiosDecomisosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, registroSacrificiosDecomisosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in RegistroSacrificiosDecomisosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(registroSacrificiosDecomisosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(registroSacrificiosDecomisosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in RegistroSacrificiosDecomisosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="registroSacrificiosDecomisosInstance">RegistroSacrificiosDecomisosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(registroSacrificiosDecomisosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, registroSacrificiosDecomisosInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MsccatMotivoDevolucionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatMotivoDevolucionInstance">MsccatMotivoDevolucionEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(msccatMotivoDevolucionInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(msccatMotivoDevolucionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MsccatMotivoDevolucionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatMotivoDevolucionInstance">MsccatMotivoDevolucionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(msccatMotivoDevolucionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(msccatMotivoDevolucionInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MsccatMotivoDevolucionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatMotivoDevolucionInstance">MsccatMotivoDevolucionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(msccatMotivoDevolucionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, msccatMotivoDevolucionInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MsccatMotivoDevolucionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatMotivoDevolucionInstance">MsccatMotivoDevolucionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(msccatMotivoDevolucionInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(msccatMotivoDevolucionInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MsccatMotivoDevolucionEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatMotivoDevolucionInstance">MsccatMotivoDevolucionEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(msccatMotivoDevolucionInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingMsccatMotivoDevolucionCollectionViaDevolucionProductos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, msccatMotivoDevolucionInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatProductosCollectionViaDevolucionProductos(msccatProductosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMsccatProductosCollectionViaDevolucionProductos(msccatProductosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatProductosCollectionViaDevolucionProductos(msccatProductosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMsccatProductosCollectionViaDevolucionProductos(msccatProductosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatProductosCollectionViaDevolucionProductos(msccatProductosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingMsccatProductosCollectionViaDevolucionProductos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, msccatProductosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMsccatProductosCollectionViaDevolucionProductos(msccatProductosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMsccatProductosCollectionViaDevolucionProductos(msccatProductosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MsccatProductosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="msccatProductosInstance">MsccatProductosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMsccatProductosCollectionViaDevolucionProductos(msccatProductosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingMsccatProductosCollectionViaDevolucionProductos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, msccatProductosInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ServiciosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="serviciosInstance">ServiciosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingServiciosCollectionViaServiciosXembarque(serviciosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingServiciosCollectionViaServiciosXembarque(serviciosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ServiciosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="serviciosInstance">ServiciosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingServiciosCollectionViaServiciosXembarque(serviciosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingServiciosCollectionViaServiciosXembarque(serviciosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ServiciosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="serviciosInstance">ServiciosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingServiciosCollectionViaServiciosXembarque(serviciosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingServiciosCollectionViaServiciosXembarque(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, serviciosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ServiciosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="serviciosInstance">ServiciosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingServiciosCollectionViaServiciosXembarque(serviciosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingServiciosCollectionViaServiciosXembarque(serviciosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this MfacEmbarquesCabCollection Object all MfacEmbarquesCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ServiciosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="serviciosInstance">ServiciosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingServiciosCollectionViaServiciosXembarque(serviciosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiUsingServiciosCollectionViaServiciosXembarque(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, serviciosInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves MfacEmbarquesCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves MfacEmbarquesCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves MfacEmbarquesCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all MfacEmbarquesCab entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all MfacEmbarquesCab entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all MfacEmbarquesCab entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MfacEmbarquesCabFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MfacEmbarquesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MfacEmbarquesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As MfacEmbarquesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As MfacEmbarquesCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified MfacEmbarquesCabEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">MfacEmbarquesCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all MfacEmbarquesCab entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As MfacEmbarquesCabEntity, updateFilter As IPredicate) As Integer
			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified MfacEmbarquesCabEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">MfacEmbarquesCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As MfacEmbarquesCabEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As MfacEmbarquesCabDAO = DAOFactory.CreateMfacEmbarquesCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMfacEmbarquesCabDAO()
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
