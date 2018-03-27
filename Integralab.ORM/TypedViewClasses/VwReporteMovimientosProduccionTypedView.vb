' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:39
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
	''' Typed datatable for the view 'VwReporteMovimientosProduccion'.<br/><br/>
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
	Public Class VwReporteMovimientosProduccionTypedView 
#Else
	Public Class VwReporteMovimientosProduccionTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnCodigo As DataColumn
		Private _columnNombre As DataColumn
		Private _columnIdMovimiento As DataColumn
		Private _columnTipoMovimiento As DataColumn
		Private _columnIdProducto As DataColumn
		Private _columnProducto As DataColumn
		Private _columnIdFolioMovimiento As DataColumn
		Private _columnFechaMovimiento As DataColumn
		Private _columnFechaCancelacion As DataColumn
		Private _columnQuienCancelo As DataColumn
		Private _columnCantKilos As DataColumn
		Private _columnCantPzas As DataColumn
		Private _columnCostoUnitario As DataColumn
		Private _columnIva As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 14
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
			MyBase.New("VwReporteMovimientosProduccion")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwReporteMovimientosProduccionTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwReporteMovimientosProduccionTypedView)
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
			Return New VwReporteMovimientosProduccionRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnCodigo = New DataColumn("Codigo", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCodigo.ReadOnly = True
			_columnCodigo.Caption = "Codigo"
			Me.Columns.Add(_columnCodigo)

			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnIdMovimiento = New DataColumn("IdMovimiento", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdMovimiento.ReadOnly = True
			_columnIdMovimiento.Caption = "IdMovimiento"
			Me.Columns.Add(_columnIdMovimiento)

			_columnTipoMovimiento = New DataColumn("TipoMovimiento", GetType(System.String), Nothing, MappingType.Element)
			_columnTipoMovimiento.ReadOnly = True
			_columnTipoMovimiento.Caption = "TipoMovimiento"
			Me.Columns.Add(_columnTipoMovimiento)

			_columnIdProducto = New DataColumn("IdProducto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProducto.ReadOnly = True
			_columnIdProducto.Caption = "IdProducto"
			Me.Columns.Add(_columnIdProducto)

			_columnProducto = New DataColumn("Producto", GetType(System.String), Nothing, MappingType.Element)
			_columnProducto.ReadOnly = True
			_columnProducto.Caption = "Producto"
			Me.Columns.Add(_columnProducto)

			_columnIdFolioMovimiento = New DataColumn("IdFolioMovimiento", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioMovimiento.ReadOnly = True
			_columnIdFolioMovimiento.Caption = "IdFolioMovimiento"
			Me.Columns.Add(_columnIdFolioMovimiento)

			_columnFechaMovimiento = New DataColumn("FechaMovimiento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaMovimiento.ReadOnly = True
			_columnFechaMovimiento.Caption = "FechaMovimiento"
			Me.Columns.Add(_columnFechaMovimiento)

			_columnFechaCancelacion = New DataColumn("FechaCancelacion", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCancelacion.ReadOnly = True
			_columnFechaCancelacion.Caption = "FechaCancelacion"
			Me.Columns.Add(_columnFechaCancelacion)

			_columnQuienCancelo = New DataColumn("QuienCancelo", GetType(System.String), Nothing, MappingType.Element)
			_columnQuienCancelo.ReadOnly = True
			_columnQuienCancelo.Caption = "QuienCancelo"
			Me.Columns.Add(_columnQuienCancelo)

			_columnCantKilos = New DataColumn("CantKilos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantKilos.ReadOnly = True
			_columnCantKilos.Caption = "CantKilos"
			Me.Columns.Add(_columnCantKilos)

			_columnCantPzas = New DataColumn("CantPzas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCantPzas.ReadOnly = True
			_columnCantPzas.Caption = "CantPzas"
			Me.Columns.Add(_columnCantPzas)

			_columnCostoUnitario = New DataColumn("CostoUnitario", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCostoUnitario.ReadOnly = True
			_columnCostoUnitario.Caption = "CostoUnitario"
			Me.Columns.Add(_columnCostoUnitario)

			_columnIva = New DataColumn("Iva", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnIva.ReadOnly = True
			_columnIva.Caption = "Iva"
			Me.Columns.Add(_columnIva)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnCodigo = Me.Columns("Codigo")
			_columnNombre = Me.Columns("Nombre")
			_columnIdMovimiento = Me.Columns("IdMovimiento")
			_columnTipoMovimiento = Me.Columns("TipoMovimiento")
			_columnIdProducto = Me.Columns("IdProducto")
			_columnProducto = Me.Columns("Producto")
			_columnIdFolioMovimiento = Me.Columns("IdFolioMovimiento")
			_columnFechaMovimiento = Me.Columns("FechaMovimiento")
			_columnFechaCancelacion = Me.Columns("FechaCancelacion")
			_columnQuienCancelo = Me.Columns("QuienCancelo")
			_columnCantKilos = Me.Columns("CantKilos")
			_columnCantPzas = Me.Columns("CantPzas")
			_columnCostoUnitario = Me.Columns("CostoUnitario")
			_columnIva = Me.Columns("Iva")
			
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

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Producto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("QuienCancelo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantKilos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantPzas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CostoUnitario", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwReporteMovimientosProduccionRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwReporteMovimientosProduccionTypedView = CType(MyBase.Clone(), VwReporteMovimientosProduccionTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwReporteMovimientosProduccionTypedView()
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
				Return VwReporteMovimientosProduccionTypedView.CustomProperties
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
				Return VwReporteMovimientosProduccionTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwReporteMovimientosProduccionRow
			Get 
				Return CType(Me.Rows(index), VwReporteMovimientosProduccionRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Codigo
		''' </summary>
		ReadOnly Friend Property CodigoColumn As DataColumn
			Get 
				Return _columnCodigo 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Nombre
		''' </summary>
		ReadOnly Friend Property NombreColumn As DataColumn
			Get 
				Return _columnNombre 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdMovimiento
		''' </summary>
		ReadOnly Friend Property IdMovimientoColumn As DataColumn
			Get 
				Return _columnIdMovimiento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TipoMovimiento
		''' </summary>
		ReadOnly Friend Property TipoMovimientoColumn As DataColumn
			Get 
				Return _columnTipoMovimiento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdProducto
		''' </summary>
		ReadOnly Friend Property IdProductoColumn As DataColumn
			Get 
				Return _columnIdProducto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Producto
		''' </summary>
		ReadOnly Friend Property ProductoColumn As DataColumn
			Get 
				Return _columnProducto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioMovimiento
		''' </summary>
		ReadOnly Friend Property IdFolioMovimientoColumn As DataColumn
			Get 
				Return _columnIdFolioMovimiento 
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
		''' Returns the column Object belonging to the TypedView field FechaCancelacion
		''' </summary>
		ReadOnly Friend Property FechaCancelacionColumn As DataColumn
			Get 
				Return _columnFechaCancelacion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field QuienCancelo
		''' </summary>
		ReadOnly Friend Property QuienCanceloColumn As DataColumn
			Get 
				Return _columnQuienCancelo 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantKilos
		''' </summary>
		ReadOnly Friend Property CantKilosColumn As DataColumn
			Get 
				Return _columnCantKilos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantPzas
		''' </summary>
		ReadOnly Friend Property CantPzasColumn As DataColumn
			Get 
				Return _columnCantPzas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CostoUnitario
		''' </summary>
		ReadOnly Friend Property CostoUnitarioColumn As DataColumn
			Get 
				Return _columnCostoUnitario 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Iva
		''' </summary>
		ReadOnly Friend Property IvaColumn As DataColumn
			Get 
				Return _columnIva 
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
	''' Typed datarow for the typed datatable VwReporteMovimientosProduccion
	''' </summary>
	Public Class VwReporteMovimientosProduccionRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwReporteMovimientosProduccionTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwReporteMovimientosProduccionTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field Codigo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."Codigo"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Codigo]() As System.Int32
			Get 
				If IsCodigoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CodigoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CodigoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Codigo is NULL, False otherwise.
		''' </summary>
		Public Function IsCodigoNull() As Boolean
			Return IsNull(_parent.CodigoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Codigo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodigoNull() 
			Me(_parent.CodigoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Nombre<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."Nombre"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [Nombre]() As System.String
			Get 
				If IsNombreNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NombreColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NombreColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Nombre is NULL, False otherwise.
		''' </summary>
		Public Function IsNombreNull() As Boolean
			Return IsNull(_parent.NombreColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Nombre to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNombreNull() 
			Me(_parent.NombreColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."IdMovimiento"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdMovimiento]() As System.Int32
			Get 
				If IsIdMovimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdMovimientoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdMovimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsIdMovimientoNull() As Boolean
			Return IsNull(_parent.IdMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdMovimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdMovimientoNull() 
			Me(_parent.IdMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TipoMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."TipoMovimiento"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [TipoMovimiento]() As System.String
			Get 
				If IsTipoMovimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TipoMovimientoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TipoMovimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoMovimientoNull() As Boolean
			Return IsNull(_parent.TipoMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoMovimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoMovimientoNull() 
			Me(_parent.TipoMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdProducto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."IdProducto"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdProducto]() As System.Int32
			Get 
				If IsIdProductoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdProductoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdProductoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdProducto is NULL, False otherwise.
		''' </summary>
		Public Function IsIdProductoNull() As Boolean
			Return IsNull(_parent.IdProductoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdProducto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdProductoNull() 
			Me(_parent.IdProductoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Producto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."Producto"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
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
		''' Returns True if the TypedView field Producto is NULL, False otherwise.
		''' </summary>
		Public Function IsProductoNull() As Boolean
			Return IsNull(_parent.ProductoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Producto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetProductoNull() 
			Me(_parent.ProductoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."IdFolioMovimiento"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 12
		''' </remarks>
		Public Property [IdFolioMovimiento]() As System.String
			Get 
				If IsIdFolioMovimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioMovimientoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioMovimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioMovimientoNull() As Boolean
			Return IsNull(_parent.IdFolioMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioMovimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioMovimientoNull() 
			Me(_parent.IdFolioMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."FechaMovimiento"<br/>
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
		''' Gets / sets the value of the TypedView field FechaCancelacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."FechaCancelacion"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaCancelacion]() As System.DateTime
			Get 
				If IsFechaCancelacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaCancelacionColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaCancelacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaCancelacion is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaCancelacionNull() As Boolean
			Return IsNull(_parent.FechaCancelacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaCancelacion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaCancelacionNull() 
			Me(_parent.FechaCancelacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field QuienCancelo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."QuienCancelo"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 50
		''' </remarks>
		Public Property [QuienCancelo]() As System.String
			Get 
				If IsQuienCanceloNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.QuienCanceloColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.QuienCanceloColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field QuienCancelo is NULL, False otherwise.
		''' </summary>
		Public Function IsQuienCanceloNull() As Boolean
			Return IsNull(_parent.QuienCanceloColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field QuienCancelo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetQuienCanceloNull() 
			Me(_parent.QuienCanceloColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantKilos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."CantKilos"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CantKilos]() As System.Decimal
			Get 
				If IsCantKilosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantKilosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantKilosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantKilos is NULL, False otherwise.
		''' </summary>
		Public Function IsCantKilosNull() As Boolean
			Return IsNull(_parent.CantKilosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantKilos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantKilosNull() 
			Me(_parent.CantKilosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantPzas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."CantPzas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CantPzas]() As System.Int32
			Get 
				If IsCantPzasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CantPzasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CantPzasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantPzas is NULL, False otherwise.
		''' </summary>
		Public Function IsCantPzasNull() As Boolean
			Return IsNull(_parent.CantPzasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantPzas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantPzasNull() 
			Me(_parent.CantPzasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CostoUnitario<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."CostoUnitario"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CostoUnitario]() As System.Decimal
			Get 
				If IsCostoUnitarioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CostoUnitarioColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CostoUnitarioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CostoUnitario is NULL, False otherwise.
		''' </summary>
		Public Function IsCostoUnitarioNull() As Boolean
			Return IsNull(_parent.CostoUnitarioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CostoUnitario to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCostoUnitarioNull() 
			Me(_parent.CostoUnitarioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Iva<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteMovimientosProduccion"."IVA"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
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
		''' Returns True if the TypedView field Iva is NULL, False otherwise.
		''' </summary>
		Public Function IsIvaNull() As Boolean
			Return IsNull(_parent.IvaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Iva to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIvaNull() 
			Me(_parent.IvaColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
