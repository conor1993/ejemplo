' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:38
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
	''' Typed datatable for the list 'MovimientosAlmacenGeneral'.<br/><br/>
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
	Public Class MovimientosAlmacenGeneralTypedList 
#Else
	Public Class MovimientosAlmacenGeneralTypedList 
#End If	
		Inherits TypedListBase
		Implements IEnumerable, ITypedListLgp
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioMovimiento As DataColumn
		Private _columnProductoId As DataColumn
		Private _columnProducto As DataColumn
		Private _columnTipoMovimeinto As DataColumn
		Private _columnTipoMovimientoId As DataColumn
		Private _columnFechaMovimiento As DataColumn
		Private _columnAlmacen As DataColumn
		Private _columnAlmacenId As DataColumn
		Private _columnCosto As DataColumn
		Private _columnCantidad As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END

		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' the number of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 10
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
			MyBase.New("MovimientosAlmacenGeneral")
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
			MyBase.New("MovimientosAlmacenGeneral")
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

			toReturn.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.AlmacenEntityUsingAlmacenId, "", "", JoinHint.Inner)
			toReturn.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.ProductoEntityUsingProductoId, "", "", JoinHint.Inner)
			toReturn.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenIdFolioMovimiento, "", "", JoinHint.Inner)
			toReturn.Add(InventarioMovimientoAlmacenEntity.Relations.TipoMovimientoAlmacenEntityUsingTipoMovimientoId, "", "", JoinHint.Inner)
			
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

			toReturn.DefineField(InventarioMovimientoAlmacenDetallesFields.FolioMovimiento, 0, "FolioMovimiento", "", AggregateFunction.None)
			toReturn.DefineField(InventarioMovimientoAlmacenDetallesFields.ProductoId, 1, "ProductoId", "", AggregateFunction.None)
			toReturn.DefineField(ProductoFields.Descripcion, 2, "Producto", "", AggregateFunction.None)
			toReturn.DefineField(TipoMovimientoAlmacenFields.Descripcion, 3, "TipoMovimeinto", "", AggregateFunction.None)
			toReturn.DefineField(InventarioMovimientoAlmacenFields.TipoMovimientoId, 4, "TipoMovimientoId", "", AggregateFunction.None)
			toReturn.DefineField(InventarioMovimientoAlmacenFields.FechaMovimiento, 5, "FechaMovimiento", "", AggregateFunction.None)
			toReturn.DefineField(AlmacenFields.Descripcion, 6, "Almacen", "", AggregateFunction.None)
			toReturn.DefineField(InventarioMovimientoAlmacenFields.AlmacenId, 7, "AlmacenId", "", AggregateFunction.None)
			toReturn.DefineField(InventarioMovimientoAlmacenDetallesFields.Costo, 8, "Costo", "", AggregateFunction.None)
			toReturn.DefineField(InventarioMovimientoAlmacenDetallesFields.Cantidad, 9, "Cantidad", "", AggregateFunction.None)
			
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
			Return New MovimientosAlmacenGeneralRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		''' <param name="obeyWeakRelations">flag for the internal used relations object</param>
		Private Sub InitClass(obeyWeakRelations As Boolean)
			
			_columnFolioMovimiento = New DataColumn("FolioMovimiento", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioMovimiento.ReadOnly = True
			_columnFolioMovimiento.Caption = "FolioMovimiento"
			Me.Columns.Add(_columnFolioMovimiento)

			_columnProductoId = New DataColumn("ProductoId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnProductoId.ReadOnly = True
			_columnProductoId.Caption = "ProductoId"
			Me.Columns.Add(_columnProductoId)

			_columnProducto = New DataColumn("Producto", GetType(System.String), Nothing, MappingType.Element)
			_columnProducto.ReadOnly = True
			_columnProducto.Caption = "Producto"
			Me.Columns.Add(_columnProducto)

			_columnTipoMovimeinto = New DataColumn("TipoMovimeinto", GetType(System.String), Nothing, MappingType.Element)
			_columnTipoMovimeinto.ReadOnly = True
			_columnTipoMovimeinto.Caption = "TipoMovimeinto"
			Me.Columns.Add(_columnTipoMovimeinto)

			_columnTipoMovimientoId = New DataColumn("TipoMovimientoId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnTipoMovimientoId.ReadOnly = True
			_columnTipoMovimientoId.Caption = "TipoMovimientoId"
			Me.Columns.Add(_columnTipoMovimientoId)

			_columnFechaMovimiento = New DataColumn("FechaMovimiento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaMovimiento.ReadOnly = True
			_columnFechaMovimiento.Caption = "FechaMovimiento"
			Me.Columns.Add(_columnFechaMovimiento)

			_columnAlmacen = New DataColumn("Almacen", GetType(System.String), Nothing, MappingType.Element)
			_columnAlmacen.ReadOnly = True
			_columnAlmacen.Caption = "Almacen"
			Me.Columns.Add(_columnAlmacen)

			_columnAlmacenId = New DataColumn("AlmacenId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnAlmacenId.ReadOnly = True
			_columnAlmacenId.Caption = "AlmacenId"
			Me.Columns.Add(_columnAlmacenId)

			_columnCosto = New DataColumn("Costo", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCosto.ReadOnly = True
			_columnCosto.Caption = "Costo"
			Me.Columns.Add(_columnCosto)

			_columnCantidad = New DataColumn("Cantidad", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidad.ReadOnly = True
			_columnCantidad.Caption = "Cantidad"
			Me.Columns.Add(_columnCantidad)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
			MyBase.ObeyWeakRelations = obeyWeakRelations
			OnInitialized()
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolioMovimiento = Me.Columns("FolioMovimiento")
			_columnProductoId = Me.Columns("ProductoId")
			_columnProducto = Me.Columns("Producto")
			_columnTipoMovimeinto = Me.Columns("TipoMovimeinto")
			_columnTipoMovimientoId = Me.Columns("TipoMovimientoId")
			_columnFechaMovimiento = Me.Columns("FechaMovimiento")
			_columnAlmacen = Me.Columns("Almacen")
			_columnAlmacenId = Me.Columns("AlmacenId")
			_columnCosto = Me.Columns("Costo")
			_columnCantidad = Me.Columns("Cantidad")
			
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

			_fieldsCustomProperties.Add("FolioMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ProductoId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Producto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoMovimeinto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoMovimientoId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Almacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("AlmacenId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Costo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(MovimientosAlmacenGeneralRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As MovimientosAlmacenGeneralTypedList = CType(MyBase.Clone(), MovimientosAlmacenGeneralTypedList)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New MovimientosAlmacenGeneralTypedList()
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
				Return MovimientosAlmacenGeneralTypedList.CustomProperties
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
				Return MovimientosAlmacenGeneralTypedList.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed list
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As MovimientosAlmacenGeneralRow
			Get 
				Return CType(Me.Rows(index), MovimientosAlmacenGeneralRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedList field FolioMovimiento
		''' </summary>
		ReadOnly Friend Property FolioMovimientoColumn As DataColumn
			Get 
				Return _columnFolioMovimiento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field ProductoId
		''' </summary>
		ReadOnly Friend Property ProductoIdColumn As DataColumn
			Get 
				Return _columnProductoId 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Producto
		''' </summary>
		ReadOnly Friend Property ProductoColumn As DataColumn
			Get 
				Return _columnProducto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field TipoMovimeinto
		''' </summary>
		ReadOnly Friend Property TipoMovimeintoColumn As DataColumn
			Get 
				Return _columnTipoMovimeinto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field TipoMovimientoId
		''' </summary>
		ReadOnly Friend Property TipoMovimientoIdColumn As DataColumn
			Get 
				Return _columnTipoMovimientoId 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field FechaMovimiento
		''' </summary>
		ReadOnly Friend Property FechaMovimientoColumn As DataColumn
			Get 
				Return _columnFechaMovimiento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Almacen
		''' </summary>
		ReadOnly Friend Property AlmacenColumn As DataColumn
			Get 
				Return _columnAlmacen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field AlmacenId
		''' </summary>
		ReadOnly Friend Property AlmacenIdColumn As DataColumn
			Get 
				Return _columnAlmacenId 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Costo
		''' </summary>
		ReadOnly Friend Property CostoColumn As DataColumn
			Get 
				Return _columnCosto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Cantidad
		''' </summary>
		ReadOnly Friend Property CantidadColumn As DataColumn
			Get 
				Return _columnCantidad 
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
	''' Typed datarow for the typed datatable MovimientosAlmacenGeneral
	''' </summary>
	Public Class MovimientosAlmacenGeneralRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _parent As MovimientosAlmacenGeneralTypedList
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, MovimientosAlmacenGeneralTypedList)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedList field FolioMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: InventarioMovimientoAlmacenDetalles.FolioMovimiento</remarks>
		Public Property [FolioMovimiento]() As System.String
			Get 
				If IsFolioMovimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioMovimientoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioMovimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field FolioMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioMovimientoNull() As Boolean
			Return IsNull(_parent.FolioMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field FolioMovimiento to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioMovimientoNull() 
			Me(_parent.FolioMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field ProductoId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: InventarioMovimientoAlmacenDetalles.ProductoId</remarks>
		Public Property [ProductoId]() As System.Int32
			Get 
				If IsProductoIdNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.ProductoIdColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.ProductoIdColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field ProductoId is NULL, False otherwise.
		''' </summary>
		Public Function IsProductoIdNull() As Boolean
			Return IsNull(_parent.ProductoIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field ProductoId to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetProductoIdNull() 
			Me(_parent.ProductoIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Producto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: Producto.Descripcion</remarks>
		Public Property [Producto]() As System.String
			Get 
				If IsProductoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ProductoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ProductoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Producto is NULL, False otherwise.
		''' </summary>
		Public Function IsProductoNull() As Boolean
			Return IsNull(_parent.ProductoColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Producto to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetProductoNull() 
			Me(_parent.ProductoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field TipoMovimeinto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: TipoMovimientoAlmacen.Descripcion</remarks>
		Public Property [TipoMovimeinto]() As System.String
			Get 
				If IsTipoMovimeintoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TipoMovimeintoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TipoMovimeintoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field TipoMovimeinto is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoMovimeintoNull() As Boolean
			Return IsNull(_parent.TipoMovimeintoColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field TipoMovimeinto to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoMovimeintoNull() 
			Me(_parent.TipoMovimeintoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field TipoMovimientoId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: InventarioMovimientoAlmacen.TipoMovimientoId</remarks>
		Public Property [TipoMovimientoId]() As System.Int32
			Get 
				If IsTipoMovimientoIdNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.TipoMovimientoIdColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.TipoMovimientoIdColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field TipoMovimientoId is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoMovimientoIdNull() As Boolean
			Return IsNull(_parent.TipoMovimientoIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field TipoMovimientoId to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoMovimientoIdNull() 
			Me(_parent.TipoMovimientoIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field FechaMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: InventarioMovimientoAlmacen.FechaMovimiento</remarks>
		Public Property [FechaMovimiento]() As System.DateTime
			Get 
				If IsFechaMovimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaMovimientoColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaMovimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field FechaMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaMovimientoNull() As Boolean
			Return IsNull(_parent.FechaMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field FechaMovimiento to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaMovimientoNull() 
			Me(_parent.FechaMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Almacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: Almacen.Descripcion</remarks>
		Public Property [Almacen]() As System.String
			Get 
				If IsAlmacenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.AlmacenColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.AlmacenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Almacen is NULL, False otherwise.
		''' </summary>
		Public Function IsAlmacenNull() As Boolean
			Return IsNull(_parent.AlmacenColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Almacen to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAlmacenNull() 
			Me(_parent.AlmacenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field AlmacenId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: InventarioMovimientoAlmacen.AlmacenId</remarks>
		Public Property [AlmacenId]() As System.Int32
			Get 
				If IsAlmacenIdNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.AlmacenIdColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.AlmacenIdColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field AlmacenId is NULL, False otherwise.
		''' </summary>
		Public Function IsAlmacenIdNull() As Boolean
			Return IsNull(_parent.AlmacenIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field AlmacenId to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAlmacenIdNull() 
			Me(_parent.AlmacenIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Costo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: InventarioMovimientoAlmacenDetalles.Costo</remarks>
		Public Property [Costo]() As System.Decimal
			Get 
				If IsCostoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CostoColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CostoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Costo is NULL, False otherwise.
		''' </summary>
		Public Function IsCostoNull() As Boolean
			Return IsNull(_parent.CostoColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Costo to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCostoNull() 
			Me(_parent.CostoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Cantidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: InventarioMovimientoAlmacenDetalles.Cantidad</remarks>
		Public Property [Cantidad]() As System.Decimal
			Get 
				If IsCantidadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantidadColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantidadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Cantidad is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadNull() As Boolean
			Return IsNull(_parent.CantidadColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Cantidad to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadNull() 
			Me(_parent.CantidadColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedList Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
