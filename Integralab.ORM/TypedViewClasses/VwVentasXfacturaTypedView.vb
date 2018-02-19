' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 17:53:01
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
	''' Typed datatable for the view 'VwVentasXfactura'.<br/><br/>
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
	Public Class VwVentasXfacturaTypedView 
#Else
	Public Class VwVentasXfacturaTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFactura As DataColumn
		Private _columnFecha As DataColumn
		Private _columnCliente As DataColumn
		Private _columnTipoFactura As DataColumn
		Private _columnSubTotal As DataColumn
		Private _columnIva As DataColumn
		Private _columnTotal As DataColumn
		Private _columnEmbarque As DataColumn
		Private _columnDescuento As DataColumn
		Private _columnSta As DataColumn
		Private _columnContado As DataColumn
		Private _columnIdCliente As DataColumn
		Private _columnVendedor As DataColumn
		Private _columnIdVendedor As DataColumn
		
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
			MyBase.New("VwVentasXfactura")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwVentasXfacturaTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwVentasXfacturaTypedView)
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
			Return New VwVentasXfacturaRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFactura = New DataColumn("Factura", GetType(System.String), Nothing, MappingType.Element)
			_columnFactura.ReadOnly = True
			_columnFactura.Caption = "Factura"
			Me.Columns.Add(_columnFactura)

			_columnFecha = New DataColumn("Fecha", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFecha.ReadOnly = True
			_columnFecha.Caption = "Fecha"
			Me.Columns.Add(_columnFecha)

			_columnCliente = New DataColumn("Cliente", GetType(System.String), Nothing, MappingType.Element)
			_columnCliente.ReadOnly = True
			_columnCliente.Caption = "Cliente"
			Me.Columns.Add(_columnCliente)

			_columnTipoFactura = New DataColumn("TipoFactura", GetType(System.String), Nothing, MappingType.Element)
			_columnTipoFactura.ReadOnly = True
			_columnTipoFactura.Caption = "TipoFactura"
			Me.Columns.Add(_columnTipoFactura)

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

			_columnEmbarque = New DataColumn("Embarque", GetType(System.String), Nothing, MappingType.Element)
			_columnEmbarque.ReadOnly = True
			_columnEmbarque.Caption = "Embarque"
			Me.Columns.Add(_columnEmbarque)

			_columnDescuento = New DataColumn("Descuento", GetType(System.Int32), Nothing, MappingType.Element)
			_columnDescuento.ReadOnly = True
			_columnDescuento.Caption = "Descuento"
			Me.Columns.Add(_columnDescuento)

			_columnSta = New DataColumn("Sta", GetType(System.String), Nothing, MappingType.Element)
			_columnSta.ReadOnly = True
			_columnSta.Caption = "Sta"
			Me.Columns.Add(_columnSta)

			_columnContado = New DataColumn("Contado", GetType(System.String), Nothing, MappingType.Element)
			_columnContado.ReadOnly = True
			_columnContado.Caption = "Contado"
			Me.Columns.Add(_columnContado)

			_columnIdCliente = New DataColumn("IdCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCliente.ReadOnly = True
			_columnIdCliente.Caption = "IdCliente"
			Me.Columns.Add(_columnIdCliente)

			_columnVendedor = New DataColumn("Vendedor", GetType(System.String), Nothing, MappingType.Element)
			_columnVendedor.ReadOnly = True
			_columnVendedor.Caption = "Vendedor"
			Me.Columns.Add(_columnVendedor)

			_columnIdVendedor = New DataColumn("IdVendedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdVendedor.ReadOnly = True
			_columnIdVendedor.Caption = "IdVendedor"
			Me.Columns.Add(_columnIdVendedor)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFactura = Me.Columns("Factura")
			_columnFecha = Me.Columns("Fecha")
			_columnCliente = Me.Columns("Cliente")
			_columnTipoFactura = Me.Columns("TipoFactura")
			_columnSubTotal = Me.Columns("SubTotal")
			_columnIva = Me.Columns("Iva")
			_columnTotal = Me.Columns("Total")
			_columnEmbarque = Me.Columns("Embarque")
			_columnDescuento = Me.Columns("Descuento")
			_columnSta = Me.Columns("Sta")
			_columnContado = Me.Columns("Contado")
			_columnIdCliente = Me.Columns("IdCliente")
			_columnVendedor = Me.Columns("Vendedor")
			_columnIdVendedor = Me.Columns("IdVendedor")
			
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

			_fieldsCustomProperties.Add("Factura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Fecha", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Embarque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Sta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Contado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Vendedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdVendedor", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwVentasXfacturaRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwVentasXfacturaTypedView = CType(MyBase.Clone(), VwVentasXfacturaTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwVentasXfacturaTypedView()
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
				Return VwVentasXfacturaTypedView.CustomProperties
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
				Return VwVentasXfacturaTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwVentasXfacturaRow
			Get 
				Return CType(Me.Rows(index), VwVentasXfacturaRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Factura
		''' </summary>
		ReadOnly Friend Property FacturaColumn As DataColumn
			Get 
				Return _columnFactura 
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
		''' Returns the column Object belonging to the TypedView field Cliente
		''' </summary>
		ReadOnly Friend Property ClienteColumn As DataColumn
			Get 
				Return _columnCliente 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TipoFactura
		''' </summary>
		ReadOnly Friend Property TipoFacturaColumn As DataColumn
			Get 
				Return _columnTipoFactura 
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
		''' Returns the column Object belonging to the TypedView field Embarque
		''' </summary>
		ReadOnly Friend Property EmbarqueColumn As DataColumn
			Get 
				Return _columnEmbarque 
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
		''' Returns the column Object belonging to the TypedView field Sta
		''' </summary>
		ReadOnly Friend Property StaColumn As DataColumn
			Get 
				Return _columnSta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Contado
		''' </summary>
		ReadOnly Friend Property ContadoColumn As DataColumn
			Get 
				Return _columnContado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdCliente
		''' </summary>
		ReadOnly Friend Property IdClienteColumn As DataColumn
			Get 
				Return _columnIdCliente 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Vendedor
		''' </summary>
		ReadOnly Friend Property VendedorColumn As DataColumn
			Get 
				Return _columnVendedor 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdVendedor
		''' </summary>
		ReadOnly Friend Property IdVendedorColumn As DataColumn
			Get 
				Return _columnIdVendedor 
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
	''' Typed datarow for the typed datatable VwVentasXfactura
	''' </summary>
	Public Class VwVentasXfacturaRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwVentasXfacturaTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwVentasXfacturaTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field Factura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."Factura"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 20
		''' </remarks>
		Public Property [Factura]() As System.String
			Get 
				If IsFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FacturaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Factura is NULL, False otherwise.
		''' </summary>
		Public Function IsFacturaNull() As Boolean
			Return IsNull(_parent.FacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Factura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFacturaNull() 
			Me(_parent.FacturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Fecha<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."Fecha"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [Fecha]() As System.DateTime
			Get 
				If IsFechaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaColumn), System.DateTime)
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
		''' Gets / sets the value of the TypedView field Cliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."Cliente"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 120
		''' </remarks>
		Public Property [Cliente]() As System.String
			Get 
				If IsClienteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ClienteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ClienteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Cliente is NULL, False otherwise.
		''' </summary>
		Public Function IsClienteNull() As Boolean
			Return IsNull(_parent.ClienteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Cliente to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetClienteNull() 
			Me(_parent.ClienteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TipoFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."TipoFactura"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 15
		''' </remarks>
		Public Property [TipoFactura]() As System.String
			Get 
				If IsTipoFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TipoFacturaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TipoFacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoFactura is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoFacturaNull() As Boolean
			Return IsNull(_parent.TipoFacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoFactura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoFacturaNull() 
			Me(_parent.TipoFacturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SubTotal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."SubTotal"<br/>
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
		''' Mapped on view field: "VwVentasXFactura"."IVA"<br/>
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
		''' Mapped on view field: "VwVentasXFactura"."Total"<br/>
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
		''' Gets / sets the value of the TypedView field Embarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."Embarque"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [Embarque]() As System.String
			Get 
				If IsEmbarqueNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EmbarqueColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EmbarqueColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Embarque is NULL, False otherwise.
		''' </summary>
		Public Function IsEmbarqueNull() As Boolean
			Return IsNull(_parent.EmbarqueColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Embarque to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEmbarqueNull() 
			Me(_parent.EmbarqueColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Descuento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."Descuento"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Descuento]() As System.Int32
			Get 
				If IsDescuentoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.DescuentoColumn), System.Int32)
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
		''' Gets / sets the value of the TypedView field Sta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."Sta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 15
		''' </remarks>
		Public Property [Sta]() As System.String
			Get 
				If IsStaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.StaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.StaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Sta is NULL, False otherwise.
		''' </summary>
		Public Function IsStaNull() As Boolean
			Return IsNull(_parent.StaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Sta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetStaNull() 
			Me(_parent.StaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Contado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."Contado"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 7
		''' </remarks>
		Public Property [Contado]() As System.String
			Get 
				If IsContadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ContadoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ContadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Contado is NULL, False otherwise.
		''' </summary>
		Public Function IsContadoNull() As Boolean
			Return IsNull(_parent.ContadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Contado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetContadoNull() 
			Me(_parent.ContadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."IdCliente"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdCliente]() As System.Int32
			Get 
				If IsIdClienteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdClienteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdClienteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdCliente is NULL, False otherwise.
		''' </summary>
		Public Function IsIdClienteNull() As Boolean
			Return IsNull(_parent.IdClienteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdCliente to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdClienteNull() 
			Me(_parent.IdClienteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Vendedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."Vendedor"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 152
		''' </remarks>
		Public Property [Vendedor]() As System.String
			Get 
				If IsVendedorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.VendedorColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.VendedorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Vendedor is NULL, False otherwise.
		''' </summary>
		Public Function IsVendedorNull() As Boolean
			Return IsNull(_parent.VendedorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Vendedor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetVendedorNull() 
			Me(_parent.VendedorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdVendedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwVentasXFactura"."IdVendedor"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdVendedor]() As System.Int32
			Get 
				If IsIdVendedorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdVendedorColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdVendedorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdVendedor is NULL, False otherwise.
		''' </summary>
		Public Function IsIdVendedorNull() As Boolean
			Return IsNull(_parent.IdVendedorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdVendedor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdVendedorNull() 
			Me(_parent.IdVendedorColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
