﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:43:13
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Collections
#If Not CF Then
Imports System.Runtime.Serialization
#End If

Imports Integralab.ORM.HelperClasses
Imports Integralab.ORM.DaoClasses
Imports Integralab.ORM.EntityClasses
Imports Integralab.ORM.FactoryClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses

' __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
' __LLBLGENPRO_USER_CODE_REGION_END
Namespace Integralab.ORM.TypedListClasses
	''' <summary>
	''' Typed datatable for the list 'ListaCorrales'.<br/><br/>
	''' 
	''' </summary>
	''' <remarks>
	''' It embeds a fill method which accepts a filter.
	''' The code doesn't support any changing of data. Users who do that are on their own.
	''' It also doesn't support any event throwing. This list should be used as a base for readonly databinding
	''' or dataview construction.
	''' </remarks>
#If Not CF Then	
	<Serializable(), System.ComponentModel.DesignerCategory("Code"), ToolboxItem(True), DesignTimeVisible(True)> _
	Public Class ListaCorralesTypedList 
#Else
	Public Class ListaCorralesTypedList 
#End If	
		Inherits TypedListBase
		Implements IEnumerable, ITypedListLgp
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnIdCorral As DataColumn
		Private _columnNombreCorral As DataColumn
		Private _columnNomCorCorral As DataColumn
		Private _columnIdTipoCorral As DataColumn
		Private _columnCapacidad As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnTipoCorral As DataColumn
		Private _columnSuperficie As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END

		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' the number of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 8
#End Region
		
		''' <summary>
		''' Static CTor for setting up custom property hashtables. Is executed before the first instance of this
		''' class or derived classes is constructed. 
		''' </summary>
		Shared Sub New()
			SetupCustomPropertyHashtables()
		End Sub
		

		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
			MyBase.New("ListaCorrales")
			InitClass(False)
		End Sub


		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="obeyWeakRelations">The flag to signal the collection what kind of join statements to generate in the
		''' query statement. Weak relationships are relationships which are optional, for example a
		''' customer with no orders is possible, because the relationship between customer and order is based on a field in order.
		''' When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		''' set to false (which is the default), INNER JOIN statements are used.
		''' </param>
		Public Sub New(obeyWeakRelations As Boolean)
			MyBase.New("ListaCorrales")
			InitClass(obeyWeakRelations)
		End Sub


#If Not CF Then		
		''' <summary>
		''' Protected constructor for deserialization.
		''' </summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			InitMembers()
		End Sub
