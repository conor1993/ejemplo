' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: martes, 26 de diciembre de 2017 16:41:16
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
	''' Collection class for storing and retrieving collections of SalidaGanadoCabEntity objects. 
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class SalidaGanadoCabCollection 
#Else
	<Serializable()> _
	Public Class SalidaGanadoCabCollection 
#End If
		Inherits EntityCollectionBase(Of SalidaGanadoCabEntity)
	
		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New(New SalidaGanadoCabEntityFactory())
		End Sub

		''' <summary>CTor</summary>
		''' <param name="initialContents">The initial contents of this collection.</param>
		Public Sub New( initialContents As IList(Of SalidaGanadoCabEntity))
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

	
		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="catRastrosInstance">CatRastrosEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="polizaInstance">PolizaEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(cabMovGanInstance As IEntity, mcecatLotesCabInstance As IEntity, mcgcatCausasMuerteInstance As IEntity, catRastrosInstance As IEntity, mcecatCorralesCabInstance As IEntity, polizaInstance As IEntity) As Boolean
			Return GetMultiManyToOne(cabMovGanInstance, mcecatLotesCabInstance, mcgcatCausasMuerteInstance, catRastrosInstance, mcecatCorralesCabInstance, polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="catRastrosInstance">CatRastrosEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="polizaInstance">PolizaEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(cabMovGanInstance As IEntity, mcecatLotesCabInstance As IEntity, mcgcatCausasMuerteInstance As IEntity, catRastrosInstance As IEntity, mcecatCorralesCabInstance As IEntity, polizaInstance As IEntity, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(cabMovGanInstance, mcecatLotesCabInstance, mcgcatCausasMuerteInstance, catRastrosInstance, mcecatCorralesCabInstance, polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="catRastrosInstance">CatRastrosEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="polizaInstance">PolizaEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Function GetMultiManyToOne(cabMovGanInstance As IEntity, mcecatLotesCabInstance As IEntity, mcgcatCausasMuerteInstance As IEntity, catRastrosInstance As IEntity, mcecatCorralesCabInstance As IEntity, polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression) As Boolean
			Return GetMultiManyToOne(cabMovGanInstance, mcecatLotesCabInstance, mcgcatCausasMuerteInstance, catRastrosInstance, mcecatCorralesCabInstance, polizaInstance, maxNumberOfItemsToReturn, sortClauses, Filter, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="catRastrosInstance">CatRastrosEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="polizaInstance">PolizaEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="filter">Extra filter to limit the resultset. Predicate expression can be Nothing, in which case it will be ignored.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Overridable Function GetMultiManyToOne(cabMovGanInstance As IEntity, mcecatLotesCabInstance As IEntity, mcgcatCausasMuerteInstance As IEntity, catRastrosInstance As IEntity, mcecatCorralesCabInstance As IEntity, polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, Filter As IPredicateExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			Dim validParameters As Boolean = False
			validParameters = validParameters Or Not (cabMovGanInstance Is Nothing)
			validParameters = validParameters Or Not (mcecatLotesCabInstance Is Nothing)
			validParameters = validParameters Or Not (mcgcatCausasMuerteInstance Is Nothing)
			validParameters = validParameters Or Not (catRastrosInstance Is Nothing)
			validParameters = validParameters Or Not (mcecatCorralesCabInstance Is Nothing)
			validParameters = validParameters Or Not (polizaInstance Is Nothing)
			If Not validParameters Then
				Return GetMulti(Filter, maxNumberOfItemsToReturn, sortClauses, Nothing, pageNumber, pageSize)
			End If
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If
			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMulti(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, Filter, cabMovGanInstance, mcecatLotesCabInstance, mcgcatCausasMuerteInstance, catRastrosInstance, mcecatCorralesCabInstance, polizaInstance, pageNumber, pageSize)
		End Function

		''' <summary>Deletes from the persistent storage all SalidaGanadoCab entities which have data in common
		''' with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.</summary>
		''' <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="catRastrosInstance">CatRastrosEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="polizaInstance">PolizaEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function DeleteMultiManyToOne(cabMovGanInstance As IEntity, mcecatLotesCabInstance As IEntity, mcgcatCausasMuerteInstance As IEntity, catRastrosInstance As IEntity, mcecatCorralesCabInstance As IEntity, polizaInstance As IEntity) As Integer
			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, cabMovGanInstance, mcecatLotesCabInstance, mcgcatCausasMuerteInstance, catRastrosInstance, mcecatCorralesCabInstance, polizaInstance)
		End Function


		''' <summary>Updates in the persistent storage all SalidaGanadoCab entities which have data in common with the specified related Entities.
		''' If one is omitted, that entity is not used as a filter.
		''' Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">SalidaGanadoCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="cabMovGanInstance">CabMovGanEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcgcatCausasMuerteInstance">McgcatCausasMuerteEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="catRastrosInstance">CatRastrosEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <param name="polizaInstance">PolizaEntity instance to use as a filter for the SalidaGanadoCabEntity objects to Return</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMultiManyToOne(entityWithNewValues As SalidaGanadoCabEntity, cabMovGanInstance As IEntity, mcecatLotesCabInstance As IEntity, mcgcatCausasMuerteInstance As IEntity, catRastrosInstance As IEntity, mcecatCorralesCabInstance As IEntity, polizaInstance As IEntity) As Integer
			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, cabMovGanInstance, mcecatLotesCabInstance, mcgcatCausasMuerteInstance, catRastrosInstance, mcecatCorralesCabInstance, polizaInstance)
		End Function
	
	
		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas(polizaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaCabFacturas(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaCabFacturas(polizaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingPolizaCollectionViaCabFacturas(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas(polizaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaCabFacturas(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingPolizaCollectionViaCabFacturas(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas_(polizaInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaCabFacturas_(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas_(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaCabFacturas_(polizaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas_(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingPolizaCollectionViaCabFacturas_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas_(polizaInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingPolizaCollectionViaCabFacturas_(polizaInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in PolizaEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="polizaInstance">PolizaEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingPolizaCollectionViaCabFacturas_(polizaInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingPolizaCollectionViaCabFacturas_(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, polizaInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
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

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatCorralesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatCorralesCabInstance">McecatCorralesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatCorralesCabCollectionViaProrraRec(mcecatCorralesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
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

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcecatCorralesCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatCorralesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
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

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaProrraRec(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
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

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaProrraRec(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoDet(mcecatLotesCabInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoDet(mcecatLotesCabInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, pageNumber As Integer, pageSize As Integer) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoDet(mcecatLotesCabInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoDet(mcecatLotesCabInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesCabEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesCabInstance">McecatLotesCabEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Overridable Function GetMultiManyToManyUsingMcecatLotesCabCollectionViaSalidaGanadoDet(mcecatLotesCabInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, prefetchPathToUse As IPrefetchPath) As Boolean
			If Not MyBase.SuppressClearInGetMulti Then
				Me.Clear()
			End If

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcecatLotesCabCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesCabInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
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

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcecatLotesDetCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesDetInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McecatLotesDetEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcecatLotesDetInstance">McecatLotesDetEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcecatLotesDetCollectionViaSalidaGanadoDet(mcecatLotesDetInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
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

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcecatLotesDetCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcecatLotesDetInstance, prefetchPathToUse)
		End Function
	
		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance As IEntity) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, 0, 0)
		End Function
		

		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance As IEntity, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
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

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, pageNumber, pageSize)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
		''' Relation of type 'm:n' with the passed in McgcatTiposdeGanadoEntity. 
		''' All current elements in the collection are removed from the collection.</summary>
		''' <param name="mcgcatTiposdeGanadoInstance">McgcatTiposdeGanadoEntity Object to be used as a filter in the m:n relation</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		''' <returns>true if the retrieval succeeded, false otherwise</returns>
		Public Function GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance As IEntity, prefetchPathToUse As IPrefetchPath) As Boolean
			Return GetMultiManyToManyUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(mcgcatTiposdeGanadoInstance, MyBase.MaxNumberOfItemsToReturn, MyBase.SortClauses, prefetchPathToUse)
		End Function


		''' <summary>Retrieves in this SalidaGanadoCabCollection Object all SalidaGanadoCabEntity objects which are related via a 
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

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiUsingMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(MyBase.Transaction, Me, maxNumberOfItemsToReturn, sortClauses, MyBase.EntityFactoryToUse, mcgcatTiposdeGanadoInstance, prefetchPathToUse)
		End Function
	

		''' <summary>Retrieves SalidaGanadoCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, Nothing, 0, 0)
		End Function


		''' <summary>Retrieves SalidaGanadoCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection) As DataTable
			Return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0)
		End Function


		''' <summary>Retrieves SalidaGanadoCabEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		''' <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to Return with this retrieval query.</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		''' <param name="relations">The set of relations to walk to construct to total query.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>DataTable with the rows requested.</returns>
		Public Shared Function GetMultiAsDataTable(selectFilter As IPredicate, maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, relations As IRelationCollection, pageNumber As Integer, pageSize As Integer) As DataTable
			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize)
		End Function


		''' <summary>Deletes from the persistent storage all SalidaGanadoCab entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		''' will result in a query removing all SalidaGanadoCab entities from the persistent storage</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate) As Integer
			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter)
		End Function


		''' <summary>Deletes from the persistent storage all SalidaGanadoCab entities which match with the specified filter, formulated in
		''' the predicate or predicate expression definition.</summary>
		''' <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overridable Overloads Function DeleteMulti(deleteFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.DeleteMulti(MyBase.Transaction, deleteFilter, relations)
		End Function


		''' <summary>Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As SalidaGanadoCabFieldIndex, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, Nothing, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As SalidaGanadoCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Nothing, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As SalidaGanadoCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate) As Object
			Return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, Filter, Nothing, Nothing)
		End Function

		''' <summary>Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		''' <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		''' <param name="expressionToExecute">The expression to execute. Can be Nothing</param>
		''' <param name="aggregateToApply">Aggregate function to apply. </param>
		''' <param name="filter">The filter to apply to retrieve the scalar</param>
		''' <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		''' <Returns>the scalar value requested</Returns>
		Public Overloads Function GetScalar(fieldIndex As SalidaGanadoCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, groupByClause As IGroupByCollection) As Object
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
		Public Overloads Overridable Function GetScalar(fieldIndex As SalidaGanadoCabFieldIndex, expressionToExecute As IExpression, aggregateToApply As AggregateFunction, Filter As IPredicate, relations As IRelationCollection, groupByClause As IGroupByCollection) As Object
			Dim fields As EntityFields = New EntityFields(1)
			fields(0) = EntityFieldFactory.Create(fieldIndex)
			If ((fields(0).ExpressionToApply Is Nothing) OrElse (Not expressionToExecute Is Nothing))
				fields(0).ExpressionToApply = expressionToExecute
			End If
			If ((fields(0).AggregateFunctionToApply = AggregateFunction.None) OrElse (aggregateToApply <> AggregateFunction.None))
				fields(0).AggregateFunctionToApply = aggregateToApply
			End If

			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.GetScalar(fields, MyBase.Transaction, Filter, relations, groupByClause)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified SalidaGanadoCabEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">SalidaGanadoCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		''' will result in an update action which will affect all SalidaGanadoCab entities.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As SalidaGanadoCabEntity, updateFilter As IPredicate) As Integer
			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter)
		End Function

		''' <summary>Updates in the persistent storage all entities which have data in common with the specified SalidaGanadoCabEntity. 
		''' If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		''' <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		''' <param name="entityWithNewValues">SalidaGanadoCabEntity instance which holds the new values for the matching entities to update. Only
		''' changed fields are taken into account</param>
		''' <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		''' <param name="relations">The set of relations to walk to construct the total query.</param>
		''' <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		Public Overloads Function UpdateMulti(entityWithNewValues As SalidaGanadoCabEntity, updateFilter As IPredicate, relations As IRelationCollection) As Integer
			Dim dao As SalidaGanadoCabDAO = DAOFactory.CreateSalidaGanadoCabDAO()
			Return dao.UpdateMulti(entityWithNewValues, MyBase.Transaction, updateFilter, relations)
		End Function

		''' <summary>Creats a New DAO instance so code which Is In the base Class can still use the proper DAO Object.</summary>
		Protected Overrides Overloads Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateSalidaGanadoCabDAO()
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
