' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de febrero de 2018 16:33:27
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
	''' Typed datatable for the list 'ListaLotes'.<br/><br/>
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
	Public Class ListaLotesTypedList 
#Else
	Public Class ListaLotesTypedList 
#End If	
		Inherits TypedListBase
		Implements IEnumerable, ITypedListLgp
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnIdLote As DataColumn
		Private _columnIdCorral As DataColumn
		Private _columnNombreLote As DataColumn
		Private _columnNomCorLote As DataColumn
		Private _columnSaldoKilos As DataColumn
		Private _columnSaldoKilosAlim As DataColumn
		Private _columnSaldoImpteAlim As DataColumn
		Private _columnSaldoImpteMed As DataColumn
		Private _columnSaldoImpte As DataColumn
		Private _columnSaldoCabezas As DataColumn
		Private _columnFechaInicio As DataColumn
		Private _columnSaldoCostoInd As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END

		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' the number of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 12
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
			MyBase.New("ListaLotes")
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
			MyBase.New("ListaLotes")
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

			toReturn.DefineField(McecatLotesCabFields.IdLote, 0, "IdLote", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.IdCorral, 1, "IdCorral", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.NombreLote, 2, "NombreLote", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.NomCorLote, 3, "NomCorLote", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.SaldoKilos, 4, "SaldoKilos", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.SaldoKilosAlim, 5, "SaldoKilosAlim", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.SaldoImpteAlim, 6, "SaldoImpteAlim", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.SaldoImpteMed, 7, "SaldoImpteMed", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.SaldoImpte, 8, "SaldoImpte", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.SaldoCabezas, 9, "SaldoCabezas", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.FechaCaptura, 10, "FechaInicio", "", AggregateFunction.None)
			toReturn.DefineField(McecatLotesCabFields.SaldoCostoInd, 11, "SaldoCostoInd", "", AggregateFunction.None)
			
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
			Return New ListaLotesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		''' <param name="obeyWeakRelations">flag for the internal used relations object</param>
		Private Sub InitClass(obeyWeakRelations As Boolean)
			
			_columnIdLote = New DataColumn("IdLote", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdLote.ReadOnly = True
			_columnIdLote.Caption = "IdLote"
			Me.Columns.Add(_columnIdLote)

			_columnIdCorral = New DataColumn("IdCorral", GetType(System.String), Nothing, MappingType.Element)
			_columnIdCorral.ReadOnly = True
			_columnIdCorral.Caption = "IdCorral"
			Me.Columns.Add(_columnIdCorral)

			_columnNombreLote = New DataColumn("NombreLote", GetType(System.String), Nothing, MappingType.Element)
			_columnNombreLote.ReadOnly = True
			_columnNombreLote.Caption = "NombreLote"
			Me.Columns.Add(_columnNombreLote)

			_columnNomCorLote = New DataColumn("NomCorLote", GetType(System.String), Nothing, MappingType.Element)
			_columnNomCorLote.ReadOnly = True
			_columnNomCorLote.Caption = "NomCorLote"
			Me.Columns.Add(_columnNomCorLote)

			_columnSaldoKilos = New DataColumn("SaldoKilos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSaldoKilos.ReadOnly = True
			_columnSaldoKilos.Caption = "SaldoKilos"
			Me.Columns.Add(_columnSaldoKilos)

			_columnSaldoKilosAlim = New DataColumn("SaldoKilosAlim", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSaldoKilosAlim.ReadOnly = True
			_columnSaldoKilosAlim.Caption = "SaldoKilosAlim"
			Me.Columns.Add(_columnSaldoKilosAlim)

			_columnSaldoImpteAlim = New DataColumn("SaldoImpteAlim", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSaldoImpteAlim.ReadOnly = True
			_columnSaldoImpteAlim.Caption = "SaldoImpteAlim"
			Me.Columns.Add(_columnSaldoImpteAlim)

			_columnSaldoImpteMed = New DataColumn("SaldoImpteMed", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSaldoImpteMed.ReadOnly = True
			_columnSaldoImpteMed.Caption = "SaldoImpteMed"
			Me.Columns.Add(_columnSaldoImpteMed)

			_columnSaldoImpte = New DataColumn("SaldoImpte", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSaldoImpte.ReadOnly = True
			_columnSaldoImpte.Caption = "SaldoImpte"
			Me.Columns.Add(_columnSaldoImpte)

			_columnSaldoCabezas = New DataColumn("SaldoCabezas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSaldoCabezas.ReadOnly = True
			_columnSaldoCabezas.Caption = "SaldoCabezas"
			Me.Columns.Add(_columnSaldoCabezas)

			_columnFechaInicio = New DataColumn("FechaInicio", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaInicio.ReadOnly = True
			_columnFechaInicio.Caption = "FechaInicio"
			Me.Columns.Add(_columnFechaInicio)

			_columnSaldoCostoInd = New DataColumn("SaldoCostoInd", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSaldoCostoInd.ReadOnly = True
			_columnSaldoCostoInd.Caption = "SaldoCostoInd"
			Me.Columns.Add(_columnSaldoCostoInd)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
			MyBase.ObeyWeakRelations = obeyWeakRelations
			OnInitialized()
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnIdLote = Me.Columns("IdLote")
			_columnIdCorral = Me.Columns("IdCorral")
			_columnNombreLote = Me.Columns("NombreLote")
			_columnNomCorLote = Me.Columns("NomCorLote")
			_columnSaldoKilos = Me.Columns("SaldoKilos")
			_columnSaldoKilosAlim = Me.Columns("SaldoKilosAlim")
			_columnSaldoImpteAlim = Me.Columns("SaldoImpteAlim")
			_columnSaldoImpteMed = Me.Columns("SaldoImpteMed")
			_columnSaldoImpte = Me.Columns("SaldoImpte")
			_columnSaldoCabezas = Me.Columns("SaldoCabezas")
			_columnFechaInicio = Me.Columns("FechaInicio")
			_columnSaldoCostoInd = Me.Columns("SaldoCostoInd")
			
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

			_fieldsCustomProperties.Add("IdLote", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCorral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NombreLote", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NomCorLote", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SaldoKilos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SaldoKilosAlim", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SaldoImpteAlim", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SaldoImpteMed", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SaldoImpte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SaldoCabezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaInicio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SaldoCostoInd", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(ListaLotesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As ListaLotesTypedList = CType(MyBase.Clone(), ListaLotesTypedList)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New ListaLotesTypedList()
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
				Return ListaLotesTypedList.CustomProperties
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
				Return ListaLotesTypedList.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed list
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As ListaLotesRow
			Get 
				Return CType(Me.Rows(index), ListaLotesRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedList field IdLote
		''' </summary>
		ReadOnly Friend Property IdLoteColumn As DataColumn
			Get 
				Return _columnIdLote 
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
		''' Returns the column Object belonging to the TypedList field NombreLote
		''' </summary>
		ReadOnly Friend Property NombreLoteColumn As DataColumn
			Get 
				Return _columnNombreLote 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field NomCorLote
		''' </summary>
		ReadOnly Friend Property NomCorLoteColumn As DataColumn
			Get 
				Return _columnNomCorLote 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field SaldoKilos
		''' </summary>
		ReadOnly Friend Property SaldoKilosColumn As DataColumn
			Get 
				Return _columnSaldoKilos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field SaldoKilosAlim
		''' </summary>
		ReadOnly Friend Property SaldoKilosAlimColumn As DataColumn
			Get 
				Return _columnSaldoKilosAlim 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field SaldoImpteAlim
		''' </summary>
		ReadOnly Friend Property SaldoImpteAlimColumn As DataColumn
			Get 
				Return _columnSaldoImpteAlim 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field SaldoImpteMed
		''' </summary>
		ReadOnly Friend Property SaldoImpteMedColumn As DataColumn
			Get 
				Return _columnSaldoImpteMed 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field SaldoImpte
		''' </summary>
		ReadOnly Friend Property SaldoImpteColumn As DataColumn
			Get 
				Return _columnSaldoImpte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field SaldoCabezas
		''' </summary>
		ReadOnly Friend Property SaldoCabezasColumn As DataColumn
			Get 
				Return _columnSaldoCabezas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field FechaInicio
		''' </summary>
		ReadOnly Friend Property FechaInicioColumn As DataColumn
			Get 
				Return _columnFechaInicio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field SaldoCostoInd
		''' </summary>
		ReadOnly Friend Property SaldoCostoIndColumn As DataColumn
			Get 
				Return _columnSaldoCostoInd 
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
	''' Typed datarow for the typed datatable ListaLotes
	''' </summary>
	Public Class ListaLotesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _parent As ListaLotesTypedList
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, ListaLotesTypedList)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedList field IdLote<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.IdLote</remarks>
		Public Property [IdLote]() As System.Int32
			Get 
				If IsIdLoteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdLoteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdLoteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field IdLote is NULL, False otherwise.
		''' </summary>
		Public Function IsIdLoteNull() As Boolean
			Return IsNull(_parent.IdLoteColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field IdLote to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdLoteNull() 
			Me(_parent.IdLoteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field IdCorral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.IdCorral</remarks>
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
		''' Gets / sets the value of the TypedList field NombreLote<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.NombreLote</remarks>
		Public Property [NombreLote]() As System.String
			Get 
				If IsNombreLoteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NombreLoteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NombreLoteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field NombreLote is NULL, False otherwise.
		''' </summary>
		Public Function IsNombreLoteNull() As Boolean
			Return IsNull(_parent.NombreLoteColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field NombreLote to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNombreLoteNull() 
			Me(_parent.NombreLoteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field NomCorLote<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.NomCorLote</remarks>
		Public Property [NomCorLote]() As System.String
			Get 
				If IsNomCorLoteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NomCorLoteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NomCorLoteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field NomCorLote is NULL, False otherwise.
		''' </summary>
		Public Function IsNomCorLoteNull() As Boolean
			Return IsNull(_parent.NomCorLoteColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field NomCorLote to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNomCorLoteNull() 
			Me(_parent.NomCorLoteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field SaldoKilos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.SaldoKilos</remarks>
		Public Property [SaldoKilos]() As System.Decimal
			Get 
				If IsSaldoKilosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SaldoKilosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SaldoKilosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field SaldoKilos is NULL, False otherwise.
		''' </summary>
		Public Function IsSaldoKilosNull() As Boolean
			Return IsNull(_parent.SaldoKilosColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field SaldoKilos to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSaldoKilosNull() 
			Me(_parent.SaldoKilosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field SaldoKilosAlim<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.SaldoKilosAlim</remarks>
		Public Property [SaldoKilosAlim]() As System.Decimal
			Get 
				If IsSaldoKilosAlimNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SaldoKilosAlimColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SaldoKilosAlimColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field SaldoKilosAlim is NULL, False otherwise.
		''' </summary>
		Public Function IsSaldoKilosAlimNull() As Boolean
			Return IsNull(_parent.SaldoKilosAlimColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field SaldoKilosAlim to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSaldoKilosAlimNull() 
			Me(_parent.SaldoKilosAlimColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field SaldoImpteAlim<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.SaldoImpteAlim</remarks>
		Public Property [SaldoImpteAlim]() As System.Decimal
			Get 
				If IsSaldoImpteAlimNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SaldoImpteAlimColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SaldoImpteAlimColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field SaldoImpteAlim is NULL, False otherwise.
		''' </summary>
		Public Function IsSaldoImpteAlimNull() As Boolean
			Return IsNull(_parent.SaldoImpteAlimColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field SaldoImpteAlim to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSaldoImpteAlimNull() 
			Me(_parent.SaldoImpteAlimColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field SaldoImpteMed<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.SaldoImpteMed</remarks>
		Public Property [SaldoImpteMed]() As System.Decimal
			Get 
				If IsSaldoImpteMedNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SaldoImpteMedColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SaldoImpteMedColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field SaldoImpteMed is NULL, False otherwise.
		''' </summary>
		Public Function IsSaldoImpteMedNull() As Boolean
			Return IsNull(_parent.SaldoImpteMedColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field SaldoImpteMed to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSaldoImpteMedNull() 
			Me(_parent.SaldoImpteMedColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field SaldoImpte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.SaldoImpte</remarks>
		Public Property [SaldoImpte]() As System.Decimal
			Get 
				If IsSaldoImpteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SaldoImpteColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SaldoImpteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field SaldoImpte is NULL, False otherwise.
		''' </summary>
		Public Function IsSaldoImpteNull() As Boolean
			Return IsNull(_parent.SaldoImpteColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field SaldoImpte to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSaldoImpteNull() 
			Me(_parent.SaldoImpteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field SaldoCabezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.SaldoCabezas</remarks>
		Public Property [SaldoCabezas]() As System.Decimal
			Get 
				If IsSaldoCabezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SaldoCabezasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SaldoCabezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field SaldoCabezas is NULL, False otherwise.
		''' </summary>
		Public Function IsSaldoCabezasNull() As Boolean
			Return IsNull(_parent.SaldoCabezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field SaldoCabezas to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSaldoCabezasNull() 
			Me(_parent.SaldoCabezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field FechaInicio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.FechaCaptura</remarks>
		Public Property [FechaInicio]() As System.DateTime
			Get 
				If IsFechaInicioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaInicioColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaInicioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field FechaInicio is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaInicioNull() As Boolean
			Return IsNull(_parent.FechaInicioColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field FechaInicio to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaInicioNull() 
			Me(_parent.FechaInicioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field SaldoCostoInd<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: McecatLotesCab.SaldoCostoInd</remarks>
		Public Property [SaldoCostoInd]() As System.Decimal
			Get 
				If IsSaldoCostoIndNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SaldoCostoIndColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SaldoCostoIndColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field SaldoCostoInd is NULL, False otherwise.
		''' </summary>
		Public Function IsSaldoCostoIndNull() As Boolean
			Return IsNull(_parent.SaldoCostoIndColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field SaldoCostoInd to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSaldoCostoIndNull() 
			Me(_parent.SaldoCostoIndColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedList Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
