' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 17:53:02
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
	''' Typed datatable for the view 'VwCompConsultaOrdenCompra'.<br/><br/>
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
	Public Class VwCompConsultaOrdenCompraTypedView 
#Else
	Public Class VwCompConsultaOrdenCompraTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnIdOrdenCompra As DataColumn
		Private _columnFolioOrdenCompra As DataColumn
		Private _columnPlIdPlaza As DataColumn
		Private _columnPlDescripcion As DataColumn
		Private _columnIdSucursal As DataColumn
		Private _columnSucursal As DataColumn
		Private _columnIdProveedor As DataColumn
		Private _columnProveedor As DataColumn
		Private _columnImporte As DataColumn
		Private _columnDescuento As DataColumn
		Private _columnSubTotal As DataColumn
		Private _columnIvatotal As DataColumn
		Private _columnTotal As DataColumn
		Private _columnFechaOrdenCompra As DataColumn
		Private _columnObservaciones As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnAutorizada As DataColumn
		Private _columnRecibida As DataColumn
		Private _columnEstatusDes As DataColumn
		Private _columnMoneda As DataColumn
		Private _columnTipoCambio As DataColumn
		
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
			MyBase.New("VwCompConsultaOrdenCompra")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCompConsultaOrdenCompraTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCompConsultaOrdenCompraTypedView)
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
			Return New VwCompConsultaOrdenCompraRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnIdOrdenCompra = New DataColumn("IdOrdenCompra", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdOrdenCompra.ReadOnly = True
			_columnIdOrdenCompra.Caption = "IdOrdenCompra"
			Me.Columns.Add(_columnIdOrdenCompra)

			_columnFolioOrdenCompra = New DataColumn("FolioOrdenCompra", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioOrdenCompra.ReadOnly = True
			_columnFolioOrdenCompra.Caption = "FolioOrdenCompra"
			Me.Columns.Add(_columnFolioOrdenCompra)

			_columnPlIdPlaza = New DataColumn("PlIdPlaza", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPlIdPlaza.ReadOnly = True
			_columnPlIdPlaza.Caption = "PlIdPlaza"
			Me.Columns.Add(_columnPlIdPlaza)

			_columnPlDescripcion = New DataColumn("PlDescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnPlDescripcion.ReadOnly = True
			_columnPlDescripcion.Caption = "PlDescripcion"
			Me.Columns.Add(_columnPlDescripcion)

			_columnIdSucursal = New DataColumn("IdSucursal", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdSucursal.ReadOnly = True
			_columnIdSucursal.Caption = "IdSucursal"
			Me.Columns.Add(_columnIdSucursal)

			_columnSucursal = New DataColumn("Sucursal", GetType(System.String), Nothing, MappingType.Element)
			_columnSucursal.ReadOnly = True
			_columnSucursal.Caption = "Sucursal"
			Me.Columns.Add(_columnSucursal)

			_columnIdProveedor = New DataColumn("IdProveedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProveedor.ReadOnly = True
			_columnIdProveedor.Caption = "IdProveedor"
			Me.Columns.Add(_columnIdProveedor)

			_columnProveedor = New DataColumn("Proveedor", GetType(System.String), Nothing, MappingType.Element)
			_columnProveedor.ReadOnly = True
			_columnProveedor.Caption = "Proveedor"
			Me.Columns.Add(_columnProveedor)

			_columnImporte = New DataColumn("Importe", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporte.ReadOnly = True
			_columnImporte.Caption = "Importe"
			Me.Columns.Add(_columnImporte)

			_columnDescuento = New DataColumn("Descuento", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnDescuento.ReadOnly = True
			_columnDescuento.Caption = "Descuento"
			Me.Columns.Add(_columnDescuento)

			_columnSubTotal = New DataColumn("SubTotal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSubTotal.ReadOnly = True
			_columnSubTotal.Caption = "SubTotal"
			Me.Columns.Add(_columnSubTotal)

			_columnIvatotal = New DataColumn("Ivatotal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnIvatotal.ReadOnly = True
			_columnIvatotal.Caption = "Ivatotal"
			Me.Columns.Add(_columnIvatotal)

			_columnTotal = New DataColumn("Total", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotal.ReadOnly = True
			_columnTotal.Caption = "Total"
			Me.Columns.Add(_columnTotal)

			_columnFechaOrdenCompra = New DataColumn("FechaOrdenCompra", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaOrdenCompra.ReadOnly = True
			_columnFechaOrdenCompra.Caption = "FechaOrdenCompra"
			Me.Columns.Add(_columnFechaOrdenCompra)

			_columnObservaciones = New DataColumn("Observaciones", GetType(System.String), Nothing, MappingType.Element)
			_columnObservaciones.ReadOnly = True
			_columnObservaciones.Caption = "Observaciones"
			Me.Columns.Add(_columnObservaciones)

			_columnEstatus = New DataColumn("Estatus", GetType(System.Byte), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnAutorizada = New DataColumn("Autorizada", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnAutorizada.ReadOnly = True
			_columnAutorizada.Caption = "Autorizada"
			Me.Columns.Add(_columnAutorizada)

			_columnRecibida = New DataColumn("Recibida", GetType(System.Byte), Nothing, MappingType.Element)
			_columnRecibida.ReadOnly = True
			_columnRecibida.Caption = "Recibida"
			Me.Columns.Add(_columnRecibida)

			_columnEstatusDes = New DataColumn("EstatusDes", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusDes.ReadOnly = True
			_columnEstatusDes.Caption = "EstatusDes"
			Me.Columns.Add(_columnEstatusDes)

			_columnMoneda = New DataColumn("Moneda", GetType(System.Int32), Nothing, MappingType.Element)
			_columnMoneda.ReadOnly = True
			_columnMoneda.Caption = "Moneda"
			Me.Columns.Add(_columnMoneda)

			_columnTipoCambio = New DataColumn("TipoCambio", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTipoCambio.ReadOnly = True
			_columnTipoCambio.Caption = "TipoCambio"
			Me.Columns.Add(_columnTipoCambio)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnIdOrdenCompra = Me.Columns("IdOrdenCompra")
			_columnFolioOrdenCompra = Me.Columns("FolioOrdenCompra")
			_columnPlIdPlaza = Me.Columns("PlIdPlaza")
			_columnPlDescripcion = Me.Columns("PlDescripcion")
			_columnIdSucursal = Me.Columns("IdSucursal")
			_columnSucursal = Me.Columns("Sucursal")
			_columnIdProveedor = Me.Columns("IdProveedor")
			_columnProveedor = Me.Columns("Proveedor")
			_columnImporte = Me.Columns("Importe")
			_columnDescuento = Me.Columns("Descuento")
			_columnSubTotal = Me.Columns("SubTotal")
			_columnIvatotal = Me.Columns("Ivatotal")
			_columnTotal = Me.Columns("Total")
			_columnFechaOrdenCompra = Me.Columns("FechaOrdenCompra")
			_columnObservaciones = Me.Columns("Observaciones")
			_columnEstatus = Me.Columns("Estatus")
			_columnAutorizada = Me.Columns("Autorizada")
			_columnRecibida = Me.Columns("Recibida")
			_columnEstatusDes = Me.Columns("EstatusDes")
			_columnMoneda = Me.Columns("Moneda")
			_columnTipoCambio = Me.Columns("TipoCambio")
			
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

			_fieldsCustomProperties.Add("IdOrdenCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioOrdenCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PlIdPlaza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PlDescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdSucursal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Sucursal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Proveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Ivatotal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaOrdenCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Autorizada", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Recibida", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusDes", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Moneda", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoCambio", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwCompConsultaOrdenCompraRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwCompConsultaOrdenCompraTypedView = CType(MyBase.Clone(), VwCompConsultaOrdenCompraTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwCompConsultaOrdenCompraTypedView()
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
				Return VwCompConsultaOrdenCompraTypedView.CustomProperties
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
				Return VwCompConsultaOrdenCompraTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwCompConsultaOrdenCompraRow
			Get 
				Return CType(Me.Rows(index), VwCompConsultaOrdenCompraRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdOrdenCompra
		''' </summary>
		ReadOnly Friend Property IdOrdenCompraColumn As DataColumn
			Get 
				Return _columnIdOrdenCompra 
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
		''' Returns the column Object belonging to the TypedView field PlIdPlaza
		''' </summary>
		ReadOnly Friend Property PlIdPlazaColumn As DataColumn
			Get 
				Return _columnPlIdPlaza 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PlDescripcion
		''' </summary>
		ReadOnly Friend Property PlDescripcionColumn As DataColumn
			Get 
				Return _columnPlDescripcion 
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
		''' Returns the column Object belonging to the TypedView field Sucursal
		''' </summary>
		ReadOnly Friend Property SucursalColumn As DataColumn
			Get 
				Return _columnSucursal 
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
		''' Returns the column Object belonging to the TypedView field Proveedor
		''' </summary>
		ReadOnly Friend Property ProveedorColumn As DataColumn
			Get 
				Return _columnProveedor 
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
		''' Returns the column Object belonging to the TypedView field Descuento
		''' </summary>
		ReadOnly Friend Property DescuentoColumn As DataColumn
			Get 
				Return _columnDescuento 
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
		''' Returns the column Object belonging to the TypedView field Ivatotal
		''' </summary>
		ReadOnly Friend Property IvatotalColumn As DataColumn
			Get 
				Return _columnIvatotal 
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
		''' Returns the column Object belonging to the TypedView field FechaOrdenCompra
		''' </summary>
		ReadOnly Friend Property FechaOrdenCompraColumn As DataColumn
			Get 
				Return _columnFechaOrdenCompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Observaciones
		''' </summary>
		ReadOnly Friend Property ObservacionesColumn As DataColumn
			Get 
				Return _columnObservaciones 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Estatus
		''' </summary>
		ReadOnly Friend Property EstatusColumn As DataColumn
			Get 
				Return _columnEstatus 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Autorizada
		''' </summary>
		ReadOnly Friend Property AutorizadaColumn As DataColumn
			Get 
				Return _columnAutorizada 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Recibida
		''' </summary>
		ReadOnly Friend Property RecibidaColumn As DataColumn
			Get 
				Return _columnRecibida 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EstatusDes
		''' </summary>
		ReadOnly Friend Property EstatusDesColumn As DataColumn
			Get 
				Return _columnEstatusDes 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Moneda
		''' </summary>
		ReadOnly Friend Property MonedaColumn As DataColumn
			Get 
				Return _columnMoneda 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TipoCambio
		''' </summary>
		ReadOnly Friend Property TipoCambioColumn As DataColumn
			Get 
				Return _columnTipoCambio 
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
	''' Typed datarow for the typed datatable VwCompConsultaOrdenCompra
	''' </summary>
	Public Class VwCompConsultaOrdenCompraRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwCompConsultaOrdenCompraTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwCompConsultaOrdenCompraTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field IdOrdenCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."IdOrdenCompra"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdOrdenCompra]() As System.Int32
			Get 
				If IsIdOrdenCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdOrdenCompraColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdOrdenCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdOrdenCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsIdOrdenCompraNull() As Boolean
			Return IsNull(_parent.IdOrdenCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdOrdenCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdOrdenCompraNull() 
			Me(_parent.IdOrdenCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioOrdenCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."FolioOrdenCompra"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 12
		''' </remarks>
		Public Property [FolioOrdenCompra]() As System.String
			Get 
				If IsFolioOrdenCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioOrdenCompraColumn), System.String)
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
		''' Gets / sets the value of the TypedView field PlIdPlaza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."PlIdPlaza"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PlIdPlaza]() As System.Int32
			Get 
				If IsPlIdPlazaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PlIdPlazaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PlIdPlazaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PlIdPlaza is NULL, False otherwise.
		''' </summary>
		Public Function IsPlIdPlazaNull() As Boolean
			Return IsNull(_parent.PlIdPlazaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PlIdPlaza to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPlIdPlazaNull() 
			Me(_parent.PlIdPlazaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PlDescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."PlDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [PlDescripcion]() As System.String
			Get 
				If IsPlDescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PlDescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PlDescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PlDescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsPlDescripcionNull() As Boolean
			Return IsNull(_parent.PlDescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PlDescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPlDescripcionNull() 
			Me(_parent.PlDescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdSucursal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."IdSucursal"<br/>
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
		''' Gets / sets the value of the TypedView field Sucursal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Sucursal"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [Sucursal]() As System.String
			Get 
				If IsSucursalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.SucursalColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.SucursalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Sucursal is NULL, False otherwise.
		''' </summary>
		Public Function IsSucursalNull() As Boolean
			Return IsNull(_parent.SucursalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Sucursal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSucursalNull() 
			Me(_parent.SucursalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdProveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."IdProveedor"<br/>
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
		''' Gets / sets the value of the TypedView field Proveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Proveedor"<br/>
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
		''' Gets / sets the value of the TypedView field Importe<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Importe"<br/>
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
		''' Gets / sets the value of the TypedView field Descuento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Descuento"<br/>
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
		''' Gets / sets the value of the TypedView field SubTotal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."SubTotal"<br/>
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
		''' Gets / sets the value of the TypedView field Ivatotal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."IVATotal"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [Ivatotal]() As System.Decimal
			Get 
				If IsIvatotalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.IvatotalColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.IvatotalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Ivatotal is NULL, False otherwise.
		''' </summary>
		Public Function IsIvatotalNull() As Boolean
			Return IsNull(_parent.IvatotalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Ivatotal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIvatotalNull() 
			Me(_parent.IvatotalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Total<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Total"<br/>
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
		''' Gets / sets the value of the TypedView field FechaOrdenCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."FechaOrdenCompra"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaOrdenCompra]() As System.DateTime
			Get 
				If IsFechaOrdenCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaOrdenCompraColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaOrdenCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaOrdenCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaOrdenCompraNull() As Boolean
			Return IsNull(_parent.FechaOrdenCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaOrdenCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaOrdenCompraNull() 
			Me(_parent.FechaOrdenCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Observaciones<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Observaciones"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
		''' </remarks>
		Public Property [Observaciones]() As System.String
			Get 
				If IsObservacionesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ObservacionesColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ObservacionesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Observaciones is NULL, False otherwise.
		''' </summary>
		Public Function IsObservacionesNull() As Boolean
			Return IsNull(_parent.ObservacionesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Observaciones to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetObservacionesNull() 
			Me(_parent.ObservacionesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Estatus"<br/>
		''' View field characteristics (type, precision, scale, length): TinyInt, 3, 0, 0
		''' </remarks>
		Public Property [Estatus]() As System.Byte
			Get 
				If IsEstatusNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Byte)), System.Byte)
				Else
					Return CType(Me(_parent.EstatusColumn), System.Byte)
				End If
			End Get
			Set 
				Me(_parent.EstatusColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Estatus is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusNull() As Boolean
			Return IsNull(_parent.EstatusColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Estatus to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusNull() 
			Me(_parent.EstatusColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Autorizada<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Autorizada"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [Autorizada]() As System.Boolean
			Get 
				If IsAutorizadaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.AutorizadaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.AutorizadaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Autorizada is NULL, False otherwise.
		''' </summary>
		Public Function IsAutorizadaNull() As Boolean
			Return IsNull(_parent.AutorizadaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Autorizada to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAutorizadaNull() 
			Me(_parent.AutorizadaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Recibida<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Recibida"<br/>
		''' View field characteristics (type, precision, scale, length): TinyInt, 3, 0, 0
		''' </remarks>
		Public Property [Recibida]() As System.Byte
			Get 
				If IsRecibidaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Byte)), System.Byte)
				Else
					Return CType(Me(_parent.RecibidaColumn), System.Byte)
				End If
			End Get
			Set 
				Me(_parent.RecibidaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Recibida is NULL, False otherwise.
		''' </summary>
		Public Function IsRecibidaNull() As Boolean
			Return IsNull(_parent.RecibidaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Recibida to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetRecibidaNull() 
			Me(_parent.RecibidaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EstatusDes<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."EstatusDes"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 11
		''' </remarks>
		Public Property [EstatusDes]() As System.String
			Get 
				If IsEstatusDesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EstatusDesColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EstatusDesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EstatusDes is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusDesNull() As Boolean
			Return IsNull(_parent.EstatusDesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EstatusDes to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusDesNull() 
			Me(_parent.EstatusDesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Moneda<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."Moneda"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Moneda]() As System.Int32
			Get 
				If IsMonedaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.MonedaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.MonedaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Moneda is NULL, False otherwise.
		''' </summary>
		Public Function IsMonedaNull() As Boolean
			Return IsNull(_parent.MonedaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Moneda to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetMonedaNull() 
			Me(_parent.MonedaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TipoCambio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompConsultaOrdenCompra"."TipoCambio"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [TipoCambio]() As System.Decimal
			Get 
				If IsTipoCambioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TipoCambioColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TipoCambioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoCambio is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoCambioNull() As Boolean
			Return IsNull(_parent.TipoCambioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoCambio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoCambioNull() 
			Me(_parent.TipoCambioColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
