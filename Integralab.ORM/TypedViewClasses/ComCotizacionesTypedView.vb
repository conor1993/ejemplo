' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:33
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
	''' Typed datatable for the view 'ComCotizaciones'.<br/><br/>
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
	Public Class ComCotizacionesTypedView 
#Else
	Public Class ComCotizacionesTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioCotizacion As DataColumn
		Private _columnIdCotizacion As DataColumn
		Private _columnIdSucursal As DataColumn
		Private _columnIdProveedor As DataColumn
		Private _columnIdProducto As DataColumn
		Private _columnCantidad As DataColumn
		Private _columnPrecio As DataColumn
		Private _columnDescuento As DataColumn
		Private _columnImporte As DataColumn
		Private _columnScdescripcion As DataColumn
		Private _columnPldescripcion As DataColumn
		Private _columnPrRazSocial As DataColumn
		Private _columnPdDescripcion As DataColumn
		Private _columnIdMoneda As DataColumn
		Private _columnTmdescripcion As DataColumn
		Private _columnPlidPlaza As DataColumn
		Private _columnFechaCaptura As DataColumn
		Private _columnUmidUnidadMedida As DataColumn
		Private _columnUmdescripcion As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 19
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
			MyBase.New("ComCotizaciones")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.ComCotizacionesTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.ComCotizacionesTypedView)
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
			Return New ComCotizacionesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolioCotizacion = New DataColumn("FolioCotizacion", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioCotizacion.ReadOnly = True
			_columnFolioCotizacion.Caption = "FolioCotizacion"
			Me.Columns.Add(_columnFolioCotizacion)

			_columnIdCotizacion = New DataColumn("IdCotizacion", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCotizacion.ReadOnly = True
			_columnIdCotizacion.Caption = "IdCotizacion"
			Me.Columns.Add(_columnIdCotizacion)

			_columnIdSucursal = New DataColumn("IdSucursal", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdSucursal.ReadOnly = True
			_columnIdSucursal.Caption = "IdSucursal"
			Me.Columns.Add(_columnIdSucursal)

			_columnIdProveedor = New DataColumn("IdProveedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProveedor.ReadOnly = True
			_columnIdProveedor.Caption = "IdProveedor"
			Me.Columns.Add(_columnIdProveedor)

			_columnIdProducto = New DataColumn("IdProducto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProducto.ReadOnly = True
			_columnIdProducto.Caption = "IdProducto"
			Me.Columns.Add(_columnIdProducto)

			_columnCantidad = New DataColumn("Cantidad", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidad.ReadOnly = True
			_columnCantidad.Caption = "Cantidad"
			Me.Columns.Add(_columnCantidad)

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

			_columnScdescripcion = New DataColumn("Scdescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnScdescripcion.ReadOnly = True
			_columnScdescripcion.Caption = "Scdescripcion"
			Me.Columns.Add(_columnScdescripcion)

			_columnPldescripcion = New DataColumn("Pldescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnPldescripcion.ReadOnly = True
			_columnPldescripcion.Caption = "Pldescripcion"
			Me.Columns.Add(_columnPldescripcion)

			_columnPrRazSocial = New DataColumn("PrRazSocial", GetType(System.String), Nothing, MappingType.Element)
			_columnPrRazSocial.ReadOnly = True
			_columnPrRazSocial.Caption = "PrRazSocial"
			Me.Columns.Add(_columnPrRazSocial)

			_columnPdDescripcion = New DataColumn("PdDescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnPdDescripcion.ReadOnly = True
			_columnPdDescripcion.Caption = "PdDescripcion"
			Me.Columns.Add(_columnPdDescripcion)

			_columnIdMoneda = New DataColumn("IdMoneda", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdMoneda.ReadOnly = True
			_columnIdMoneda.Caption = "IdMoneda"
			Me.Columns.Add(_columnIdMoneda)

			_columnTmdescripcion = New DataColumn("Tmdescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnTmdescripcion.ReadOnly = True
			_columnTmdescripcion.Caption = "Tmdescripcion"
			Me.Columns.Add(_columnTmdescripcion)

			_columnPlidPlaza = New DataColumn("PlidPlaza", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPlidPlaza.ReadOnly = True
			_columnPlidPlaza.Caption = "PlidPlaza"
			Me.Columns.Add(_columnPlidPlaza)

			_columnFechaCaptura = New DataColumn("FechaCaptura", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCaptura.ReadOnly = True
			_columnFechaCaptura.Caption = "FechaCaptura"
			Me.Columns.Add(_columnFechaCaptura)

			_columnUmidUnidadMedida = New DataColumn("UmidUnidadMedida", GetType(System.Int32), Nothing, MappingType.Element)
			_columnUmidUnidadMedida.ReadOnly = True
			_columnUmidUnidadMedida.Caption = "UmidUnidadMedida"
			Me.Columns.Add(_columnUmidUnidadMedida)

			_columnUmdescripcion = New DataColumn("Umdescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnUmdescripcion.ReadOnly = True
			_columnUmdescripcion.Caption = "Umdescripcion"
			Me.Columns.Add(_columnUmdescripcion)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolioCotizacion = Me.Columns("FolioCotizacion")
			_columnIdCotizacion = Me.Columns("IdCotizacion")
			_columnIdSucursal = Me.Columns("IdSucursal")
			_columnIdProveedor = Me.Columns("IdProveedor")
			_columnIdProducto = Me.Columns("IdProducto")
			_columnCantidad = Me.Columns("Cantidad")
			_columnPrecio = Me.Columns("Precio")
			_columnDescuento = Me.Columns("Descuento")
			_columnImporte = Me.Columns("Importe")
			_columnScdescripcion = Me.Columns("Scdescripcion")
			_columnPldescripcion = Me.Columns("Pldescripcion")
			_columnPrRazSocial = Me.Columns("PrRazSocial")
			_columnPdDescripcion = Me.Columns("PdDescripcion")
			_columnIdMoneda = Me.Columns("IdMoneda")
			_columnTmdescripcion = Me.Columns("Tmdescripcion")
			_columnPlidPlaza = Me.Columns("PlidPlaza")
			_columnFechaCaptura = Me.Columns("FechaCaptura")
			_columnUmidUnidadMedida = Me.Columns("UmidUnidadMedida")
			_columnUmdescripcion = Me.Columns("Umdescripcion")
			
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

			_fieldsCustomProperties.Add("FolioCotizacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCotizacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdSucursal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Precio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Scdescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Pldescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrRazSocial", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdDescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdMoneda", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Tmdescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PlidPlaza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("UmidUnidadMedida", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Umdescripcion", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(ComCotizacionesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As ComCotizacionesTypedView = CType(MyBase.Clone(), ComCotizacionesTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New ComCotizacionesTypedView()
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
				Return ComCotizacionesTypedView.CustomProperties
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
				Return ComCotizacionesTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As ComCotizacionesRow
			Get 
				Return CType(Me.Rows(index), ComCotizacionesRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioCotizacion
		''' </summary>
		ReadOnly Friend Property FolioCotizacionColumn As DataColumn
			Get 
				Return _columnFolioCotizacion 
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
		''' Returns the column Object belonging to the TypedView field IdSucursal
		''' </summary>
		ReadOnly Friend Property IdSucursalColumn As DataColumn
			Get 
				Return _columnIdSucursal 
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
		''' Returns the column Object belonging to the TypedView field IdProducto
		''' </summary>
		ReadOnly Friend Property IdProductoColumn As DataColumn
			Get 
				Return _columnIdProducto 
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
		''' Returns the column Object belonging to the TypedView field Scdescripcion
		''' </summary>
		ReadOnly Friend Property ScdescripcionColumn As DataColumn
			Get 
				Return _columnScdescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Pldescripcion
		''' </summary>
		ReadOnly Friend Property PldescripcionColumn As DataColumn
			Get 
				Return _columnPldescripcion 
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
		''' Returns the column Object belonging to the TypedView field PdDescripcion
		''' </summary>
		ReadOnly Friend Property PdDescripcionColumn As DataColumn
			Get 
				Return _columnPdDescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdMoneda
		''' </summary>
		ReadOnly Friend Property IdMonedaColumn As DataColumn
			Get 
				Return _columnIdMoneda 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Tmdescripcion
		''' </summary>
		ReadOnly Friend Property TmdescripcionColumn As DataColumn
			Get 
				Return _columnTmdescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PlidPlaza
		''' </summary>
		ReadOnly Friend Property PlidPlazaColumn As DataColumn
			Get 
				Return _columnPlidPlaza 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaCaptura
		''' </summary>
		ReadOnly Friend Property FechaCapturaColumn As DataColumn
			Get 
				Return _columnFechaCaptura 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field UmidUnidadMedida
		''' </summary>
		ReadOnly Friend Property UmidUnidadMedidaColumn As DataColumn
			Get 
				Return _columnUmidUnidadMedida 
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
	''' Typed datarow for the typed datatable ComCotizaciones
	''' </summary>
	Public Class ComCotizacionesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As ComCotizacionesTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, ComCotizacionesTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolioCotizacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."FolioCotizacion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 11
		''' </remarks>
		Public Property [FolioCotizacion]() As System.String
			Get 
				If IsFolioCotizacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioCotizacionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioCotizacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioCotizacion is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioCotizacionNull() As Boolean
			Return IsNull(_parent.FolioCotizacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioCotizacion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioCotizacionNull() 
			Me(_parent.FolioCotizacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCotizacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."IdCotizacion"<br/>
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
		''' Gets / sets the value of the TypedView field IdSucursal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."IdSucursal"<br/>
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
		''' Gets / sets the value of the TypedView field IdProveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."IdProveedor"<br/>
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
		''' Gets / sets the value of the TypedView field IdProducto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."IdProducto"<br/>
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
		''' Gets / sets the value of the TypedView field Cantidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."Cantidad"<br/>
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
		''' Gets / sets the value of the TypedView field Precio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."Precio"<br/>
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
		''' Mapped on view field: "ComCotizaciones"."Descuento"<br/>
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
		''' Mapped on view field: "ComCotizaciones"."Importe"<br/>
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
		''' Gets / sets the value of the TypedView field Scdescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."SCDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [Scdescripcion]() As System.String
			Get 
				If IsScdescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ScdescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ScdescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Scdescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsScdescripcionNull() As Boolean
			Return IsNull(_parent.ScdescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Scdescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetScdescripcionNull() 
			Me(_parent.ScdescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Pldescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."PLDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [Pldescripcion]() As System.String
			Get 
				If IsPldescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PldescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PldescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Pldescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsPldescripcionNull() As Boolean
			Return IsNull(_parent.PldescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Pldescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPldescripcionNull() 
			Me(_parent.PldescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrRazSocial<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."PrRazSocial"<br/>
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
		''' Gets / sets the value of the TypedView field PdDescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."PdDescripcion"<br/>
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
		''' Gets / sets the value of the TypedView field IdMoneda<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."IdMoneda"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdMoneda]() As System.Int32
			Get 
				If IsIdMonedaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdMonedaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdMonedaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdMoneda is NULL, False otherwise.
		''' </summary>
		Public Function IsIdMonedaNull() As Boolean
			Return IsNull(_parent.IdMonedaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdMoneda to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdMonedaNull() 
			Me(_parent.IdMonedaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Tmdescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."TMDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [Tmdescripcion]() As System.String
			Get 
				If IsTmdescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TmdescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TmdescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Tmdescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsTmdescripcionNull() As Boolean
			Return IsNull(_parent.TmdescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Tmdescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTmdescripcionNull() 
			Me(_parent.TmdescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PlidPlaza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."PLIdPlaza"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PlidPlaza]() As System.Int32
			Get 
				If IsPlidPlazaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PlidPlazaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PlidPlazaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PlidPlaza is NULL, False otherwise.
		''' </summary>
		Public Function IsPlidPlazaNull() As Boolean
			Return IsNull(_parent.PlidPlazaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PlidPlaza to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPlidPlazaNull() 
			Me(_parent.PlidPlazaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaCaptura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."FechaCaptura"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaCaptura]() As System.DateTime
			Get 
				If IsFechaCapturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaCapturaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaCapturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaCaptura is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaCapturaNull() As Boolean
			Return IsNull(_parent.FechaCapturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaCaptura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaCapturaNull() 
			Me(_parent.FechaCapturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field UmidUnidadMedida<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."UMIdUnidadMedida"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [UmidUnidadMedida]() As System.Int32
			Get 
				If IsUmidUnidadMedidaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.UmidUnidadMedidaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.UmidUnidadMedidaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field UmidUnidadMedida is NULL, False otherwise.
		''' </summary>
		Public Function IsUmidUnidadMedidaNull() As Boolean
			Return IsNull(_parent.UmidUnidadMedidaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field UmidUnidadMedida to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetUmidUnidadMedidaNull() 
			Me(_parent.UmidUnidadMedidaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Umdescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "ComCotizaciones"."UMDescripcion"<br/>
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

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
