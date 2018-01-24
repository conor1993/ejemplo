' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 24 de enero de 2018 11:05:24
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

Imports Integralab.ORM
Imports Integralab.ORM.HelperClasses
Imports Integralab.ORM.DaoClasses
Imports Integralab.ORM.EntityClasses
Imports Integralab.ORM.FactoryClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses

' __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
' __LLBLGENPRO_USER_CODE_REGION_END
Namespace Integralab.ORM.TypedViewClasses
	''' <summary>
	''' Typed datatable for the view 'VwAlmKardex'.<br/><br/>
	''' 
	''' </summary>
	''' <remarks>
	''' It embeds a fill method which accepts a filter.
	''' The code doesn't support any changing of data. Users who do that are on their own.
	''' It also doesn't support any event throwing. This view should be used as a base for readonly databinding
	''' or dataview construction.
	''' </remarks>
#If Not CF Then	
	<Serializable(), System.ComponentModel.DesignerCategory("Code"), ToolboxItem(True), DesignTimeVisible(True)> _
	Public Class VwAlmKardexTypedView 
#Else
	Public Class VwAlmKardexTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnAlmacenId As DataColumn
		Private _columnProductoId As DataColumn
		Private _columnPdDescripcion As DataColumn
		Private _columnPdIdLinea As DataColumn
		Private _columnPdIdUnidadMedida As DataColumn
		Private _columnUmdescripcion As DataColumn
		Private _columnLndescripcion As DataColumn
		Private _columnExpr1 As DataColumn
		Private _columnLnidLinea As DataColumn
		Private _columnAño As DataColumn
		Private _columnMes As DataColumn
		Private _columnCostoPromedio As DataColumn
		Private _columnFolioMovimiento As DataColumn
		Private _columnFechaMovimiento As DataColumn
		Private _columnCantidad As DataColumn
		Private _columnCosto As DataColumn
		Private _columnDescuento As DataColumn
		Private _columnTipoMovimientoId As DataColumn
		Private _columnOrigen As DataColumn
		Private _columnDescripcion As DataColumn
		Private _columnCantidadEntradas As DataColumn
		Private _columnCantidadSalidas As DataColumn
		Private _columnDireccion As DataColumn
		Private _columnCantidadInicial As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 24
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
			MyBase.New("VwAlmKardex")
			InitClass()
		End Sub


