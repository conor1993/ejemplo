' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 09:23:52
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
	''' Typed datatable for the list 'ListaNotasVenta'.<br/><br/>
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
	Public Class ListaNotasVentaTypedList 
#Else
	Public Class ListaNotasVentaTypedList 
#End If	
		Inherits TypedListBase
		Implements IEnumerable, ITypedListLgp
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnCodigo As DataColumn
		Private _columnSucursal As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnSubTotal As DataColumn
		Private _columnDescuento As DataColumn
		Private _columnTotal As DataColumn
		Private _columnFechaVenta As DataColumn
		Private _columnMotivoCancelacion As DataColumn
		Private _columnObservacionesCancelacion As DataColumn
		Private _columnIva As DataColumn
		Private _columnIeps As DataColumn
		Private _columnImporte As DataColumn
		Private _columnPago As DataColumn
		Private _columnCambio As DataColumn
		Private _columnUsuarioAlta As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END

		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' the number of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 15
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
			MyBase.New("ListaNotasVenta")
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
			MyBase.New("ListaNotasVenta")
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

			toReturn.DefineField(NotaVentaFields.Codigo, 0, "Codigo", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.CodSucursal, 1, "Sucursal", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.Estatus, 2, "Estatus", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.SubTotal, 3, "SubTotal", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.Descuento, 4, "Descuento", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.Total, 5, "Total", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.FechaVenta, 6, "FechaVenta", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.MotivoCancelacion, 7, "MotivoCancelacion", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.ObservacionesCancelacion, 8, "ObservacionesCancelacion", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.Iva, 9, "Iva", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.Ieps, 10, "Ieps", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.Importe, 11, "Importe", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.Pago, 12, "Pago", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.Cambio, 13, "Cambio", "", AggregateFunction.None)
			toReturn.DefineField(NotaVentaFields.UsuarioAlta, 14, "UsuarioAlta", "", AggregateFunction.None)
			
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
			Return New ListaNotasVentaRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		''' <param name="obeyWeakRelations">flag for the internal used relations object</param>
		Private Sub InitClass(obeyWeakRelations As Boolean)
			
			_columnCodigo = New DataColumn("Codigo", GetType(System.Int64), Nothing, MappingType.Element)
			_columnCodigo.ReadOnly = True
			_columnCodigo.Caption = "Codigo"
			Me.Columns.Add(_columnCodigo)

			_columnSucursal = New DataColumn("Sucursal", GetType(System.Int32), Nothing, MappingType.Element)
			_columnSucursal.ReadOnly = True
			_columnSucursal.Caption = "Sucursal"
			Me.Columns.Add(_columnSucursal)

			_columnEstatus = New DataColumn("Estatus", GetType(System.Int16), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnSubTotal = New DataColumn("SubTotal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSubTotal.ReadOnly = True
			_columnSubTotal.Caption = "SubTotal"
			Me.Columns.Add(_columnSubTotal)

			_columnDescuento = New DataColumn("Descuento", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnDescuento.ReadOnly = True
			_columnDescuento.Caption = "Descuento"
			Me.Columns.Add(_columnDescuento)

			_columnTotal = New DataColumn("Total", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotal.ReadOnly = True
			_columnTotal.Caption = "Total"
			Me.Columns.Add(_columnTotal)

			_columnFechaVenta = New DataColumn("FechaVenta", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaVenta.ReadOnly = True
			_columnFechaVenta.Caption = "FechaVenta"
			Me.Columns.Add(_columnFechaVenta)

			_columnMotivoCancelacion = New DataColumn("MotivoCancelacion", GetType(System.Int32), Nothing, MappingType.Element)
			_columnMotivoCancelacion.ReadOnly = True
			_columnMotivoCancelacion.Caption = "MotivoCancelacion"
			Me.Columns.Add(_columnMotivoCancelacion)

			_columnObservacionesCancelacion = New DataColumn("ObservacionesCancelacion", GetType(System.String), Nothing, MappingType.Element)
			_columnObservacionesCancelacion.ReadOnly = True
			_columnObservacionesCancelacion.Caption = "ObservacionesCancelacion"
			Me.Columns.Add(_columnObservacionesCancelacion)

			_columnIva = New DataColumn("Iva", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnIva.ReadOnly = True
			_columnIva.Caption = "Iva"
			Me.Columns.Add(_columnIva)

			_columnIeps = New DataColumn("Ieps", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnIeps.ReadOnly = True
			_columnIeps.Caption = "Ieps"
			Me.Columns.Add(_columnIeps)

			_columnImporte = New DataColumn("Importe", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporte.ReadOnly = True
			_columnImporte.Caption = "Importe"
			Me.Columns.Add(_columnImporte)

			_columnPago = New DataColumn("Pago", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPago.ReadOnly = True
			_columnPago.Caption = "Pago"
			Me.Columns.Add(_columnPago)

			_columnCambio = New DataColumn("Cambio", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCambio.ReadOnly = True
			_columnCambio.Caption = "Cambio"
			Me.Columns.Add(_columnCambio)

			_columnUsuarioAlta = New DataColumn("UsuarioAlta", GetType(System.Int32), Nothing, MappingType.Element)
			_columnUsuarioAlta.ReadOnly = True
			_columnUsuarioAlta.Caption = "UsuarioAlta"
			Me.Columns.Add(_columnUsuarioAlta)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
			MyBase.ObeyWeakRelations = obeyWeakRelations
			OnInitialized()
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnCodigo = Me.Columns("Codigo")
			_columnSucursal = Me.Columns("Sucursal")
			_columnEstatus = Me.Columns("Estatus")
			_columnSubTotal = Me.Columns("SubTotal")
			_columnDescuento = Me.Columns("Descuento")
			_columnTotal = Me.Columns("Total")
			_columnFechaVenta = Me.Columns("FechaVenta")
			_columnMotivoCancelacion = Me.Columns("MotivoCancelacion")
			_columnObservacionesCancelacion = Me.Columns("ObservacionesCancelacion")
			_columnIva = Me.Columns("Iva")
			_columnIeps = Me.Columns("Ieps")
			_columnImporte = Me.Columns("Importe")
			_columnPago = Me.Columns("Pago")
			_columnCambio = Me.Columns("Cambio")
			_columnUsuarioAlta = Me.Columns("UsuarioAlta")
			
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

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Sucursal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaVenta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("MotivoCancelacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ObservacionesCancelacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Ieps", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Pago", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cambio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(ListaNotasVentaRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As ListaNotasVentaTypedList = CType(MyBase.Clone(), ListaNotasVentaTypedList)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New ListaNotasVentaTypedList()
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
				Return ListaNotasVentaTypedList.CustomProperties
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
				Return ListaNotasVentaTypedList.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed list
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As ListaNotasVentaRow
			Get 
				Return CType(Me.Rows(index), ListaNotasVentaRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Codigo
		''' </summary>
		ReadOnly Friend Property CodigoColumn As DataColumn
			Get 
				Return _columnCodigo 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Sucursal
		''' </summary>
		ReadOnly Friend Property SucursalColumn As DataColumn
			Get 
				Return _columnSucursal 
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
		''' Returns the column Object belonging to the TypedList field SubTotal
		''' </summary>
		ReadOnly Friend Property SubTotalColumn As DataColumn
			Get 
				Return _columnSubTotal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Descuento
		''' </summary>
		ReadOnly Friend Property DescuentoColumn As DataColumn
			Get 
				Return _columnDescuento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Total
		''' </summary>
		ReadOnly Friend Property TotalColumn As DataColumn
			Get 
				Return _columnTotal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field FechaVenta
		''' </summary>
		ReadOnly Friend Property FechaVentaColumn As DataColumn
			Get 
				Return _columnFechaVenta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field MotivoCancelacion
		''' </summary>
		ReadOnly Friend Property MotivoCancelacionColumn As DataColumn
			Get 
				Return _columnMotivoCancelacion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field ObservacionesCancelacion
		''' </summary>
		ReadOnly Friend Property ObservacionesCancelacionColumn As DataColumn
			Get 
				Return _columnObservacionesCancelacion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Iva
		''' </summary>
		ReadOnly Friend Property IvaColumn As DataColumn
			Get 
				Return _columnIva 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Ieps
		''' </summary>
		ReadOnly Friend Property IepsColumn As DataColumn
			Get 
				Return _columnIeps 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Importe
		''' </summary>
		ReadOnly Friend Property ImporteColumn As DataColumn
			Get 
				Return _columnImporte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Pago
		''' </summary>
		ReadOnly Friend Property PagoColumn As DataColumn
			Get 
				Return _columnPago 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field Cambio
		''' </summary>
		ReadOnly Friend Property CambioColumn As DataColumn
			Get 
				Return _columnCambio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedList field UsuarioAlta
		''' </summary>
		ReadOnly Friend Property UsuarioAltaColumn As DataColumn
			Get 
				Return _columnUsuarioAlta 
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
	''' Typed datarow for the typed datatable ListaNotasVenta
	''' </summary>
	Public Class ListaNotasVentaRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _parent As ListaNotasVentaTypedList
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, ListaNotasVentaTypedList)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedList field Codigo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.Codigo</remarks>
		Public Property [Codigo]() As System.Int64
			Get 
				If IsCodigoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int64)), System.Int64)
				Else
					Return CType(Me(_parent.CodigoColumn), System.Int64)
				End If
			End Get
			Set 
				Me(_parent.CodigoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Codigo is NULL, False otherwise.
		''' </summary>
		Public Function IsCodigoNull() As Boolean
			Return IsNull(_parent.CodigoColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Codigo to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodigoNull() 
			Me(_parent.CodigoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Sucursal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.CodSucursal</remarks>
		Public Property [Sucursal]() As System.Int32
			Get 
				If IsSucursalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.SucursalColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.SucursalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Sucursal is NULL, False otherwise.
		''' </summary>
		Public Function IsSucursalNull() As Boolean
			Return IsNull(_parent.SucursalColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Sucursal to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSucursalNull() 
			Me(_parent.SucursalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.Estatus</remarks>
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
		''' Gets / sets the value of the TypedList field SubTotal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.SubTotal</remarks>
		Public Property [SubTotal]() As System.Decimal
			Get 
				If IsSubTotalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SubTotalColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SubTotalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field SubTotal is NULL, False otherwise.
		''' </summary>
		Public Function IsSubTotalNull() As Boolean
			Return IsNull(_parent.SubTotalColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field SubTotal to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSubTotalNull() 
			Me(_parent.SubTotalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Descuento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.Descuento</remarks>
		Public Property [Descuento]() As System.Decimal
			Get 
				If IsDescuentoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.DescuentoColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.DescuentoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Descuento is NULL, False otherwise.
		''' </summary>
		Public Function IsDescuentoNull() As Boolean
			Return IsNull(_parent.DescuentoColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Descuento to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDescuentoNull() 
			Me(_parent.DescuentoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Total<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.Total</remarks>
		Public Property [Total]() As System.Decimal
			Get 
				If IsTotalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TotalColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TotalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Total is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalNull() As Boolean
			Return IsNull(_parent.TotalColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Total to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalNull() 
			Me(_parent.TotalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field FechaVenta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.FechaVenta</remarks>
		Public Property [FechaVenta]() As System.DateTime
			Get 
				If IsFechaVentaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaVentaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaVentaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field FechaVenta is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaVentaNull() As Boolean
			Return IsNull(_parent.FechaVentaColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field FechaVenta to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaVentaNull() 
			Me(_parent.FechaVentaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field MotivoCancelacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.MotivoCancelacion</remarks>
		Public Property [MotivoCancelacion]() As System.Int32
			Get 
				If IsMotivoCancelacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.MotivoCancelacionColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.MotivoCancelacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field MotivoCancelacion is NULL, False otherwise.
		''' </summary>
		Public Function IsMotivoCancelacionNull() As Boolean
			Return IsNull(_parent.MotivoCancelacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field MotivoCancelacion to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetMotivoCancelacionNull() 
			Me(_parent.MotivoCancelacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field ObservacionesCancelacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.ObservacionesCancelacion</remarks>
		Public Property [ObservacionesCancelacion]() As System.String
			Get 
				If IsObservacionesCancelacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ObservacionesCancelacionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ObservacionesCancelacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field ObservacionesCancelacion is NULL, False otherwise.
		''' </summary>
		Public Function IsObservacionesCancelacionNull() As Boolean
			Return IsNull(_parent.ObservacionesCancelacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field ObservacionesCancelacion to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetObservacionesCancelacionNull() 
			Me(_parent.ObservacionesCancelacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Iva<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.Iva</remarks>
		Public Property [Iva]() As System.Decimal
			Get 
				If IsIvaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.IvaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.IvaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Iva is NULL, False otherwise.
		''' </summary>
		Public Function IsIvaNull() As Boolean
			Return IsNull(_parent.IvaColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Iva to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIvaNull() 
			Me(_parent.IvaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Ieps<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.Ieps</remarks>
		Public Property [Ieps]() As System.Decimal
			Get 
				If IsIepsNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.IepsColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.IepsColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Ieps is NULL, False otherwise.
		''' </summary>
		Public Function IsIepsNull() As Boolean
			Return IsNull(_parent.IepsColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Ieps to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIepsNull() 
			Me(_parent.IepsColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Importe<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.Importe</remarks>
		Public Property [Importe]() As System.Decimal
			Get 
				If IsImporteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Importe is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteNull() As Boolean
			Return IsNull(_parent.ImporteColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Importe to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteNull() 
			Me(_parent.ImporteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Pago<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.Pago</remarks>
		Public Property [Pago]() As System.Decimal
			Get 
				If IsPagoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PagoColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PagoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Pago is NULL, False otherwise.
		''' </summary>
		Public Function IsPagoNull() As Boolean
			Return IsNull(_parent.PagoColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Pago to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPagoNull() 
			Me(_parent.PagoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field Cambio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.Cambio</remarks>
		Public Property [Cambio]() As System.Decimal
			Get 
				If IsCambioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CambioColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CambioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field Cambio is NULL, False otherwise.
		''' </summary>
		Public Function IsCambioNull() As Boolean
			Return IsNull(_parent.CambioColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field Cambio to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCambioNull() 
			Me(_parent.CambioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedList field UsuarioAlta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>Mapped On: NotaVenta.UsuarioAlta</remarks>
		Public Property [UsuarioAlta]() As System.Int32
			Get 
				If IsUsuarioAltaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.UsuarioAltaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.UsuarioAltaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedList field UsuarioAlta is NULL, False otherwise.
		''' </summary>
		Public Function IsUsuarioAltaNull() As Boolean
			Return IsNull(_parent.UsuarioAltaColumn)
		End Function

		''' <summary>
		''' Sets the TypedList field UsuarioAlta to NULL. Not recommended a typed list should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetUsuarioAltaNull() 
			Me(_parent.UsuarioAltaColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedList Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
