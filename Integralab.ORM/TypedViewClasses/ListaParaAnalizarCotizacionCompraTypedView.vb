' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 26 de enero de 2018 13:41:35
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
	''' Typed datatable for the view 'ListaParaAnalizarCotizacionCompra'.<br/><br/>
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
	Public Class ListaParaAnalizarCotizacionCompraTypedView 
#Else
	Public Class ListaParaAnalizarCotizacionCompraTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnIdSucursal As DataColumn
		Private _columnIdCotizacion As DataColumn
		Private _columnCodigo As DataColumn
		Private _columnProducto As DataColumn
		Private _columnCantidad As DataColumn
		Private _columnCodigoProveedor As DataColumn
		Private _columnProveedor As DataColumn
		Private _columnPrecio As DataColumn
		Private _columnDescuento As DataColumn
		Private _columnImporte As DataColumn
		Private _columnPlaza As DataColumn
		Private _columnAplicaIva As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
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
			MyBase.New("ListaParaAnalizarCotizacionCompra")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.ListaParaAnalizarCotizacionCompraTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.ListaParaAnalizarCotizacionCompraTypedView)
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
			Return New ListaParaAnalizarCotizacionCompraRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnIdSucursal = New DataColumn("IdSucursal", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdSucursal.ReadOnly = True
			_columnIdSucursal.Caption = "IdSucursal"
			Me.Columns.Add(_columnIdSucursal)

			_columnIdCotizacion = New DataColumn("IdCotizacion", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCotizacion.ReadOnly = True
			_columnIdCotizacion.Caption = "IdCotizacion"
			Me.Columns.Add(_columnIdCotizacion)

			_columnCodigo = New DataColumn("Codigo", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCodigo.ReadOnly = True
			_columnCodigo.Caption = "Codigo"
			Me.Columns.Add(_columnCodigo)

			_columnProducto = New DataColumn("Producto", GetType(System.String), Nothing, MappingType.Element)
			_columnProducto.ReadOnly = True
			_columnProducto.Caption = "Producto"
			Me.Columns.Add(_columnProducto)

			_columnCantidad = New DataColumn("Cantidad", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidad.ReadOnly = True
			_columnCantidad.Caption = "Cantidad"
			Me.Columns.Add(_columnCantidad)

			_columnCodigoProveedor = New DataColumn("CodigoProveedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCodigoProveedor.ReadOnly = True
			_columnCodigoProveedor.Caption = "CodigoProveedor"
			Me.Columns.Add(_columnCodigoProveedor)

			_columnProveedor = New DataColumn("Proveedor", GetType(System.String), Nothing, MappingType.Element)
			_columnProveedor.ReadOnly = True
			_columnProveedor.Caption = "Proveedor"
			Me.Columns.Add(_columnProveedor)

			_columnPrecio = New DataColumn("Precio", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPrecio.ReadOnly = True
			_columnPrecio.Caption = "Precio"
			Me.Columns.Add(_columnPrecio)

			_columnDescuento = New DataColumn("Descuento", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnDescuento.ReadOnly = True
			_columnDescuento.Caption = "Descuento"
			Me.Columns.Add(_columnDescuento)

			_columnImporte = New DataColumn("Importe", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporte.ReadOnly = True
			_columnImporte.Caption = "Importe"
			Me.Columns.Add(_columnImporte)

			_columnPlaza = New DataColumn("Plaza", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPlaza.ReadOnly = True
			_columnPlaza.Caption = "Plaza"
			Me.Columns.Add(_columnPlaza)

			_columnAplicaIva = New DataColumn("AplicaIva", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnAplicaIva.ReadOnly = True
			_columnAplicaIva.Caption = "AplicaIva"
			Me.Columns.Add(_columnAplicaIva)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnIdSucursal = Me.Columns("IdSucursal")
			_columnIdCotizacion = Me.Columns("IdCotizacion")
			_columnCodigo = Me.Columns("Codigo")
			_columnProducto = Me.Columns("Producto")
			_columnCantidad = Me.Columns("Cantidad")
			_columnCodigoProveedor = Me.Columns("CodigoProveedor")
			_columnProveedor = Me.Columns("Proveedor")
			_columnPrecio = Me.Columns("Precio")
			_columnDescuento = Me.Columns("Descuento")
			_columnImporte = Me.Columns("Importe")
			_columnPlaza = Me.Columns("Plaza")
			_columnAplicaIva = Me.Columns("AplicaIva")
			
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

			_fieldsCustomProperties.Add("IdSucursal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCotizacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Producto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CodigoProveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Proveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Precio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Plaza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("AplicaIva", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(ListaParaAnalizarCotizacionCompraRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As ListaParaAnalizarCotizacionCompraTypedView = CType(MyBase.Clone(), ListaParaAnalizarCotizacionCompraTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New ListaParaAnalizarCotizacionCompraTypedView()
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
				Return ListaParaAnalizarCotizacionCompraTypedView.CustomProperties
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
				Return ListaParaAnalizarCotizacionCompraTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As ListaParaAnalizarCotizacionCompraRow
			Get 
				Return CType(Me.Rows(index), ListaParaAnalizarCotizacionCompraRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdSucursal
		''' </summary>
		ReadOnly Friend Property IdSucursalColumn As DataColumn
			Get 
				Return _columnIdSucursal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdCotizacion
		''' </summary>
		ReadOnly Friend Property IdCotizacionColumn As DataColumn
			Get 
				Return _columnIdCotizacion 
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
		''' Returns the column Object belonging to the TypedView field Producto
		''' </summary>
		ReadOnly Friend Property ProductoColumn As DataColumn
			Get 
				Return _columnProducto 
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
		''' Returns the column Object belonging to the TypedView field CodigoProveedor
		''' </summary>
		ReadOnly Friend Property CodigoProveedorColumn As DataColumn
			Get 
				Return _columnCodigoProveedor 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Proveedor
		''' </summary>
		ReadOnly Friend Property ProveedorColumn As DataColumn
			Get 
				Return _columnProveedor 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Precio
		''' </summary>
		ReadOnly Friend Property PrecioColumn As DataColumn
			Get 
				Return _columnPrecio 
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
		''' Returns the column Object belonging to the TypedView field Importe
		''' </summary>
		ReadOnly Friend Property ImporteColumn As DataColumn
			Get 
				Return _columnImporte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Plaza
		''' </summary>
		ReadOnly Friend Property PlazaColumn As DataColumn
			Get 
				Return _columnPlaza 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field AplicaIva
		''' </summary>
		ReadOnly Friend Property AplicaIvaColumn As DataColumn
			Get 
				Return _columnAplicaIva 
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
	''' Typed datarow for the typed datatable ListaParaAnalizarCotizacionCompra
	''' </summary>
	Public Class ListaParaAnalizarCotizacionCompraRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As ListaParaAnalizarCotizacionCompraTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, ListaParaAnalizarCotizacionCompraTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field IdSucursal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."IdSucursal"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdSucursal]() As System.Int32
			Get 
				If IsIdSucursalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdSucursalColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdSucursalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdSucursal is NULL, False otherwise.
		''' </summary>
		Public Function IsIdSucursalNull() As Boolean
			Return IsNull(_parent.IdSucursalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdSucursal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdSucursalNull() 
			Me(_parent.IdSucursalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCotizacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."IdCotizacion"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdCotizacion]() As System.Int32
			Get 
				If IsIdCotizacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdCotizacionColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdCotizacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdCotizacion is NULL, False otherwise.
		''' </summary>
		Public Function IsIdCotizacionNull() As Boolean
			Return IsNull(_parent.IdCotizacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdCotizacion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdCotizacionNull() 
			Me(_parent.IdCotizacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Codigo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."Codigo"<br/>
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
		''' Gets / sets the value of the TypedView field Producto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."Producto"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
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
		''' Gets / sets the value of the TypedView field Cantidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."Cantidad"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
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
		''' Gets / sets the value of the TypedView field CodigoProveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."CodigoProveedor"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CodigoProveedor]() As System.Int32
			Get 
				If IsCodigoProveedorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CodigoProveedorColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CodigoProveedorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CodigoProveedor is NULL, False otherwise.
		''' </summary>
		Public Function IsCodigoProveedorNull() As Boolean
			Return IsNull(_parent.CodigoProveedorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CodigoProveedor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodigoProveedorNull() 
			Me(_parent.CodigoProveedorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Proveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."Proveedor"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [Proveedor]() As System.String
			Get 
				If IsProveedorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ProveedorColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ProveedorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Proveedor is NULL, False otherwise.
		''' </summary>
		Public Function IsProveedorNull() As Boolean
			Return IsNull(_parent.ProveedorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Proveedor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetProveedorNull() 
			Me(_parent.ProveedorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Precio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."Precio"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [Precio]() As System.Decimal
			Get 
				If IsPrecioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PrecioColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PrecioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Precio is NULL, False otherwise.
		''' </summary>
		Public Function IsPrecioNull() As Boolean
			Return IsNull(_parent.PrecioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Precio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrecioNull() 
			Me(_parent.PrecioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Descuento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."Descuento"<br/>
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
		''' Gets / sets the value of the TypedView field Importe<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."Importe"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
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
		''' Returns True if the TypedView field Importe is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteNull() As Boolean
			Return IsNull(_parent.ImporteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Importe to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteNull() 
			Me(_parent.ImporteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Plaza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."Plaza"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Plaza]() As System.Int32
			Get 
				If IsPlazaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PlazaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PlazaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Plaza is NULL, False otherwise.
		''' </summary>
		Public Function IsPlazaNull() As Boolean
			Return IsNull(_parent.PlazaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Plaza to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPlazaNull() 
			Me(_parent.PlazaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field AplicaIva<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ListaParaAnalizarCotizacionCompra"."AplicaIva"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [AplicaIva]() As System.Boolean
			Get 
				If IsAplicaIvaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.AplicaIvaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.AplicaIvaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field AplicaIva is NULL, False otherwise.
		''' </summary>
		Public Function IsAplicaIvaNull() As Boolean
			Return IsNull(_parent.AplicaIvaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field AplicaIva to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAplicaIvaNull() 
			Me(_parent.AplicaIvaColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