#End If

		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query. 
		''' Will use no sort filter, no select filter, will allow duplicate rows and will not limit the number of rows returned
		''' </summary>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill() As Boolean Implements ITypedListLgp.Fill
			Return Fill(0, Nothing, True, Nothing, Nothing, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query. 
		''' Will not use a filter, will allow duplicate rows.
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean Implements ITypedListLgp.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, True, Nothing, Nothing, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query. 
		''' Will not use a filter.
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean) As Boolean Implements ITypedListLgp.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, Nothing, Nothing, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Overridable Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate) As Boolean Implements ITypedListLgp.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, Nothing, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		''' <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		''' used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate, transactionToUse As ITransaction) As Boolean Implements ITypedListLgp.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		''' <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		''' used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		''' <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate, transactionToUse As ITransaction, groupByClause As IGroupByCollection) As Boolean Implements ITypedListLgp.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, groupByClause, 0, 0)
		End Function

		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		''' <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		''' used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		''' <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Overridable Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate, transactionToUse As ITransaction, groupByClause As IGroupByCollection, pageNumber As Integer, pageSize As Integer) As Boolean Implements ITypedListLgp.Fill
			' Build resultset
			Dim fieldsInResultset As IEntityFields = BuildResultset()

			' Build relationset
			Dim relations As IRelationCollection = BuildRelationSet()

			Dim dao As TypedListDAO = DAOFactory.CreateTypedListDAO()
			Return dao.GetMultiAsDataTable(fieldsInResultset, Me, maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, allowDuplicates, groupByClause, transactionToUse, pageNumber, pageSize)
		End Function


		''' <summary>
		''' Gets the number of rows in the database for this typed view, not skipping duplicates
		''' </summary>
		''' <returns>the number of rows In the Set defined by the passed In query elements</returns>
		Public Function GetDbCount() As Integer Implements ITypedListLgp.GetDbCount
			Return GetDbCount(True, Nothing, Nothing, Nothing)
		End Function
		
		
		''' <summary>
		''' Gets the number of rows in the database for this typed view.
		''' </summary>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		''' <returns>the number of rows In the Set defined by the passed In query elements</returns>
		Public Function GetDbCount(allowDuplicates As Boolean) As Integer Implements ITypedListLgp.GetDbCount
			Return GetDbCount(allowDuplicates, Nothing, Nothing, Nothing)
		End Function


		''' <summary>
		''' Gets the number of rows in the database for this typed view.
		''' </summary>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		''' <param name="filter">The filter to apply for the count retrieval</param>
		''' <returns>the number of rows In the Set defined by the passed In query elements</returns>
		Public Function GetDbCount(allowDuplicates As Boolean, filter As IPredicateExpression) As Integer Implements ITypedListLgp.GetDbCount
			Return GetDbCount(allowDuplicates, filter, Nothing, Nothing)
		End Function


		''' <summary>
		''' Gets the number of rows in the database for this typed view.
		''' </summary>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		''' <param name="filter">The filter to apply for the count retrieval</param>
		''' <param name="relations">The relations for the filter to apply</param>
		''' <returns>the number of rows In the Set defined by the passed In query elements</returns>
		Public Function GetDbCount(allowDuplicates As Boolean, Filter As IPredicateExpression, relations As IRelationCollection) As Integer Implements ITypedListLgp.GetDbCount
			Return GetDbCount(allowDuplicates, filter, relations, Nothing)
		End Function


		''' <summary>
		''' Gets the number of rows In the database For this typed list.
		''' </summary>
		''' <param name="allowDuplicates">Flag To allow duplicate rows (True) Or Not (False)</param>
		''' <param name="filter">The filter To apply For the count retrieval</param>
		''' <param name="relations">The relations For the filter To apply</param>
		''' <param name="groupByClause">group by clause To embed In the query</param>
		''' <returns>the number of rows In the Set defined by the passed In query elements</returns>
		Public Overridable Function GetDbCount(allowDuplicates As Boolean, Filter As IPredicateExpression, relations As IRelationCollection, groupByClause As GroupByCollection) As Integer Implements ITypedListLgp.GetDbCount
			Dim fieldsInResultset As IEntityFields = BuildResultset()
			Dim relationsToUse As IRelationCollection = BuildRelationSet()
			If Not relations Is Nothing Then
				Dim i As Integer
				For i = 0 To relations.Count -1
					relationsToUse.Add(relations(i))
				Next
			End If

			Dim dao As TypedListDAO = DAOFactory.CreateTypedListDAO()
			Return dao.GetDbCount(fieldsInResultset, Nothing, filter, relationsToUse, groupByClause, allowDuplicates)
		End Function


		''' <summary>
		''' Gets the enumerator for this class.
		''' </summary>
		''' <returns>Enumerator for this class.</returns>
		Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
			Return Me.Rows.GetEnumerator()
		End Function


		''' <summary>
		''' Builds the relation set for this typed list.
		''' </summary>
		''' <returns>ready to use relation set</returns>
		Overridable Public Function BuildRelationSet() As IRelationCollection Implements ITypedListLgp.BuildRelationSet
			Dim toReturn As IRelationCollection = New RelationCollection()
			toReturn.ObeyWeakRelations = MyBase.ObeyWeakRelations


			
			' __LLBLGENPRO_USER_CODE_REGION_START AdditionalRelations
			' __LLBLGENPRO_USER_CODE_REGION_END
			OnRelationSetBuilt(toReturn)
			Return toReturn
		End Function


		''' <summary>
		''' Builds the resultset fields.
		''' </summary>
		''' <returns>ready to use resultset</returns>
		Overridable Public Function BuildResultset() As IEntityFields Implements ITypedListLgp.BuildResultset
			Dim toReturn As New ResultsetFields(AmountOfFields)

			toReturn.DefineField(McecatCorralesCabFields.IdCorral, 0, "IdCorral", "", AggregateFunction.None)
			toReturn.DefineField(McecatCorralesCabFields.NombreCorral, 1, "NombreCorral", "", AggregateFunction.None)
			toReturn.DefineField(McecatCorralesCabFields.NomCorCorral, 2, "NomCorCorral", "", AggregateFunction.None)
			toReturn.DefineField(McecatCorralesCabFields.IdTipoCorral, 3, "IdTipoCorral", "", AggregateFunction.None)
			toReturn.DefineField(McecatCorralesCabFields.Capacidad, 4, "Capacidad", "", AggregateFunction.None)
			toReturn.DefineField(McecatCorralesCabFields.Estatus, 5, "Estatus", "", AggregateFunction.None)
			toReturn.DefineField(McecatCorralesCabFields.TipoCorral, 6, "TipoCorral", "", AggregateFunction.None)
			toReturn.DefineField(McecatCorralesCabFields.Superficie, 7, "Superficie", "", AggregateFunction.None)
			
			' __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields
			' be sure To Call toReturn.Expand(number of New fields) first. 
			' __LLBLGENPRO_USER_CODE_REGION_END
			OnResultsetBuilt(toReturn)
			Return toReturn
		End Function


		''' <summary>
		''' Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.
		''' </summary>
		''' <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		''' <returns>the new typed datarow</returns>
		Protected Overrides Function NewRowFromBuilder(rowBuilder As DataRowBuilder) As DataRow
			Return New ListaCorralesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		''' <param name="obeyWeakRelations">flag for the internal used relations object</param>
		Private Sub InitClass(obeyWeakRelations As Boolean)
			
			_columnIdCorral = New DataColumn("IdCorral", GetType(System.String), Nothing, MappingType.Element)
			_columnIdCorral.ReadOnly = True
			_columnIdCorral.Caption = "IdCorral"
			Me.Columns.Add(_columnIdCorral)

			_columnNombreCorral = New DataColumn("NombreCorral", GetType(System.String), Nothing, MappingType.Element)
			_columnNombreCorral.ReadOnly = True
			_columnNombreCorral.Caption = "NombreCorral"
			Me.Columns.Add(_columnNombreCorral)

			_columnNomCorCorral = New DataColumn("NomCorCorral", GetType(System.String), Nothing, MappingType.Element)
			_columnNomCorCorral.ReadOnly = True
			_columnNomCorCorral.Caption = "NomCorCorral"
			Me.Columns.Add(_columnNomCorCorral)

			_columnIdTipoCorral = New DataColumn("IdTipoCorral", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdTipoCorral.ReadOnly = True
			_columnIdTipoCorral.Caption = "IdTipoCorral"
			Me.Columns.Add(_columnIdTipoCorral)

			_columnCapacidad = New DataColumn("Capacidad", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCapacidad.ReadOnly = True
			_columnCapacidad.Caption = "Capacidad"
			Me.Columns.Add(_columnCapacidad)

			_columnEstatus = New DataColumn("Estatus", GetType(System.Int16), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnTipoCorral = New DataColumn("TipoCorral", GetType(System.Int16), Nothing, MappingType.Element)
			_columnTipoCorral.ReadOnly = True
			_columnTipoCorral.Caption = "TipoCorral"
			Me.Columns.Add(_columnTipoCorral)

			_columnSuperficie = New DataColumn("Superficie", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSuperficie.ReadOnly = True
			_columnSuperficie.Caption = "Superficie"
			Me.Columns.Add(_columnSuperficie)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
			MyBase.ObeyWeakRelations = obeyWeakRelations
			OnInitialized()
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnIdCorral = Me.Columns("IdCorral")
			_columnNombreCorral = Me.Columns("NombreCorral")
			_columnNomCorCorral = Me.Columns("NomCorCorral")
			_columnIdTipoCorral = Me.Columns("IdTipoCorral")
			_columnCapacidad = Me.Columns("Capacidad")
			_columnEstatus = Me.Columns("Estatus")
			_columnTipoCorral = Me.Columns("TipoCorral")
			_columnSuperficie = Me.Columns("Superficie")
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the hashtables for the TypedList type and TypedList field custom properties. 
		''' </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Hashtable()
			_fieldsCustomProperties = New Hashtable()

			' Add custom properties of this type

			' Add per Field a new Hashtable with its custom properties, indexed by the name of the field.
			Dim fieldHashtable As Hashtable = Nothing
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCorral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NombreCorral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NomCorCorral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdTipoCorral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Capacidad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoCorral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Superficie", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(ListaCorralesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As ListaCorralesTypedList = CType(MyBase.Clone(), ListaCorralesTypedList)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New ListaCorralesTypedList()
		End Function
