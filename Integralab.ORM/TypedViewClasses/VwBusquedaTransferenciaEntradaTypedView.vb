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
	''' Typed datatable for the view 'VwBusquedaTransferenciaEntrada'.<br/><br/>
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
	Public Class VwBusquedaTransferenciaEntradaTypedView 
#Else
	Public Class VwBusquedaTransferenciaEntradaTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioTransferenciaEntrada As DataColumn
		Private _columnIdAlmacenDestino As DataColumn
		Private _columnAlmacenDestino As DataColumn
		Private _columnFechaMovimiento As DataColumn
		Private _columnTotalProductos As DataColumn
		Private _columnImporte As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnIdAlmacenOrigen As DataColumn
		Private _columnAlmacenOrigen As DataColumn
		Private _columnFolioTransferenciaSalida As DataColumn
		Private _columnEstatusStr As DataColumn
		
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
			MyBase.New("VwBusquedaTransferenciaEntrada")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaTransferenciaEntradaTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaTransferenciaEntradaTypedView)
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
			Return New VwBusquedaTransferenciaEntradaRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolioTransferenciaEntrada = New DataColumn("FolioTransferenciaEntrada", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioTransferenciaEntrada.ReadOnly = True
			_columnFolioTransferenciaEntrada.Caption = "FolioTransferenciaEntrada"
			Me.Columns.Add(_columnFolioTransferenciaEntrada)

			_columnIdAlmacenDestino = New DataColumn("IdAlmacenDestino", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdAlmacenDestino.ReadOnly = True
			_columnIdAlmacenDestino.Caption = "IdAlmacenDestino"
			Me.Columns.Add(_columnIdAlmacenDestino)

			_columnAlmacenDestino = New DataColumn("AlmacenDestino", GetType(System.String), Nothing, MappingType.Element)
			_columnAlmacenDestino.ReadOnly = True
			_columnAlmacenDestino.Caption = "AlmacenDestino"
			Me.Columns.Add(_columnAlmacenDestino)

			_columnFechaMovimiento = New DataColumn("FechaMovimiento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaMovimiento.ReadOnly = True
			_columnFechaMovimiento.Caption = "FechaMovimiento"
			Me.Columns.Add(_columnFechaMovimiento)

			_columnTotalProductos = New DataColumn("TotalProductos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotalProductos.ReadOnly = True
			_columnTotalProductos.Caption = "TotalProductos"
			Me.Columns.Add(_columnTotalProductos)

			_columnImporte = New DataColumn("Importe", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporte.ReadOnly = True
			_columnImporte.Caption = "Importe"
			Me.Columns.Add(_columnImporte)

			_columnEstatus = New DataColumn("Estatus", GetType(System.Int16), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnIdAlmacenOrigen = New DataColumn("IdAlmacenOrigen", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdAlmacenOrigen.ReadOnly = True
			_columnIdAlmacenOrigen.Caption = "IdAlmacenOrigen"
			Me.Columns.Add(_columnIdAlmacenOrigen)

			_columnAlmacenOrigen = New DataColumn("AlmacenOrigen", GetType(System.String), Nothing, MappingType.Element)
			_columnAlmacenOrigen.ReadOnly = True
			_columnAlmacenOrigen.Caption = "AlmacenOrigen"
			Me.Columns.Add(_columnAlmacenOrigen)

			_columnFolioTransferenciaSalida = New DataColumn("FolioTransferenciaSalida", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioTransferenciaSalida.ReadOnly = True
			_columnFolioTransferenciaSalida.Caption = "FolioTransferenciaSalida"
			Me.Columns.Add(_columnFolioTransferenciaSalida)

			_columnEstatusStr = New DataColumn("EstatusStr", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusStr.ReadOnly = True
			_columnEstatusStr.Caption = "EstatusStr"
			Me.Columns.Add(_columnEstatusStr)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolioTransferenciaEntrada = Me.Columns("FolioTransferenciaEntrada")
			_columnIdAlmacenDestino = Me.Columns("IdAlmacenDestino")
			_columnAlmacenDestino = Me.Columns("AlmacenDestino")
			_columnFechaMovimiento = Me.Columns("FechaMovimiento")
			_columnTotalProductos = Me.Columns("TotalProductos")
			_columnImporte = Me.Columns("Importe")
			_columnEstatus = Me.Columns("Estatus")
			_columnIdAlmacenOrigen = Me.Columns("IdAlmacenOrigen")
			_columnAlmacenOrigen = Me.Columns("AlmacenOrigen")
			_columnFolioTransferenciaSalida = Me.Columns("FolioTransferenciaSalida")
			_columnEstatusStr = Me.Columns("EstatusStr")
			
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

			_fieldsCustomProperties.Add("FolioTransferenciaEntrada", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdAlmacenDestino", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("AlmacenDestino", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalProductos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdAlmacenOrigen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("AlmacenOrigen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioTransferenciaSalida", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusStr", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaTransferenciaEntradaRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaTransferenciaEntradaTypedView = CType(MyBase.Clone(), VwBusquedaTransferenciaEntradaTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaTransferenciaEntradaTypedView()
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
				Return VwBusquedaTransferenciaEntradaTypedView.CustomProperties
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
				Return VwBusquedaTransferenciaEntradaTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaTransferenciaEntradaRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaTransferenciaEntradaRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioTransferenciaEntrada
		''' </summary>
		ReadOnly Friend Property FolioTransferenciaEntradaColumn As DataColumn
			Get 
				Return _columnFolioTransferenciaEntrada 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdAlmacenDestino
		''' </summary>
		ReadOnly Friend Property IdAlmacenDestinoColumn As DataColumn
			Get 
				Return _columnIdAlmacenDestino 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field AlmacenDestino
		''' </summary>
		ReadOnly Friend Property AlmacenDestinoColumn As DataColumn
			Get 
				Return _columnAlmacenDestino 
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
		''' Returns the column Object belonging to the TypedView field TotalProductos
		''' </summary>
		ReadOnly Friend Property TotalProductosColumn As DataColumn
			Get 
				Return _columnTotalProductos 
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
		''' Returns the column Object belonging to the TypedView field Estatus
		''' </summary>
		ReadOnly Friend Property EstatusColumn As DataColumn
			Get 
				Return _columnEstatus 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdAlmacenOrigen
		''' </summary>
		ReadOnly Friend Property IdAlmacenOrigenColumn As DataColumn
			Get 
				Return _columnIdAlmacenOrigen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field AlmacenOrigen
		''' </summary>
		ReadOnly Friend Property AlmacenOrigenColumn As DataColumn
			Get 
				Return _columnAlmacenOrigen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioTransferenciaSalida
		''' </summary>
		ReadOnly Friend Property FolioTransferenciaSalidaColumn As DataColumn
			Get 
				Return _columnFolioTransferenciaSalida 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EstatusStr
		''' </summary>
		ReadOnly Friend Property EstatusStrColumn As DataColumn
			Get 
				Return _columnEstatusStr 
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
	''' Typed datarow for the typed datatable VwBusquedaTransferenciaEntrada
	''' </summary>
	Public Class VwBusquedaTransferenciaEntradaRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaTransferenciaEntradaTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaTransferenciaEntradaTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolioTransferenciaEntrada<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."FolioTransferenciaEntrada"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 12
		''' </remarks>
		Public Property [FolioTransferenciaEntrada]() As System.String
			Get 
				If IsFolioTransferenciaEntradaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioTransferenciaEntradaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioTransferenciaEntradaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioTransferenciaEntrada is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioTransferenciaEntradaNull() As Boolean
			Return IsNull(_parent.FolioTransferenciaEntradaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioTransferenciaEntrada to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioTransferenciaEntradaNull() 
			Me(_parent.FolioTransferenciaEntradaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdAlmacenDestino<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."IdAlmacenDestino"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdAlmacenDestino]() As System.Int32
			Get 
				If IsIdAlmacenDestinoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdAlmacenDestinoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdAlmacenDestinoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdAlmacenDestino is NULL, False otherwise.
		''' </summary>
		Public Function IsIdAlmacenDestinoNull() As Boolean
			Return IsNull(_parent.IdAlmacenDestinoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdAlmacenDestino to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdAlmacenDestinoNull() 
			Me(_parent.IdAlmacenDestinoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field AlmacenDestino<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."AlmacenDestino"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [AlmacenDestino]() As System.String
			Get 
				If IsAlmacenDestinoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.AlmacenDestinoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.AlmacenDestinoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field AlmacenDestino is NULL, False otherwise.
		''' </summary>
		Public Function IsAlmacenDestinoNull() As Boolean
			Return IsNull(_parent.AlmacenDestinoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field AlmacenDestino to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAlmacenDestinoNull() 
			Me(_parent.AlmacenDestinoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."FechaMovimiento"<br/>
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
		''' Gets / sets the value of the TypedView field TotalProductos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."TotalProductos"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [TotalProductos]() As System.Decimal
			Get 
				If IsTotalProductosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TotalProductosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TotalProductosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalProductos is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalProductosNull() As Boolean
			Return IsNull(_parent.TotalProductosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalProductos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalProductosNull() 
			Me(_parent.TotalProductosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Importe<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."Importe"<br/>
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
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."Estatus"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
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
		''' Gets / sets the value of the TypedView field IdAlmacenOrigen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."IdAlmacenOrigen"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdAlmacenOrigen]() As System.Int32
			Get 
				If IsIdAlmacenOrigenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdAlmacenOrigenColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdAlmacenOrigenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdAlmacenOrigen is NULL, False otherwise.
		''' </summary>
		Public Function IsIdAlmacenOrigenNull() As Boolean
			Return IsNull(_parent.IdAlmacenOrigenColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdAlmacenOrigen to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdAlmacenOrigenNull() 
			Me(_parent.IdAlmacenOrigenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field AlmacenOrigen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."AlmacenOrigen"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [AlmacenOrigen]() As System.String
			Get 
				If IsAlmacenOrigenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.AlmacenOrigenColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.AlmacenOrigenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field AlmacenOrigen is NULL, False otherwise.
		''' </summary>
		Public Function IsAlmacenOrigenNull() As Boolean
			Return IsNull(_parent.AlmacenOrigenColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field AlmacenOrigen to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAlmacenOrigenNull() 
			Me(_parent.AlmacenOrigenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioTransferenciaSalida<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."FolioTransferenciaSalida"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 12
		''' </remarks>
		Public Property [FolioTransferenciaSalida]() As System.String
			Get 
				If IsFolioTransferenciaSalidaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioTransferenciaSalidaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioTransferenciaSalidaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioTransferenciaSalida is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioTransferenciaSalidaNull() As Boolean
			Return IsNull(_parent.FolioTransferenciaSalidaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioTransferenciaSalida to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioTransferenciaSalidaNull() 
			Me(_parent.FolioTransferenciaSalidaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EstatusStr<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaTransferenciaEntrada"."EstatusStr"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 9
		''' </remarks>
		Public Property [EstatusStr]() As System.String
			Get 
				If IsEstatusStrNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EstatusStrColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EstatusStrColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EstatusStr is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusStrNull() As Boolean
			Return IsNull(_parent.EstatusStrColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EstatusStr to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusStrNull() 
			Me(_parent.EstatusStrColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
