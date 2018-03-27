' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:24
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
	''' Collection class for storing and retrieving collections of PolizaEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class PolizaCollection 
#Else
	<Serializable()> _
	Public Class PolizaCollection 
#End If
		Inherits EntityCollectionBase(Of PolizaEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New PolizaEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of PolizaEntity))
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

	
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas(salidaGanadoCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas(salidaGanadoCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaCabFacturas(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas(salidaGanadoCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaCabFacturas(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas_(salidaGanadoCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas_(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas_(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas_(salidaGanadoCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas_(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaCabFacturas_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas_(salidaGanadoCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas_(salidaGanadoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in SalidaGanadoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="salidaGanadoCabInstance">SalidaGanadoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingSalidaGanadoCabCollectionViaCabFacturas_(salidaGanadoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingSalidaGanadoCabCollectionViaCabFacturas_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, salidaGanadoCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="metodoCabInstance">MetodoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="metodoCabInstance">MetodoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingMetodoCabCollectionViaGastosDepartamentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, metodoCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in MetodoCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="metodoCabInstance">MetodoCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMetodoCabCollectionViaGastosDepartamentos(metodoCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingMetodoCabCollectionViaGastosDepartamentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, metodoCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaGastosDepartamentos(cuentaContableInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaGastosDepartamentos(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaGastosDepartamentos(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaGastosDepartamentos(cuentaContableInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaGastosDepartamentos(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaGastosDepartamentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaGastosDepartamentos(cuentaContableInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaGastosDepartamentos(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaContableCollectionViaGastosDepartamentos(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaGastosDepartamentos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CabMovGanEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCabMovGanCollectionViaSalidaGanadoCab(cabMovGanInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCabMovGanCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cabMovGanInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoCab(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatCausasMuerteInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatCausasMuerteEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(mcgcatCausasMuerteInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingMcgcatCausasMuerteCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatCausasMuerteInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCatRastrosCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catRastrosInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CatRastrosEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="catRastrosInstance">CatRastrosEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCatRastrosCollectionViaSalidaGanadoCab(catRastrosInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCatRastrosCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, catRastrosInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
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

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaSalidaGanadoCab(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque(beneficiarioInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingBeneficiarioCollectionViaCheque(beneficiarioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque(beneficiarioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingBeneficiarioCollectionViaCheque(beneficiarioInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque(beneficiarioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingBeneficiarioCollectionViaCheque(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, beneficiarioInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque(beneficiarioInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingBeneficiarioCollectionViaCheque(beneficiarioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque(beneficiarioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingBeneficiarioCollectionViaCheque(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, beneficiarioInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque_(beneficiarioInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingBeneficiarioCollectionViaCheque_(beneficiarioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque_(beneficiarioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingBeneficiarioCollectionViaCheque_(beneficiarioInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque_(beneficiarioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingBeneficiarioCollectionViaCheque_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, beneficiarioInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque_(beneficiarioInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingBeneficiarioCollectionViaCheque_(beneficiarioInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in BeneficiarioEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="beneficiarioInstance">BeneficiarioEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingBeneficiarioCollectionViaCheque_(beneficiarioInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingBeneficiarioCollectionViaCheque_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, beneficiarioInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque(cuentaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque(cuentaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaCheque(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque(cuentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaCollectionViaCheque(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaCheque(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque__(cuentaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque__(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque__(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque__(cuentaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque__(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaCheque__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque__(cuentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque__(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaCollectionViaCheque__(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaCheque__(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque_(cuentaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque_(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque_(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque_(cuentaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque_(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaCheque_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque_(cuentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque_(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaCollectionViaCheque_(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaCheque_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque___(cuentaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque___(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque___(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque___(cuentaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque___(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaCheque___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaCheque___(cuentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaCheque___(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaCollectionViaCheque___(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaCheque___(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos(cuentaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos(cuentaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaUsrBanDepositos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos(cuentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaUsrBanDepositos(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos_(cuentaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos_(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos_(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos_(cuentaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos_(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaUsrBanDepositos_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos_(cuentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos_(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaCollectionViaUsrBanDepositos_(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaUsrBanDepositos_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaPolizaDetalle(cuentaContableInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaPolizaDetalle(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaPolizaDetalle(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaPolizaDetalle(cuentaContableInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaPolizaDetalle(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaPolizaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaContableCollectionViaPolizaDetalle(cuentaContableInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaContableCollectionViaPolizaDetalle(cuentaContableInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaContableEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaContableInstance">CuentaContableEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaContableCollectionViaPolizaDetalle(cuentaContableInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaContableCollectionViaPolizaDetalle(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaContableInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrCxppagosProveedores(cuentaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaUsrCxppagosProveedores(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrCxppagosProveedores(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaUsrCxppagosProveedores(cuentaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrCxppagosProveedores(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaUsrCxppagosProveedores(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingCuentaCollectionViaUsrCxppagosProveedores(cuentaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingCuentaCollectionViaUsrCxppagosProveedores(cuentaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in CuentaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="cuentaInstance">CuentaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingCuentaCollectionViaUsrCxppagosProveedores(cuentaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingCuentaCollectionViaUsrCxppagosProveedores(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, cuentaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaUsrCxppagosProveedores(proveedorInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaUsrCxppagosProveedores(proveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaUsrCxppagosProveedores(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaUsrCxppagosProveedores(proveedorInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaUsrCxppagosProveedores(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingProveedorCollectionViaUsrCxppagosProveedores(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, proveedorInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingProveedorCollectionViaUsrCxppagosProveedores(proveedorInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingProveedorCollectionViaUsrCxppagosProveedores(proveedorInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this PolizaCollection Object all PolizaEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in ProveedorEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="proveedorInstance">ProveedorEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingProveedorCollectionViaUsrCxppagosProveedores(proveedorInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiUsingProveedorCollectionViaUsrCxppagosProveedores(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, proveedorInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves PolizaEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves PolizaEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves PolizaEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all Poliza entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all Poliza entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all Poliza entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As PolizaFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As PolizaFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As PolizaFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As PolizaFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As PolizaFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified PolizaEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">PolizaEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all Poliza entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As PolizaEntity, updateFilter As IPredicate) As Integer
			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified PolizaEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">PolizaEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As PolizaEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As PolizaDAO = DAOFactory.CreatePolizaDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreatePolizaDAO()
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