#End If

#Region "Class Property Declarations"
		''' <summary>
		''' Returns the number of rows in this typed list.
		''' </summary>
		<System.ComponentModel.Browsable(False)> _
		Public Overrides Overloads ReadOnly Property Count As Integer
			Get 
				Return Me.Rows.Count
			End Get
		End Property
		
		''' <summary>
		''' The custom properties for this TypedList type.
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public Shared ReadOnly Property CustomProperties() As Hashtable
			Get
				Return _customProperties
			End Get
		End Property

		''' <summary>
		''' The custom properties for the type of this TypedList instance.
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<System.ComponentModel.Browsable(False)> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Hashtable
			Get
				Return ListaCorralesTypedList.CustomProperties
			End Get
		End Property

		''' <summary>
		''' The custom properties for the fields of this TypedList type. The returned Hashtable contains per fieldname a hashtable of name-value
		''' pairs. 
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public Shared ReadOnly Property FieldsCustomProperties() As Hashtable
			Get
				Return _fieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' The custom properties for the fields of the type of this TypedList instance. The returned Hashtable contains per fieldname a hashtable of name-value
		''' pairs. 
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<System.ComponentModel.Browsable(False)> _
		Public Overridable ReadOnly Property FieldsCustomPropertiesOfType() As Hashtable
			Get
				Return ListaCorralesTypedList.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed list
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As ListaCorralesRow
			Get 
				Return CType(Me.Rows(index), ListaCorralesRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedList field IdCorral
		''' </summary>
		ReadOnly Friend Property IdCorralColumn As DataColumn
			Get 
				Return _columnIdCorral 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field NombreCorral
		''' </summary>
		ReadOnly Friend Property NombreCorralColumn As DataColumn
			Get 
				Return _columnNombreCorral 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field NomCorCorral
		''' </summary>
		ReadOnly Friend Property NomCorCorralColumn As DataColumn
			Get 
				Return _columnNomCorCorral 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field IdTipoCorral
		''' </summary>
		ReadOnly Friend Property IdTipoCorralColumn As DataColumn
			Get 
				Return _columnIdTipoCorral 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Capacidad
		''' </summary>
		ReadOnly Friend Property CapacidadColumn As DataColumn
			Get 
				Return _columnCapacidad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Estatus
		''' </summary>
		ReadOnly Friend Property EstatusColumn As DataColumn
			Get 
				Return _columnEstatus 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field TipoCorral
		''' </summary>
		ReadOnly Friend Property TipoCorralColumn As DataColumn
			Get 
				Return _columnTipoCorral 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Superficie
		''' </summary>
		ReadOnly Friend Property SuperficieColumn As DataColumn
			Get 
				Return _columnSuperficie 
			End Get
		End Property
    
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties
		' __LLBLGENPRO_USER_CODE_REGION_END
 #End Region

#Region "Custom TypedList code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

#Region "Included Code"

#End Region
	End Class


	''' <summary>
	''' Typed datarow for the typed datatable ListaCorrales
	''' </summary>
	Public Class ListaCorralesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _parent As ListaCorralesTypedList
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, ListaCorralesTypedList)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedList field IdCorral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatCorralesCab.IdCorral</remarks>
		Public Property [IdCorral]() As System.String
			Get 
				If IsIdCorralNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdCorralColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdCorralColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field IdCorral is NULL, False otherwise.
		''' </summary>
		Public Function IsIdCorralNull() As Boolean
			Return IsNull(_parent.IdCorralColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field IdCorral to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdCorralNull() 
			Me(_parent.IdCorralColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field NombreCorral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatCorralesCab.NombreCorral</remarks>
		Public Property [NombreCorral]() As System.String
			Get 
				If IsNombreCorralNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NombreCorralColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NombreCorralColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field NombreCorral is NULL, False otherwise.
		''' </summary>
		Public Function IsNombreCorralNull() As Boolean
			Return IsNull(_parent.NombreCorralColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field NombreCorral to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNombreCorralNull() 
			Me(_parent.NombreCorralColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field NomCorCorral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatCorralesCab.NomCorCorral</remarks>
		Public Property [NomCorCorral]() As System.String
			Get 
				If IsNomCorCorralNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NomCorCorralColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NomCorCorralColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field NomCorCorral is NULL, False otherwise.
		''' </summary>
		Public Function IsNomCorCorralNull() As Boolean
			Return IsNull(_parent.NomCorCorralColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field NomCorCorral to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNomCorCorralNull() 
			Me(_parent.NomCorCorralColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field IdTipoCorral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatCorralesCab.IdTipoCorral</remarks>
		Public Property [IdTipoCorral]() As System.Int32
			Get 
				If IsIdTipoCorralNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdTipoCorralColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdTipoCorralColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field IdTipoCorral is NULL, False otherwise.
		''' </summary>
		Public Function IsIdTipoCorralNull() As Boolean
			Return IsNull(_parent.IdTipoCorralColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field IdTipoCorral to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdTipoCorralNull() 
			Me(_parent.IdTipoCorralColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Capacidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatCorralesCab.Capacidad</remarks>
		Public Property [Capacidad]() As System.Decimal
			Get 
				If IsCapacidadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CapacidadColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CapacidadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Capacidad is NULL, False otherwise.
		''' </summary>
		Public Function IsCapacidadNull() As Boolean
			Return IsNull(_parent.CapacidadColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Capacidad to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCapacidadNull() 
			Me(_parent.CapacidadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatCorralesCab.Estatus</remarks>
		Public Property [Estatus]() As System.Int16
			Get 
				If IsEstatusNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.EstatusColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.EstatusColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Estatus is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusNull() As Boolean
			Return IsNull(_parent.EstatusColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Estatus to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusNull() 
			Me(_parent.EstatusColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field TipoCorral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatCorralesCab.TipoCorral</remarks>
		Public Property [TipoCorral]() As System.Int16
			Get 
				If IsTipoCorralNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.TipoCorralColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.TipoCorralColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field TipoCorral is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoCorralNull() As Boolean
			Return IsNull(_parent.TipoCorralColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field TipoCorral to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoCorralNull() 
			Me(_parent.TipoCorralColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Superficie<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatCorralesCab.Superficie</remarks>
		Public Property [Superficie]() As System.Decimal
			Get 
				If IsSuperficieNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SuperficieColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SuperficieColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Superficie is NULL, False otherwise.
		''' </summary>
		Public Function IsSuperficieNull() As Boolean
			Return IsNull(_parent.SuperficieColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Superficie to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSuperficieNull() 
			Me(_parent.SuperficieColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedList Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
