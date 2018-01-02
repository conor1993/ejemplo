' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: martes, 26 de diciembre de 2017 16:41:39
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
	''' Typed datatable for the view 'VwCompRecepciondeOrdenes'.<br/><br/>
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
	Public Class VwCompRecepciondeOrdenesTypedView 
#Else
	Public Class VwCompRecepciondeOrdenesTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnIdOrdenCompra As DataColumn
		Private _columnIdSucursal As DataColumn
		Private _columnSucursal As DataColumn
		Private _columnIdPlaza As DataColumn
		Private _columnPlaza As DataColumn
		Private _columnIdProveedor As DataColumn
		Private _columnProveedor As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnProveedorId As DataColumn
		Private _columnEstatus2 As DataColumn
		Private _columnFechaRecepcion As DataColumn
		Private _columnFolioOrdenCompra As DataColumn
		Private _columnAlmacenId As DataColumn
		Private _columnNombre As DataColumn
		Private _columnFoliorecepcionordencompra As DataColumn
		Private _columnIdrecepcionordencompra As DataColumn
		Private _columnEsDirecta As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 17
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
			MyBase.New("VwCompRecepciondeOrdenes")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCompRecepciondeOrdenesTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCompRecepciondeOrdenesTypedView)
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
			Return New VwCompRecepciondeOrdenesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnIdOrdenCompra = New DataColumn("IdOrdenCompra", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdOrdenCompra.ReadOnly = True
			_columnIdOrdenCompra.Caption = "IdOrdenCompra"
			Me.Columns.Add(_columnIdOrdenCompra)

			_columnIdSucursal = New DataColumn("IdSucursal", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdSucursal.ReadOnly = True
			_columnIdSucursal.Caption = "IdSucursal"
			Me.Columns.Add(_columnIdSucursal)

			_columnSucursal = New DataColumn("Sucursal", GetType(System.String), Nothing, MappingType.Element)
			_columnSucursal.ReadOnly = True
			_columnSucursal.Caption = "Sucursal"
			Me.Columns.Add(_columnSucursal)

			_columnIdPlaza = New DataColumn("IdPlaza", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdPlaza.ReadOnly = True
			_columnIdPlaza.Caption = "IdPlaza"
			Me.Columns.Add(_columnIdPlaza)

			_columnPlaza = New DataColumn("Plaza", GetType(System.String), Nothing, MappingType.Element)
			_columnPlaza.ReadOnly = True
			_columnPlaza.Caption = "Plaza"
			Me.Columns.Add(_columnPlaza)

			_columnIdProveedor = New DataColumn("IdProveedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProveedor.ReadOnly = True
			_columnIdProveedor.Caption = "IdProveedor"
			Me.Columns.Add(_columnIdProveedor)

			_columnProveedor = New DataColumn("Proveedor", GetType(System.String), Nothing, MappingType.Element)
			_columnProveedor.ReadOnly = True
			_columnProveedor.Caption = "Proveedor"
			Me.Columns.Add(_columnProveedor)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnProveedorId = New DataColumn("ProveedorId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnProveedorId.ReadOnly = True
			_columnProveedorId.Caption = "ProveedorId"
			Me.Columns.Add(_columnProveedorId)

			_columnEstatus2 = New DataColumn("Estatus2", GetType(System.Byte), Nothing, MappingType.Element)
			_columnEstatus2.ReadOnly = True
			_columnEstatus2.Caption = "Estatus2"
			Me.Columns.Add(_columnEstatus2)

			_columnFechaRecepcion = New DataColumn("FechaRecepcion", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaRecepcion.ReadOnly = True
			_columnFechaRecepcion.Caption = "FechaRecepcion"
			Me.Columns.Add(_columnFechaRecepcion)

			_columnFolioOrdenCompra = New DataColumn("FolioOrdenCompra", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioOrdenCompra.ReadOnly = True
			_columnFolioOrdenCompra.Caption = "FolioOrdenCompra"
			Me.Columns.Add(_columnFolioOrdenCompra)

			_columnAlmacenId = New DataColumn("AlmacenId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnAlmacenId.ReadOnly = True
			_columnAlmacenId.Caption = "AlmacenId"
			Me.Columns.Add(_columnAlmacenId)

			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnFoliorecepcionordencompra = New DataColumn("Foliorecepcionordencompra", GetType(System.String), Nothing, MappingType.Element)
			_columnFoliorecepcionordencompra.ReadOnly = True
			_columnFoliorecepcionordencompra.Caption = "Foliorecepcionordencompra"
			Me.Columns.Add(_columnFoliorecepcionordencompra)

			_columnIdrecepcionordencompra = New DataColumn("Idrecepcionordencompra", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdrecepcionordencompra.ReadOnly = True
			_columnIdrecepcionordencompra.Caption = "Idrecepcionordencompra"
			Me.Columns.Add(_columnIdrecepcionordencompra)

			_columnEsDirecta = New DataColumn("EsDirecta", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnEsDirecta.ReadOnly = True
			_columnEsDirecta.Caption = "EsDirecta"
			Me.Columns.Add(_columnEsDirecta)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnIdOrdenCompra = Me.Columns("IdOrdenCompra")
			_columnIdSucursal = Me.Columns("IdSucursal")
			_columnSucursal = Me.Columns("Sucursal")
			_columnIdPlaza = Me.Columns("IdPlaza")
			_columnPlaza = Me.Columns("Plaza")
			_columnIdProveedor = Me.Columns("IdProveedor")
			_columnProveedor = Me.Columns("Proveedor")
			_columnEstatus = Me.Columns("Estatus")
			_columnProveedorId = Me.Columns("ProveedorId")
			_columnEstatus2 = Me.Columns("Estatus2")
			_columnFechaRecepcion = Me.Columns("FechaRecepcion")
			_columnFolioOrdenCompra = Me.Columns("FolioOrdenCompra")
			_columnAlmacenId = Me.Columns("AlmacenId")
			_columnNombre = Me.Columns("Nombre")
			_columnFoliorecepcionordencompra = Me.Columns("Foliorecepcionordencompra")
			_columnIdrecepcionordencompra = Me.Columns("Idrecepcionordencompra")
			_columnEsDirecta = Me.Columns("EsDirecta")
			
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

			_fieldsCustomProperties.Add("IdSucursal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Sucursal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdPlaza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Plaza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Proveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ProveedorId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus2", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaRecepcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioOrdenCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("AlmacenId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Foliorecepcionordencompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Idrecepcionordencompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EsDirecta", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwCompRecepciondeOrdenesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwCompRecepciondeOrdenesTypedView = CType(MyBase.Clone(), VwCompRecepciondeOrdenesTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwCompRecepciondeOrdenesTypedView()
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
				Return VwCompRecepciondeOrdenesTypedView.CustomProperties
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
				Return VwCompRecepciondeOrdenesTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwCompRecepciondeOrdenesRow
			Get 
				Return CType(Me.Rows(index), VwCompRecepciondeOrdenesRow)
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
		''' Returns the column Object belonging to the TypedView field IdPlaza
		''' </summary>
		ReadOnly Friend Property IdPlazaColumn As DataColumn
			Get 
				Return _columnIdPlaza 
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
		''' Returns the column Object belonging to the TypedView field Estatus
		''' </summary>
		ReadOnly Friend Property EstatusColumn As DataColumn
			Get 
				Return _columnEstatus 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ProveedorId
		''' </summary>
		ReadOnly Friend Property ProveedorIdColumn As DataColumn
			Get 
				Return _columnProveedorId 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Estatus2
		''' </summary>
		ReadOnly Friend Property Estatus2Column As DataColumn
			Get 
				Return _columnEstatus2 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaRecepcion
		''' </summary>
		ReadOnly Friend Property FechaRecepcionColumn As DataColumn
			Get 
				Return _columnFechaRecepcion 
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
		''' Returns the column Object belonging to the TypedView field AlmacenId
		''' </summary>
		ReadOnly Friend Property AlmacenIdColumn As DataColumn
			Get 
				Return _columnAlmacenId 
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
		''' Returns the column Object belonging to the TypedView field Foliorecepcionordencompra
		''' </summary>
		ReadOnly Friend Property FoliorecepcionordencompraColumn As DataColumn
			Get 
				Return _columnFoliorecepcionordencompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Idrecepcionordencompra
		''' </summary>
		ReadOnly Friend Property IdrecepcionordencompraColumn As DataColumn
			Get 
				Return _columnIdrecepcionordencompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EsDirecta
		''' </summary>
		ReadOnly Friend Property EsDirectaColumn As DataColumn
			Get 
				Return _columnEsDirecta 
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
	''' Typed datarow for the typed datatable VwCompRecepciondeOrdenes
	''' </summary>
	Public Class VwCompRecepciondeOrdenesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwCompRecepciondeOrdenesTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwCompRecepciondeOrdenesTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field IdOrdenCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."IdOrdenCompra"<br/>
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
		''' Gets / sets the value of the TypedView field IdSucursal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."IdSucursal"<br/>
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
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."Sucursal"<br/>
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
		''' Gets / sets the value of the TypedView field IdPlaza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."IdPlaza"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdPlaza]() As System.Int32
			Get 
				If IsIdPlazaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdPlazaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdPlazaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdPlaza is NULL, False otherwise.
		''' </summary>
		Public Function IsIdPlazaNull() As Boolean
			Return IsNull(_parent.IdPlazaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdPlaza to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdPlazaNull() 
			Me(_parent.IdPlazaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Plaza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."Plaza"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [Plaza]() As System.String
			Get 
				If IsPlazaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PlazaColumn), System.String)
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
		''' Gets / sets the value of the TypedView field IdProveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."IdProveedor"<br/>
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
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."Proveedor"<br/>
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
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."Estatus"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 10
		''' </remarks>
		Public Property [Estatus]() As System.String
			Get 
				If IsEstatusNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EstatusColumn), System.String)
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
		''' Gets / sets the value of the TypedView field ProveedorId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."ProveedorId"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [ProveedorId]() As System.Int32
			Get 
				If IsProveedorIdNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.ProveedorIdColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.ProveedorIdColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ProveedorId is NULL, False otherwise.
		''' </summary>
		Public Function IsProveedorIdNull() As Boolean
			Return IsNull(_parent.ProveedorIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ProveedorId to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetProveedorIdNull() 
			Me(_parent.ProveedorIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus2<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."Estatus2"<br/>
		''' View field characteristics (type, precision, scale, length): TinyInt, 3, 0, 0
		''' </remarks>
		Public Property [Estatus2]() As System.Byte
			Get 
				If IsEstatus2Null() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Byte)), System.Byte)
				Else
					Return CType(Me(_parent.Estatus2Column), System.Byte)
				End If
			End Get
			Set 
				Me(_parent.Estatus2Column) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Estatus2 is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatus2Null() As Boolean
			Return IsNull(_parent.Estatus2Column)
		End Function

		''' <summary>
		''' Sets the TypedView field Estatus2 to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatus2Null() 
			Me(_parent.Estatus2Column) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaRecepcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."FechaRecepcion"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaRecepcion]() As System.DateTime
			Get 
				If IsFechaRecepcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaRecepcionColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaRecepcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaRecepcion is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaRecepcionNull() As Boolean
			Return IsNull(_parent.FechaRecepcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaRecepcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaRecepcionNull() 
			Me(_parent.FechaRecepcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioOrdenCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."FolioOrdenCompra"<br/>
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
		''' Gets / sets the value of the TypedView field AlmacenId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."IdAlmacen"<br/>
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
		''' Gets / sets the value of the TypedView field Nombre<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."Nombre"<br/>
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
		''' Gets / sets the value of the TypedView field Foliorecepcionordencompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."foliorecepcionordencompra"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 11
		''' </remarks>
		Public Property [Foliorecepcionordencompra]() As System.String
			Get 
				If IsFoliorecepcionordencompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FoliorecepcionordencompraColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FoliorecepcionordencompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Foliorecepcionordencompra is NULL, False otherwise.
		''' </summary>
		Public Function IsFoliorecepcionordencompraNull() As Boolean
			Return IsNull(_parent.FoliorecepcionordencompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Foliorecepcionordencompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFoliorecepcionordencompraNull() 
			Me(_parent.FoliorecepcionordencompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Idrecepcionordencompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."idrecepcionordencompra"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Idrecepcionordencompra]() As System.Int32
			Get 
				If IsIdrecepcionordencompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdrecepcionordencompraColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdrecepcionordencompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Idrecepcionordencompra is NULL, False otherwise.
		''' </summary>
		Public Function IsIdrecepcionordencompraNull() As Boolean
			Return IsNull(_parent.IdrecepcionordencompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Idrecepcionordencompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdrecepcionordencompraNull() 
			Me(_parent.IdrecepcionordencompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EsDirecta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompRecepciondeOrdenes"."EsDirecta"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [EsDirecta]() As System.Boolean
			Get 
				If IsEsDirectaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.EsDirectaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.EsDirectaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EsDirecta is NULL, False otherwise.
		''' </summary>
		Public Function IsEsDirectaNull() As Boolean
			Return IsNull(_parent.EsDirectaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EsDirecta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEsDirectaNull() 
			Me(_parent.EsDirectaColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