#If Not CF Then		
		''' <summary>
		''' Protected constructor for deserialization. Empty, since there are no private members to be serialized also.
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
		''' Will use no sort filter, no select filter, will allow duplicate rows and will not limit the amount of rows returned
		''' </summary>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill() As Boolean Implements ITypedView.Fill
			Return Fill(0, Nothing, True, Nothing, Nothing, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query. 
		''' Will not use a filter, will allow duplicate rows.
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean Implements ITypedView.Fill
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
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean) As Boolean Implements ITypedView.Fill
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
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate) As Boolean Implements ITypedView.Fill
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
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate, transactionToUse As ITransaction) As Boolean Implements ITypedView.Fill
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
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate, transactionToUse As ITransaction, groupByClause As IGroupByCollection) As Boolean Implements ITypedView.Fill
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
		Overridable Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate, transactionToUse As ITransaction, groupByClause As IGroupByCollection, pageNumber As Integer, pageSize As Integer) As Boolean Implements ITypedView.Fill
			' Build resultset
			Dim fieldsInResultset As IEntityFields = GetFields()
			
			' __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields
			' be sure To Call fieldsInResultset.Expand(number of New fields) first. 
			' __LLBLGENPRO_USER_CODE_REGION_END

			Dim dao As TypedListDAO = DAOFactory.CreateTypedListDAO()
			Return dao.GetMultiAsDataTable(fieldsInResultset, Me, maxNumberOfItemsToReturn, sortClauses, selectFilter, Nothing, True, groupByClause, transactionToUse, pageNumber, pageSize)
		End Function
		
		''' <summary>Gets the fields of this typed view</summary>
		''' <returns>IEntityFields Object</returns>
		Public Function GetFields() As IEntityFields Implements ITypedView.GetFields
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwAlmKardexTypedView)
		End Function

		''' <summary>
		''' Gets the amount of rows in the database for this typed view, not skipping duplicates
		''' </summary>
		''' <returns>the amount of objects found</returns>
		Public Function GetDbCount() As Integer Implements ITypedView.GetDbCount
			Return GetDbCount(True, Nothing, Nothing)
		End Function
		
		
		''' <summary>
		''' Gets the amount of rows in the database for this typed view.
		''' </summary>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		''' <returns>the amount of objects found</returns>
		Public Function GetDbCount(allowDuplicates As Boolean) As Integer Implements ITypedView.GetDbCount
			Return GetDbCount(allowDuplicates, Nothing, Nothing)
		End Function


		''' <summary>
		''' Gets the amount of rows in the database for this typed view.
		''' </summary>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		''' <param name="filter">The filter to apply for the count retrieval</param>
		''' <returns>the amount of objects found</returns>
		Public Function GetDbCount(allowDuplicates As Boolean, Filter As IPredicateExpression) As Integer Implements ITypedView.GetDbCount
			Return GetDbCount(allowDuplicates, filter, Nothing)
		End Function


		''' <summary>
		''' Gets the amount of rows In the database For this typed list.
		''' </summary>
		''' <param name="allowDuplicates">Flag To allow duplicate rows (True) Or Not (False)</param>
		''' <param name="filter">The filter To apply For the count retrieval</param>
		''' <param name="groupByClause">group by clause To embed In the query</param>
		''' <returns>the number of rows In the Set defined by the passed In query elements</returns>
		Public Overridable Function GetDbCount(allowDuplicates As Boolean, Filter As IPredicateExpression, groupByClause As GroupByCollection) As Integer Implements ITypedView.GetDbCount
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwAlmKardexTypedView)
			Dim dao As TypedListDAO = DAOFactory.CreateTypedListDAO()
			Return dao.GetDbCount(fieldsInResultset, Nothing, filter, Nothing, groupByClause, allowDuplicates)
		End Function


		''' <summary>
		''' Gets the enumerator for this class.
		''' </summary>
		''' <returns>Enumerator for this class.</returns>
		Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
			Return Me.Rows.GetEnumerator()
		End Function


		''' <summary>
		''' Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.
		''' </summary>
		''' <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		''' <returns>the new typed datarow</returns>
		Protected Overrides Function NewRowFromBuilder(rowBuilder As DataRowBuilder) As DataRow
			Return New VwAlmKardexRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnAlmacenId = New DataColumn("AlmacenId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnAlmacenId.ReadOnly = True
			_columnAlmacenId.Caption = "AlmacenId"
			Me.Columns.Add(_columnAlmacenId)

			_columnProductoId = New DataColumn("ProductoId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnProductoId.ReadOnly = True
			_columnProductoId.Caption = "ProductoId"
			Me.Columns.Add(_columnProductoId)

			_columnPdDescripcion = New DataColumn("PdDescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnPdDescripcion.ReadOnly = True
			_columnPdDescripcion.Caption = "PdDescripcion"
			Me.Columns.Add(_columnPdDescripcion)

			_columnPdIdLinea = New DataColumn("PdIdLinea", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdLinea.ReadOnly = True
			_columnPdIdLinea.Caption = "PdIdLinea"
			Me.Columns.Add(_columnPdIdLinea)

			_columnPdIdUnidadMedida = New DataColumn("PdIdUnidadMedida", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdUnidadMedida.ReadOnly = True
			_columnPdIdUnidadMedida.Caption = "PdIdUnidadMedida"
			Me.Columns.Add(_columnPdIdUnidadMedida)

			_columnUmdescripcion = New DataColumn("Umdescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnUmdescripcion.ReadOnly = True
			_columnUmdescripcion.Caption = "Umdescripcion"
			Me.Columns.Add(_columnUmdescripcion)

			_columnLndescripcion = New DataColumn("Lndescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnLndescripcion.ReadOnly = True
			_columnLndescripcion.Caption = "Lndescripcion"
			Me.Columns.Add(_columnLndescripcion)

			_columnExpr1 = New DataColumn("Expr1", GetType(System.String), Nothing, MappingType.Element)
			_columnExpr1.ReadOnly = True
			_columnExpr1.Caption = "Expr1"
			Me.Columns.Add(_columnExpr1)

			_columnLnidLinea = New DataColumn("LnidLinea", GetType(System.Int32), Nothing, MappingType.Element)
			_columnLnidLinea.ReadOnly = True
			_columnLnidLinea.Caption = "LnidLinea"
			Me.Columns.Add(_columnLnidLinea)

			_columnAño = New DataColumn("Año", GetType(System.Int32), Nothing, MappingType.Element)
			_columnAño.ReadOnly = True
			_columnAño.Caption = "Año"
			Me.Columns.Add(_columnAño)

			_columnMes = New DataColumn("Mes", GetType(System.Int32), Nothing, MappingType.Element)
			_columnMes.ReadOnly = True
			_columnMes.Caption = "Mes"
			Me.Columns.Add(_columnMes)

			_columnCostoPromedio = New DataColumn("CostoPromedio", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCostoPromedio.ReadOnly = True
			_columnCostoPromedio.Caption = "CostoPromedio"
			Me.Columns.Add(_columnCostoPromedio)

			_columnFolioMovimiento = New DataColumn("FolioMovimiento", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioMovimiento.ReadOnly = True
			_columnFolioMovimiento.Caption = "FolioMovimiento"
			Me.Columns.Add(_columnFolioMovimiento)

			_columnFechaMovimiento = New DataColumn("FechaMovimiento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaMovimiento.ReadOnly = True
			_columnFechaMovimiento.Caption = "FechaMovimiento"
			Me.Columns.Add(_columnFechaMovimiento)

			_columnCantidad = New DataColumn("Cantidad", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidad.ReadOnly = True
			_columnCantidad.Caption = "Cantidad"
			Me.Columns.Add(_columnCantidad)

			_columnCosto = New DataColumn("Costo", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCosto.ReadOnly = True
			_columnCosto.Caption = "Costo"
			Me.Columns.Add(_columnCosto)

			_columnDescuento = New DataColumn("Descuento", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnDescuento.ReadOnly = True
			_columnDescuento.Caption = "Descuento"
			Me.Columns.Add(_columnDescuento)

			_columnTipoMovimientoId = New DataColumn("TipoMovimientoId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnTipoMovimientoId.ReadOnly = True
			_columnTipoMovimientoId.Caption = "TipoMovimientoId"
			Me.Columns.Add(_columnTipoMovimientoId)

			_columnOrigen = New DataColumn("Origen", GetType(System.String), Nothing, MappingType.Element)
			_columnOrigen.ReadOnly = True
			_columnOrigen.Caption = "Origen"
			Me.Columns.Add(_columnOrigen)

			_columnDescripcion = New DataColumn("Descripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnDescripcion.ReadOnly = True
			_columnDescripcion.Caption = "Descripcion"
			Me.Columns.Add(_columnDescripcion)

			_columnCantidadEntradas = New DataColumn("CantidadEntradas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCantidadEntradas.ReadOnly = True
			_columnCantidadEntradas.Caption = "CantidadEntradas"
			Me.Columns.Add(_columnCantidadEntradas)

			_columnCantidadSalidas = New DataColumn("CantidadSalidas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCantidadSalidas.ReadOnly = True
			_columnCantidadSalidas.Caption = "CantidadSalidas"
			Me.Columns.Add(_columnCantidadSalidas)

			_columnDireccion = New DataColumn("Direccion", GetType(System.Int16), Nothing, MappingType.Element)
			_columnDireccion.ReadOnly = True
			_columnDireccion.Caption = "Direccion"
			Me.Columns.Add(_columnDireccion)

			_columnCantidadInicial = New DataColumn("CantidadInicial", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidadInicial.ReadOnly = True
			_columnCantidadInicial.Caption = "CantidadInicial"
			Me.Columns.Add(_columnCantidadInicial)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnAlmacenId = Me.Columns("AlmacenId")
			_columnProductoId = Me.Columns("ProductoId")
			_columnPdDescripcion = Me.Columns("PdDescripcion")
			_columnPdIdLinea = Me.Columns("PdIdLinea")
			_columnPdIdUnidadMedida = Me.Columns("PdIdUnidadMedida")
			_columnUmdescripcion = Me.Columns("Umdescripcion")
			_columnLndescripcion = Me.Columns("Lndescripcion")
			_columnExpr1 = Me.Columns("Expr1")
			_columnLnidLinea = Me.Columns("LnidLinea")
			_columnAño = Me.Columns("Año")
			_columnMes = Me.Columns("Mes")
			_columnCostoPromedio = Me.Columns("CostoPromedio")
			_columnFolioMovimiento = Me.Columns("FolioMovimiento")
			_columnFechaMovimiento = Me.Columns("FechaMovimiento")
			_columnCantidad = Me.Columns("Cantidad")
			_columnCosto = Me.Columns("Costo")
			_columnDescuento = Me.Columns("Descuento")
			_columnTipoMovimientoId = Me.Columns("TipoMovimientoId")
			_columnOrigen = Me.Columns("Origen")
			_columnDescripcion = Me.Columns("Descripcion")
			_columnCantidadEntradas = Me.Columns("CantidadEntradas")
			_columnCantidadSalidas = Me.Columns("CantidadSalidas")
			_columnDireccion = Me.Columns("Direccion")
			_columnCantidadInicial = Me.Columns("CantidadInicial")
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the hashtables for the TypedView type and TypedView field custom properties. 
		''' </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Hashtable()
			_fieldsCustomProperties = New Hashtable()

			' Add custom properties of this type

			' Add per Field a new Hashtable with its custom properties, indexed by the name of the field.
			Dim fieldHashtable As Hashtable = Nothing
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("AlmacenId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ProductoId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdDescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdLinea", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdUnidadMedida", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Umdescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Lndescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Expr1", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("LnidLinea", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Año", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Mes", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CostoPromedio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Costo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoMovimientoId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Origen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantidadEntradas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantidadSalidas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Direccion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantidadInicial", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwAlmKardexRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwAlmKardexTypedView = CType(MyBase.Clone(), VwAlmKardexTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwAlmKardexTypedView()
		End Function
#End If

#Region "Class Property Declarations"
		''' <summary>
		''' Returns the amount of rows in this typed view.
		''' </summary>
		<System.ComponentModel.Browsable(False)> _
		Public ReadOnly Property Count As Integer Implements ITypedView.Count
			Get 
				Return Me.Rows.Count
			End Get
		End Property
		
		''' <summary>
		''' The custom properties for this TypedView type.
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public Shared ReadOnly Property CustomProperties() As Hashtable
			Get
				Return _customProperties
			End Get
		End Property

		''' <summary>
		''' The custom properties for the type of this TypedView instance.
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<System.ComponentModel.Browsable(False)> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Hashtable
			Get
				Return VwAlmKardexTypedView.CustomProperties
			End Get
		End Property

		''' <summary>
		''' The custom properties for the fields of this TypedView type. The returned Hashtable contains per fieldname a hashtable of name-value
		''' pairs. 
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public Shared ReadOnly Property FieldsCustomProperties() As Hashtable
			Get
				Return _fieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' The custom properties for the fields of the type of this TypedView instance. The returned Hashtable contains per fieldname a hashtable of name-value
		''' pairs. 
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<System.ComponentModel.Browsable(False)> _
		Public Overridable ReadOnly Property FieldsCustomPropertiesOfType() As Hashtable
			Get
				Return VwAlmKardexTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwAlmKardexRow
			Get 
				Return CType(Me.Rows(index), VwAlmKardexRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field AlmacenId
		''' </summary>
		ReadOnly Friend Property AlmacenIdColumn As DataColumn
			Get 
				Return _columnAlmacenId 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ProductoId
		''' </summary>
		ReadOnly Friend Property ProductoIdColumn As DataColumn
			Get 
				Return _columnProductoId 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdDescripcion
		''' </summary>
		ReadOnly Friend Property PdDescripcionColumn As DataColumn
			Get 
				Return _columnPdDescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdLinea
		''' </summary>
		ReadOnly Friend Property PdIdLineaColumn As DataColumn
			Get 
				Return _columnPdIdLinea 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdUnidadMedida
		''' </summary>
		ReadOnly Friend Property PdIdUnidadMedidaColumn As DataColumn
			Get 
				Return _columnPdIdUnidadMedida 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Umdescripcion
		''' </summary>
		ReadOnly Friend Property UmdescripcionColumn As DataColumn
			Get 
				Return _columnUmdescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Lndescripcion
		''' </summary>
		ReadOnly Friend Property LndescripcionColumn As DataColumn
			Get 
				Return _columnLndescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Expr1
		''' </summary>
		ReadOnly Friend Property Expr1Column As DataColumn
			Get 
				Return _columnExpr1 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field LnidLinea
		''' </summary>
		ReadOnly Friend Property LnidLineaColumn As DataColumn
			Get 
				Return _columnLnidLinea 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Año
		''' </summary>
		ReadOnly Friend Property AñoColumn As DataColumn
			Get 
				Return _columnAño 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Mes
		''' </summary>
		ReadOnly Friend Property MesColumn As DataColumn
			Get 
				Return _columnMes 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CostoPromedio
		''' </summary>
		ReadOnly Friend Property CostoPromedioColumn As DataColumn
			Get 
				Return _columnCostoPromedio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioMovimiento
		''' </summary>
		ReadOnly Friend Property FolioMovimientoColumn As DataColumn
			Get 
				Return _columnFolioMovimiento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaMovimiento
		''' </summary>
		ReadOnly Friend Property FechaMovimientoColumn As DataColumn
			Get 
				Return _columnFechaMovimiento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Cantidad
		''' </summary>
		ReadOnly Friend Property CantidadColumn As DataColumn
			Get 
				Return _columnCantidad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Costo
		''' </summary>
		ReadOnly Friend Property CostoColumn As DataColumn
			Get 
				Return _columnCosto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Descuento
		''' </summary>
		ReadOnly Friend Property DescuentoColumn As DataColumn
			Get 
				Return _columnDescuento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TipoMovimientoId
		''' </summary>
		ReadOnly Friend Property TipoMovimientoIdColumn As DataColumn
			Get 
				Return _columnTipoMovimientoId 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Origen
		''' </summary>
		ReadOnly Friend Property OrigenColumn As DataColumn
			Get 
				Return _columnOrigen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Descripcion
		''' </summary>
		ReadOnly Friend Property DescripcionColumn As DataColumn
			Get 
				Return _columnDescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantidadEntradas
		''' </summary>
		ReadOnly Friend Property CantidadEntradasColumn As DataColumn
			Get 
				Return _columnCantidadEntradas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantidadSalidas
		''' </summary>
		ReadOnly Friend Property CantidadSalidasColumn As DataColumn
			Get 
				Return _columnCantidadSalidas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Direccion
		''' </summary>
		ReadOnly Friend Property DireccionColumn As DataColumn
			Get 
				Return _columnDireccion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantidadInicial
		''' </summary>
		ReadOnly Friend Property CantidadInicialColumn As DataColumn
			Get 
				Return _columnCantidadInicial 
			End Get
		End Property
    
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties
		' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

#Region "Custom Typed View code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

#Region "Included Code"

#End Region
	End Class


	''' <summary>
	''' Typed datarow for the typed datatable VwAlmKardex
	''' </summary>
	Public Class VwAlmKardexRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwAlmKardexTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwAlmKardexTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field AlmacenId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."AlmacenId"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
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
		''' Returns True if the TypedView field AlmacenId is NULL, False otherwise.
		''' </summary>
		Public Function IsAlmacenIdNull() As Boolean
			Return IsNull(_parent.AlmacenIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field AlmacenId to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAlmacenIdNull() 
			Me(_parent.AlmacenIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ProductoId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."ProductoId"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
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
		''' Returns True if the TypedView field ProductoId is NULL, False otherwise.
		''' </summary>
		Public Function IsProductoIdNull() As Boolean
			Return IsNull(_parent.ProductoIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ProductoId to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetProductoIdNull() 
			Me(_parent.ProductoIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdDescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."PdDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
		''' </remarks>
		Public Property [PdDescripcion]() As System.String
			Get 
				If IsPdDescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PdDescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PdDescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdDescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsPdDescripcionNull() As Boolean
			Return IsNull(_parent.PdDescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdDescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdDescripcionNull() 
			Me(_parent.PdDescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdLinea<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."PdIdLinea"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdLinea]() As System.Int32
			Get 
				If IsPdIdLineaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdLineaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdLineaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdLinea is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdLineaNull() As Boolean
			Return IsNull(_parent.PdIdLineaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdLinea to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdLineaNull() 
			Me(_parent.PdIdLineaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdUnidadMedida<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."PdIdUnidadMedida"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdUnidadMedida]() As System.Int32
			Get 
				If IsPdIdUnidadMedidaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdUnidadMedidaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdUnidadMedidaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdUnidadMedida is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdUnidadMedidaNull() As Boolean
			Return IsNull(_parent.PdIdUnidadMedidaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdUnidadMedida to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdUnidadMedidaNull() 
			Me(_parent.PdIdUnidadMedidaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Umdescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."UMDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 30
		''' </remarks>
		Public Property [Umdescripcion]() As System.String
			Get 
				If IsUmdescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.UmdescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.UmdescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Umdescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsUmdescripcionNull() As Boolean
			Return IsNull(_parent.UmdescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Umdescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetUmdescripcionNull() 
			Me(_parent.UmdescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Lndescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."LNDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [Lndescripcion]() As System.String
			Get 
				If IsLndescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LndescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LndescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Lndescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsLndescripcionNull() As Boolean
			Return IsNull(_parent.LndescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Lndescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLndescripcionNull() 
			Me(_parent.LndescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Expr1<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."Expr1"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [Expr1]() As System.String
			Get 
				If IsExpr1Null() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.Expr1Column), System.String)
				End If
			End Get
			Set 
				Me(_parent.Expr1Column) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Expr1 is NULL, False otherwise.
		''' </summary>
		Public Function IsExpr1Null() As Boolean
			Return IsNull(_parent.Expr1Column)
		End Function

		''' <summary>
		''' Sets the TypedView field Expr1 to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetExpr1Null() 
			Me(_parent.Expr1Column) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field LnidLinea<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."LNIdLinea"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [LnidLinea]() As System.Int32
			Get 
				If IsLnidLineaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.LnidLineaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.LnidLineaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field LnidLinea is NULL, False otherwise.
		''' </summary>
		Public Function IsLnidLineaNull() As Boolean
			Return IsNull(_parent.LnidLineaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field LnidLinea to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLnidLineaNull() 
			Me(_parent.LnidLineaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Año<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."Año"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Año]() As System.Int32
			Get 
				If IsAñoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.AñoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.AñoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Año is NULL, False otherwise.
		''' </summary>
		Public Function IsAñoNull() As Boolean
			Return IsNull(_parent.AñoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Año to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAñoNull() 
			Me(_parent.AñoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Mes<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."Mes"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Mes]() As System.Int32
			Get 
				If IsMesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.MesColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.MesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Mes is NULL, False otherwise.
		''' </summary>
		Public Function IsMesNull() As Boolean
			Return IsNull(_parent.MesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Mes to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetMesNull() 
			Me(_parent.MesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CostoPromedio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."CostoPromedio"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CostoPromedio]() As System.Decimal
			Get 
				If IsCostoPromedioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CostoPromedioColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CostoPromedioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CostoPromedio is NULL, False otherwise.
		''' </summary>
		Public Function IsCostoPromedioNull() As Boolean
			Return IsNull(_parent.CostoPromedioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CostoPromedio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCostoPromedioNull() 
			Me(_parent.CostoPromedioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."FolioMovimiento"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 20
		''' </remarks>
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
		''' Returns True if the TypedView field FolioMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioMovimientoNull() As Boolean
			Return IsNull(_parent.FolioMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioMovimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioMovimientoNull() 
			Me(_parent.FolioMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."FechaMovimiento"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
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
		''' Returns True if the TypedView field FechaMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaMovimientoNull() As Boolean
			Return IsNull(_parent.FechaMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaMovimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaMovimientoNull() 
			Me(_parent.FechaMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Cantidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."Cantidad"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 18, 4, 0
		''' </remarks>
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
		''' Returns True if the TypedView field Cantidad is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadNull() As Boolean
			Return IsNull(_parent.CantidadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Cantidad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadNull() 
			Me(_parent.CantidadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Costo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."Costo"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
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
		''' Returns True if the TypedView field Costo is NULL, False otherwise.
		''' </summary>
		Public Function IsCostoNull() As Boolean
			Return IsNull(_parent.CostoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Costo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCostoNull() 
			Me(_parent.CostoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Descuento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."Descuento"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
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
		''' Returns True if the TypedView field Descuento is NULL, False otherwise.
		''' </summary>
		Public Function IsDescuentoNull() As Boolean
			Return IsNull(_parent.DescuentoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Descuento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDescuentoNull() 
			Me(_parent.DescuentoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TipoMovimientoId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."TipoMovimientoId"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
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
		''' Returns True if the TypedView field TipoMovimientoId is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoMovimientoIdNull() As Boolean
			Return IsNull(_parent.TipoMovimientoIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoMovimientoId to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoMovimientoIdNull() 
			Me(_parent.TipoMovimientoIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Origen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."Origen"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 30
		''' </remarks>
		Public Property [Origen]() As System.String
			Get 
				If IsOrigenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.OrigenColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.OrigenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Origen is NULL, False otherwise.
		''' </summary>
		Public Function IsOrigenNull() As Boolean
			Return IsNull(_parent.OrigenColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Origen to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetOrigenNull() 
			Me(_parent.OrigenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Descripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."Descripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 80
		''' </remarks>
		Public Property [Descripcion]() As System.String
			Get 
				If IsDescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.DescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.DescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Descripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsDescripcionNull() As Boolean
			Return IsNull(_parent.DescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Descripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDescripcionNull() 
			Me(_parent.DescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantidadEntradas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."CantidadEntradas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CantidadEntradas]() As System.Int32
			Get 
				If IsCantidadEntradasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CantidadEntradasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CantidadEntradasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantidadEntradas is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadEntradasNull() As Boolean
			Return IsNull(_parent.CantidadEntradasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantidadEntradas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadEntradasNull() 
			Me(_parent.CantidadEntradasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantidadSalidas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."CantidadSalidas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CantidadSalidas]() As System.Int32
			Get 
				If IsCantidadSalidasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CantidadSalidasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CantidadSalidasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantidadSalidas is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadSalidasNull() As Boolean
			Return IsNull(_parent.CantidadSalidasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantidadSalidas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadSalidasNull() 
			Me(_parent.CantidadSalidasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Direccion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."Direccion"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [Direccion]() As System.Int16
			Get 
				If IsDireccionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.DireccionColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.DireccionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Direccion is NULL, False otherwise.
		''' </summary>
		Public Function IsDireccionNull() As Boolean
			Return IsNull(_parent.DireccionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Direccion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDireccionNull() 
			Me(_parent.DireccionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantidadInicial<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwAlmKardex"."CantidadInicial"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 18, 4, 0
		''' </remarks>
		Public Property [CantidadInicial]() As System.Decimal
			Get 
				If IsCantidadInicialNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantidadInicialColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantidadInicialColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantidadInicial is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadInicialNull() As Boolean
			Return IsNull(_parent.CantidadInicialColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantidadInicial to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadInicialNull() 
			Me(_parent.CantidadInicialColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
