' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 5 de enero de 2018 17:48:24
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
	''' Typed datatable for the view 'VwCxpfacturas'.<br/><br/>
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
	Public Class VwCxpfacturasTypedView 
#Else
	Public Class VwCxpfacturasTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnNoFactura As DataColumn
		Private _columnIdProveedor As DataColumn
		Private _columnFechaFactura As DataColumn
		Private _columnPrIdTipoProveedor As DataColumn
		Private _columnTprDescripcion As DataColumn
		Private _columnPrRazSocial As DataColumn
		Private _columnFechaVencimiento As DataColumn
		Private _columnSubTotal As DataColumn
		Private _columnIva As DataColumn
		Private _columnTotal As DataColumn
		Private _columnAnticipo As DataColumn
		Private _columnFolioRecepcion As DataColumn
		Private _columnFecha As DataColumn
		Private _columnFolioOrdenCompra As DataColumn
		Private _columnCantidadRecepcion As DataColumn
		Private _columnImporteRecepcion As DataColumn
		Private _columnEstatusFacturas As DataColumn
		Private _columnCheque As DataColumn
		Private _columnSubtotalRecepcion As DataColumn
		Private _columnIvaRecepcion As DataColumn
		Private _columnEsServicio As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 21
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
			MyBase.New("VwCxpfacturas")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCxpfacturasTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCxpfacturasTypedView)
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
			Return New VwCxpfacturasRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnNoFactura = New DataColumn("NoFactura", GetType(System.String), Nothing, MappingType.Element)
			_columnNoFactura.ReadOnly = True
			_columnNoFactura.Caption = "NoFactura"
			Me.Columns.Add(_columnNoFactura)

			_columnIdProveedor = New DataColumn("IdProveedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProveedor.ReadOnly = True
			_columnIdProveedor.Caption = "IdProveedor"
			Me.Columns.Add(_columnIdProveedor)

			_columnFechaFactura = New DataColumn("FechaFactura", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaFactura.ReadOnly = True
			_columnFechaFactura.Caption = "FechaFactura"
			Me.Columns.Add(_columnFechaFactura)

			_columnPrIdTipoProveedor = New DataColumn("PrIdTipoProveedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPrIdTipoProveedor.ReadOnly = True
			_columnPrIdTipoProveedor.Caption = "PrIdTipoProveedor"
			Me.Columns.Add(_columnPrIdTipoProveedor)

			_columnTprDescripcion = New DataColumn("TprDescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnTprDescripcion.ReadOnly = True
			_columnTprDescripcion.Caption = "TprDescripcion"
			Me.Columns.Add(_columnTprDescripcion)

			_columnPrRazSocial = New DataColumn("PrRazSocial", GetType(System.String), Nothing, MappingType.Element)
			_columnPrRazSocial.ReadOnly = True
			_columnPrRazSocial.Caption = "PrRazSocial"
			Me.Columns.Add(_columnPrRazSocial)

			_columnFechaVencimiento = New DataColumn("FechaVencimiento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaVencimiento.ReadOnly = True
			_columnFechaVencimiento.Caption = "FechaVencimiento"
			Me.Columns.Add(_columnFechaVencimiento)

			_columnSubTotal = New DataColumn("SubTotal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSubTotal.ReadOnly = True
			_columnSubTotal.Caption = "SubTotal"
			Me.Columns.Add(_columnSubTotal)

			_columnIva = New DataColumn("Iva", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnIva.ReadOnly = True
			_columnIva.Caption = "Iva"
			Me.Columns.Add(_columnIva)

			_columnTotal = New DataColumn("Total", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotal.ReadOnly = True
			_columnTotal.Caption = "Total"
			Me.Columns.Add(_columnTotal)

			_columnAnticipo = New DataColumn("Anticipo", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnAnticipo.ReadOnly = True
			_columnAnticipo.Caption = "Anticipo"
			Me.Columns.Add(_columnAnticipo)

			_columnFolioRecepcion = New DataColumn("FolioRecepcion", GetType(System.Int32), Nothing, MappingType.Element)
			_columnFolioRecepcion.ReadOnly = True
			_columnFolioRecepcion.Caption = "FolioRecepcion"
			Me.Columns.Add(_columnFolioRecepcion)

			_columnFecha = New DataColumn("Fecha", GetType(System.String), Nothing, MappingType.Element)
			_columnFecha.ReadOnly = True
			_columnFecha.Caption = "Fecha"
			Me.Columns.Add(_columnFecha)

			_columnFolioOrdenCompra = New DataColumn("FolioOrdenCompra", GetType(System.Int32), Nothing, MappingType.Element)
			_columnFolioOrdenCompra.ReadOnly = True
			_columnFolioOrdenCompra.Caption = "FolioOrdenCompra"
			Me.Columns.Add(_columnFolioOrdenCompra)

			_columnCantidadRecepcion = New DataColumn("CantidadRecepcion", GetType(System.String), Nothing, MappingType.Element)
			_columnCantidadRecepcion.ReadOnly = True
			_columnCantidadRecepcion.Caption = "CantidadRecepcion"
			Me.Columns.Add(_columnCantidadRecepcion)

			_columnImporteRecepcion = New DataColumn("ImporteRecepcion", GetType(System.String), Nothing, MappingType.Element)
			_columnImporteRecepcion.ReadOnly = True
			_columnImporteRecepcion.Caption = "ImporteRecepcion"
			Me.Columns.Add(_columnImporteRecepcion)

			_columnEstatusFacturas = New DataColumn("EstatusFacturas", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusFacturas.ReadOnly = True
			_columnEstatusFacturas.Caption = "EstatusFacturas"
			Me.Columns.Add(_columnEstatusFacturas)

			_columnCheque = New DataColumn("Cheque", GetType(System.String), Nothing, MappingType.Element)
			_columnCheque.ReadOnly = True
			_columnCheque.Caption = "Cheque"
			Me.Columns.Add(_columnCheque)

			_columnSubtotalRecepcion = New DataColumn("SubtotalRecepcion", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSubtotalRecepcion.ReadOnly = True
			_columnSubtotalRecepcion.Caption = "SubtotalRecepcion"
			Me.Columns.Add(_columnSubtotalRecepcion)

			_columnIvaRecepcion = New DataColumn("IvaRecepcion", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnIvaRecepcion.ReadOnly = True
			_columnIvaRecepcion.Caption = "IvaRecepcion"
			Me.Columns.Add(_columnIvaRecepcion)

			_columnEsServicio = New DataColumn("EsServicio", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnEsServicio.ReadOnly = True
			_columnEsServicio.Caption = "EsServicio"
			Me.Columns.Add(_columnEsServicio)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnNoFactura = Me.Columns("NoFactura")
			_columnIdProveedor = Me.Columns("IdProveedor")
			_columnFechaFactura = Me.Columns("FechaFactura")
			_columnPrIdTipoProveedor = Me.Columns("PrIdTipoProveedor")
			_columnTprDescripcion = Me.Columns("TprDescripcion")
			_columnPrRazSocial = Me.Columns("PrRazSocial")
			_columnFechaVencimiento = Me.Columns("FechaVencimiento")
			_columnSubTotal = Me.Columns("SubTotal")
			_columnIva = Me.Columns("Iva")
			_columnTotal = Me.Columns("Total")
			_columnAnticipo = Me.Columns("Anticipo")
			_columnFolioRecepcion = Me.Columns("FolioRecepcion")
			_columnFecha = Me.Columns("Fecha")
			_columnFolioOrdenCompra = Me.Columns("FolioOrdenCompra")
			_columnCantidadRecepcion = Me.Columns("CantidadRecepcion")
			_columnImporteRecepcion = Me.Columns("ImporteRecepcion")
			_columnEstatusFacturas = Me.Columns("EstatusFacturas")
			_columnCheque = Me.Columns("Cheque")
			_columnSubtotalRecepcion = Me.Columns("SubtotalRecepcion")
			_columnIvaRecepcion = Me.Columns("IvaRecepcion")
			_columnEsServicio = Me.Columns("EsServicio")
			
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

			_fieldsCustomProperties.Add("NoFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrIdTipoProveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TprDescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrRazSocial", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaVencimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Anticipo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioRecepcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Fecha", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioOrdenCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantidadRecepcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImporteRecepcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusFacturas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cheque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SubtotalRecepcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IvaRecepcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EsServicio", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwCxpfacturasRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwCxpfacturasTypedView = CType(MyBase.Clone(), VwCxpfacturasTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwCxpfacturasTypedView()
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
				Return VwCxpfacturasTypedView.CustomProperties
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
				Return VwCxpfacturasTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwCxpfacturasRow
			Get 
				Return CType(Me.Rows(index), VwCxpfacturasRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field NoFactura
		''' </summary>
		ReadOnly Friend Property NoFacturaColumn As DataColumn
			Get 
				Return _columnNoFactura 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdProveedor
		''' </summary>
		ReadOnly Friend Property IdProveedorColumn As DataColumn
			Get 
				Return _columnIdProveedor 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaFactura
		''' </summary>
		ReadOnly Friend Property FechaFacturaColumn As DataColumn
			Get 
				Return _columnFechaFactura 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrIdTipoProveedor
		''' </summary>
		ReadOnly Friend Property PrIdTipoProveedorColumn As DataColumn
			Get 
				Return _columnPrIdTipoProveedor 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TprDescripcion
		''' </summary>
		ReadOnly Friend Property TprDescripcionColumn As DataColumn
			Get 
				Return _columnTprDescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrRazSocial
		''' </summary>
		ReadOnly Friend Property PrRazSocialColumn As DataColumn
			Get 
				Return _columnPrRazSocial 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaVencimiento
		''' </summary>
		ReadOnly Friend Property FechaVencimientoColumn As DataColumn
			Get 
				Return _columnFechaVencimiento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SubTotal
		''' </summary>
		ReadOnly Friend Property SubTotalColumn As DataColumn
			Get 
				Return _columnSubTotal 
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
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Total
		''' </summary>
		ReadOnly Friend Property TotalColumn As DataColumn
			Get 
				Return _columnTotal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Anticipo
		''' </summary>
		ReadOnly Friend Property AnticipoColumn As DataColumn
			Get 
				Return _columnAnticipo 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioRecepcion
		''' </summary>
		ReadOnly Friend Property FolioRecepcionColumn As DataColumn
			Get 
				Return _columnFolioRecepcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Fecha
		''' </summary>
		ReadOnly Friend Property FechaColumn As DataColumn
			Get 
				Return _columnFecha 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioOrdenCompra
		''' </summary>
		ReadOnly Friend Property FolioOrdenCompraColumn As DataColumn
			Get 
				Return _columnFolioOrdenCompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantidadRecepcion
		''' </summary>
		ReadOnly Friend Property CantidadRecepcionColumn As DataColumn
			Get 
				Return _columnCantidadRecepcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImporteRecepcion
		''' </summary>
		ReadOnly Friend Property ImporteRecepcionColumn As DataColumn
			Get 
				Return _columnImporteRecepcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EstatusFacturas
		''' </summary>
		ReadOnly Friend Property EstatusFacturasColumn As DataColumn
			Get 
				Return _columnEstatusFacturas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Cheque
		''' </summary>
		ReadOnly Friend Property ChequeColumn As DataColumn
			Get 
				Return _columnCheque 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SubtotalRecepcion
		''' </summary>
		ReadOnly Friend Property SubtotalRecepcionColumn As DataColumn
			Get 
				Return _columnSubtotalRecepcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IvaRecepcion
		''' </summary>
		ReadOnly Friend Property IvaRecepcionColumn As DataColumn
			Get 
				Return _columnIvaRecepcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EsServicio
		''' </summary>
		ReadOnly Friend Property EsServicioColumn As DataColumn
			Get 
				Return _columnEsServicio 
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
	''' Typed datarow for the typed datatable VwCxpfacturas
	''' </summary>
	Public Class VwCxpfacturasRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwCxpfacturasTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwCxpfacturasTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field NoFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."NoFactura"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 40
		''' </remarks>
		Public Property [NoFactura]() As System.String
			Get 
				If IsNoFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NoFacturaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NoFacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NoFactura is NULL, False otherwise.
		''' </summary>
		Public Function IsNoFacturaNull() As Boolean
			Return IsNull(_parent.NoFacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NoFactura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNoFacturaNull() 
			Me(_parent.NoFacturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdProveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."IdProveedor"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdProveedor]() As System.Int32
			Get 
				If IsIdProveedorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdProveedorColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdProveedorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdProveedor is NULL, False otherwise.
		''' </summary>
		Public Function IsIdProveedorNull() As Boolean
			Return IsNull(_parent.IdProveedorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdProveedor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdProveedorNull() 
			Me(_parent.IdProveedorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."FechaFactura"<br/>
		''' View field characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaFactura]() As System.DateTime
			Get 
				If IsFechaFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaFacturaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaFacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaFactura is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaFacturaNull() As Boolean
			Return IsNull(_parent.FechaFacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaFactura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaFacturaNull() 
			Me(_parent.FechaFacturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrIdTipoProveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."PrIdTipoProveedor"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PrIdTipoProveedor]() As System.Int32
			Get 
				If IsPrIdTipoProveedorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PrIdTipoProveedorColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PrIdTipoProveedorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrIdTipoProveedor is NULL, False otherwise.
		''' </summary>
		Public Function IsPrIdTipoProveedorNull() As Boolean
			Return IsNull(_parent.PrIdTipoProveedorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrIdTipoProveedor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrIdTipoProveedorNull() 
			Me(_parent.PrIdTipoProveedorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TprDescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."TPrDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 80
		''' </remarks>
		Public Property [TprDescripcion]() As System.String
			Get 
				If IsTprDescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TprDescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TprDescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TprDescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsTprDescripcionNull() As Boolean
			Return IsNull(_parent.TprDescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TprDescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTprDescripcionNull() 
			Me(_parent.TprDescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrRazSocial<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."PrRazSocial"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [PrRazSocial]() As System.String
			Get 
				If IsPrRazSocialNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrRazSocialColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrRazSocialColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrRazSocial is NULL, False otherwise.
		''' </summary>
		Public Function IsPrRazSocialNull() As Boolean
			Return IsNull(_parent.PrRazSocialColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrRazSocial to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrRazSocialNull() 
			Me(_parent.PrRazSocialColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaVencimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."FechaVencimiento"<br/>
		''' View field characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaVencimiento]() As System.DateTime
			Get 
				If IsFechaVencimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaVencimientoColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaVencimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaVencimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaVencimientoNull() As Boolean
			Return IsNull(_parent.FechaVencimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaVencimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaVencimientoNull() 
			Me(_parent.FechaVencimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SubTotal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."SubTotal"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
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
		''' Returns True if the TypedView field SubTotal is NULL, False otherwise.
		''' </summary>
		Public Function IsSubTotalNull() As Boolean
			Return IsNull(_parent.SubTotalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SubTotal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSubTotalNull() 
			Me(_parent.SubTotalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Iva<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."IVA"<br/>
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

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Total<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."Total"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
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
		''' Returns True if the TypedView field Total is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalNull() As Boolean
			Return IsNull(_parent.TotalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Total to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalNull() 
			Me(_parent.TotalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Anticipo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."Anticipo"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [Anticipo]() As System.Decimal
			Get 
				If IsAnticipoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.AnticipoColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.AnticipoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Anticipo is NULL, False otherwise.
		''' </summary>
		Public Function IsAnticipoNull() As Boolean
			Return IsNull(_parent.AnticipoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Anticipo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAnticipoNull() 
			Me(_parent.AnticipoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioRecepcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."FolioRecepcion"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [FolioRecepcion]() As System.Int32
			Get 
				If IsFolioRecepcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.FolioRecepcionColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.FolioRecepcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioRecepcion is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioRecepcionNull() As Boolean
			Return IsNull(_parent.FolioRecepcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioRecepcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioRecepcionNull() 
			Me(_parent.FolioRecepcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Fecha<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."Fecha"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 30
		''' </remarks>
		Public Property [Fecha]() As System.String
			Get 
				If IsFechaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FechaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FechaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Fecha is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaNull() As Boolean
			Return IsNull(_parent.FechaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Fecha to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaNull() 
			Me(_parent.FechaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioOrdenCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."FolioOrdenCompra"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [FolioOrdenCompra]() As System.Int32
			Get 
				If IsFolioOrdenCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.FolioOrdenCompraColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.FolioOrdenCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioOrdenCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioOrdenCompraNull() As Boolean
			Return IsNull(_parent.FolioOrdenCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioOrdenCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioOrdenCompraNull() 
			Me(_parent.FolioOrdenCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantidadRecepcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."CantidadRecepcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 30
		''' </remarks>
		Public Property [CantidadRecepcion]() As System.String
			Get 
				If IsCantidadRecepcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CantidadRecepcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CantidadRecepcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantidadRecepcion is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadRecepcionNull() As Boolean
			Return IsNull(_parent.CantidadRecepcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantidadRecepcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadRecepcionNull() 
			Me(_parent.CantidadRecepcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImporteRecepcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."ImporteRecepcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 30
		''' </remarks>
		Public Property [ImporteRecepcion]() As System.String
			Get 
				If IsImporteRecepcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ImporteRecepcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ImporteRecepcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImporteRecepcion is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteRecepcionNull() As Boolean
			Return IsNull(_parent.ImporteRecepcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImporteRecepcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteRecepcionNull() 
			Me(_parent.ImporteRecepcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EstatusFacturas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."EstatusFacturas"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 15
		''' </remarks>
		Public Property [EstatusFacturas]() As System.String
			Get 
				If IsEstatusFacturasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EstatusFacturasColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EstatusFacturasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EstatusFacturas is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusFacturasNull() As Boolean
			Return IsNull(_parent.EstatusFacturasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EstatusFacturas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusFacturasNull() 
			Me(_parent.EstatusFacturasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Cheque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."Cheque"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [Cheque]() As System.String
			Get 
				If IsChequeNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ChequeColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ChequeColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Cheque is NULL, False otherwise.
		''' </summary>
		Public Function IsChequeNull() As Boolean
			Return IsNull(_parent.ChequeColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Cheque to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetChequeNull() 
			Me(_parent.ChequeColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SubtotalRecepcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."SubtotalRecepcion"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [SubtotalRecepcion]() As System.Decimal
			Get 
				If IsSubtotalRecepcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SubtotalRecepcionColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SubtotalRecepcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SubtotalRecepcion is NULL, False otherwise.
		''' </summary>
		Public Function IsSubtotalRecepcionNull() As Boolean
			Return IsNull(_parent.SubtotalRecepcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SubtotalRecepcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSubtotalRecepcionNull() 
			Me(_parent.SubtotalRecepcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IvaRecepcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."IvaRecepcion"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [IvaRecepcion]() As System.Decimal
			Get 
				If IsIvaRecepcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.IvaRecepcionColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.IvaRecepcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IvaRecepcion is NULL, False otherwise.
		''' </summary>
		Public Function IsIvaRecepcionNull() As Boolean
			Return IsNull(_parent.IvaRecepcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IvaRecepcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIvaRecepcionNull() 
			Me(_parent.IvaRecepcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EsServicio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCXPFacturas"."EsServicio"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [EsServicio]() As System.Boolean
			Get 
				If IsEsServicioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.EsServicioColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.EsServicioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EsServicio is NULL, False otherwise.
		''' </summary>
		Public Function IsEsServicioNull() As Boolean
			Return IsNull(_parent.EsServicioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EsServicio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEsServicioNull() 
			Me(_parent.EsServicioColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
