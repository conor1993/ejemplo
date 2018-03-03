' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:45
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
	''' Typed datatable for the view 'VwCxpauxiliarPasivos'.<br/><br/>
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
	Public Class VwCxpauxiliarPasivosTypedView 
#Else
	Public Class VwCxpauxiliarPasivosTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnCta As DataColumn
		Private _columnSubCta As DataColumn
		Private _columnSsubCta As DataColumn
		Private _columnSssubCta As DataColumn
		Private _columnNomCuenta As DataColumn
		Private _columnIdProveedor As DataColumn
		Private _columnPrRazSocial As DataColumn
		Private _columnNoFactura As DataColumn
		Private _columnFechaFactura As DataColumn
		Private _columnFechaVencimiento As DataColumn
		Private _columnImporte As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 11
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
			MyBase.New("VwCxpauxiliarPasivos")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCxpauxiliarPasivosTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCxpauxiliarPasivosTypedView)
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
			Return New VwCxpauxiliarPasivosRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnCta = New DataColumn("Cta", GetType(System.String), Nothing, MappingType.Element)
			_columnCta.ReadOnly = True
			_columnCta.Caption = "Cta"
			Me.Columns.Add(_columnCta)

			_columnSubCta = New DataColumn("SubCta", GetType(System.String), Nothing, MappingType.Element)
			_columnSubCta.ReadOnly = True
			_columnSubCta.Caption = "SubCta"
			Me.Columns.Add(_columnSubCta)

			_columnSsubCta = New DataColumn("SsubCta", GetType(System.String), Nothing, MappingType.Element)
			_columnSsubCta.ReadOnly = True
			_columnSsubCta.Caption = "SsubCta"
			Me.Columns.Add(_columnSsubCta)

			_columnSssubCta = New DataColumn("SssubCta", GetType(System.String), Nothing, MappingType.Element)
			_columnSssubCta.ReadOnly = True
			_columnSssubCta.Caption = "SssubCta"
			Me.Columns.Add(_columnSssubCta)

			_columnNomCuenta = New DataColumn("NomCuenta", GetType(System.String), Nothing, MappingType.Element)
			_columnNomCuenta.ReadOnly = True
			_columnNomCuenta.Caption = "NomCuenta"
			Me.Columns.Add(_columnNomCuenta)

			_columnIdProveedor = New DataColumn("IdProveedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProveedor.ReadOnly = True
			_columnIdProveedor.Caption = "IdProveedor"
			Me.Columns.Add(_columnIdProveedor)

			_columnPrRazSocial = New DataColumn("PrRazSocial", GetType(System.String), Nothing, MappingType.Element)
			_columnPrRazSocial.ReadOnly = True
			_columnPrRazSocial.Caption = "PrRazSocial"
			Me.Columns.Add(_columnPrRazSocial)

			_columnNoFactura = New DataColumn("NoFactura", GetType(System.String), Nothing, MappingType.Element)
			_columnNoFactura.ReadOnly = True
			_columnNoFactura.Caption = "NoFactura"
			Me.Columns.Add(_columnNoFactura)

			_columnFechaFactura = New DataColumn("FechaFactura", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaFactura.ReadOnly = True
			_columnFechaFactura.Caption = "FechaFactura"
			Me.Columns.Add(_columnFechaFactura)

			_columnFechaVencimiento = New DataColumn("FechaVencimiento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaVencimiento.ReadOnly = True
			_columnFechaVencimiento.Caption = "FechaVencimiento"
			Me.Columns.Add(_columnFechaVencimiento)

			_columnImporte = New DataColumn("Importe", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporte.ReadOnly = True
			_columnImporte.Caption = "Importe"
			Me.Columns.Add(_columnImporte)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnCta = Me.Columns("Cta")
			_columnSubCta = Me.Columns("SubCta")
			_columnSsubCta = Me.Columns("SsubCta")
			_columnSssubCta = Me.Columns("SssubCta")
			_columnNomCuenta = Me.Columns("NomCuenta")
			_columnIdProveedor = Me.Columns("IdProveedor")
			_columnPrRazSocial = Me.Columns("PrRazSocial")
			_columnNoFactura = Me.Columns("NoFactura")
			_columnFechaFactura = Me.Columns("FechaFactura")
			_columnFechaVencimiento = Me.Columns("FechaVencimiento")
			_columnImporte = Me.Columns("Importe")
			
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

			_fieldsCustomProperties.Add("Cta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SubCta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SsubCta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SssubCta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NomCuenta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrRazSocial", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NoFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaVencimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwCxpauxiliarPasivosRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwCxpauxiliarPasivosTypedView = CType(MyBase.Clone(), VwCxpauxiliarPasivosTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwCxpauxiliarPasivosTypedView()
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
				Return VwCxpauxiliarPasivosTypedView.CustomProperties
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
				Return VwCxpauxiliarPasivosTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwCxpauxiliarPasivosRow
			Get 
				Return CType(Me.Rows(index), VwCxpauxiliarPasivosRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Cta
		''' </summary>
		ReadOnly Friend Property CtaColumn As DataColumn
			Get 
				Return _columnCta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SubCta
		''' </summary>
		ReadOnly Friend Property SubCtaColumn As DataColumn
			Get 
				Return _columnSubCta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SsubCta
		''' </summary>
		ReadOnly Friend Property SsubCtaColumn As DataColumn
			Get 
				Return _columnSsubCta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SssubCta
		''' </summary>
		ReadOnly Friend Property SssubCtaColumn As DataColumn
			Get 
				Return _columnSssubCta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field NomCuenta
		''' </summary>
		ReadOnly Friend Property NomCuentaColumn As DataColumn
			Get 
				Return _columnNomCuenta 
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
		''' Returns the column Object belonging to the TypedView field PrRazSocial
		''' </summary>
		ReadOnly Friend Property PrRazSocialColumn As DataColumn
			Get 
				Return _columnPrRazSocial 
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
		''' Returns the column Object belonging to the TypedView field FechaFactura
		''' </summary>
		ReadOnly Friend Property FechaFacturaColumn As DataColumn
			Get 
				Return _columnFechaFactura 
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
		''' Returns the column Object belonging to the TypedView field Importe
		''' </summary>
		ReadOnly Friend Property ImporteColumn As DataColumn
			Get 
				Return _columnImporte 
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
	''' Typed datarow for the typed datatable VwCxpauxiliarPasivos
	''' </summary>
	Public Class VwCxpauxiliarPasivosRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwCxpauxiliarPasivosTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwCxpauxiliarPasivosTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field Cta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."Cta"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 4
		''' </remarks>
		Public Property [Cta]() As System.String
			Get 
				If IsCtaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CtaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CtaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Cta is NULL, False otherwise.
		''' </summary>
		Public Function IsCtaNull() As Boolean
			Return IsNull(_parent.CtaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Cta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCtaNull() 
			Me(_parent.CtaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SubCta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."SubCta"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 4
		''' </remarks>
		Public Property [SubCta]() As System.String
			Get 
				If IsSubCtaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.SubCtaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.SubCtaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SubCta is NULL, False otherwise.
		''' </summary>
		Public Function IsSubCtaNull() As Boolean
			Return IsNull(_parent.SubCtaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SubCta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSubCtaNull() 
			Me(_parent.SubCtaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SsubCta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."SSubCta"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 4
		''' </remarks>
		Public Property [SsubCta]() As System.String
			Get 
				If IsSsubCtaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.SsubCtaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.SsubCtaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SsubCta is NULL, False otherwise.
		''' </summary>
		Public Function IsSsubCtaNull() As Boolean
			Return IsNull(_parent.SsubCtaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SsubCta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSsubCtaNull() 
			Me(_parent.SsubCtaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SssubCta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."SSSubCta"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 4
		''' </remarks>
		Public Property [SssubCta]() As System.String
			Get 
				If IsSssubCtaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.SssubCtaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.SssubCtaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SssubCta is NULL, False otherwise.
		''' </summary>
		Public Function IsSssubCtaNull() As Boolean
			Return IsNull(_parent.SssubCtaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SssubCta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSssubCtaNull() 
			Me(_parent.SssubCtaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field NomCuenta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."NomCuenta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [NomCuenta]() As System.String
			Get 
				If IsNomCuentaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NomCuentaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NomCuentaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NomCuenta is NULL, False otherwise.
		''' </summary>
		Public Function IsNomCuentaNull() As Boolean
			Return IsNull(_parent.NomCuentaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NomCuenta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNomCuentaNull() 
			Me(_parent.NomCuentaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdProveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."IdProveedor"<br/>
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
		''' Gets / sets the value of the TypedView field PrRazSocial<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."PrRazSocial"<br/>
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
		''' Gets / sets the value of the TypedView field NoFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."NoFactura"<br/>
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
		''' Gets / sets the value of the TypedView field FechaFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."FechaFactura"<br/>
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
		''' Gets / sets the value of the TypedView field FechaVencimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."FechaVencimiento"<br/>
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
		''' Gets / sets the value of the TypedView field Importe<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCXPAuxiliarPasivos"."Importe"<br/>
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

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
