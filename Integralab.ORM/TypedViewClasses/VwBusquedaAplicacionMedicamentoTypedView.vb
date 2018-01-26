' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 26 de enero de 2018 13:41:36
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
	''' Typed datatable for the view 'VwBusquedaAplicacionMedicamento'.<br/><br/>
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
	Public Class VwBusquedaAplicacionMedicamentoTypedView 
#Else
	Public Class VwBusquedaAplicacionMedicamentoTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioAplicacionMedicamento As DataColumn
		Private _columnIdAlmacen As DataColumn
		Private _columnAlmacen As DataColumn
		Private _columnIdUsuarioAlta As DataColumn
		Private _columnFolioMovimientoAlmacen As DataColumn
		Private _columnFechaAplicacionMedicamento As DataColumn
		Private _columnFechaCaptura As DataColumn
		Private _columnTotalCabezas As DataColumn
		Private _columnTotalKilos As DataColumn
		Private _columnCostoTotal As DataColumn
		Private _columnEstatus As DataColumn
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
			MyBase.New("VwBusquedaAplicacionMedicamento")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaAplicacionMedicamentoTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaAplicacionMedicamentoTypedView)
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
			Return New VwBusquedaAplicacionMedicamentoRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolioAplicacionMedicamento = New DataColumn("FolioAplicacionMedicamento", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioAplicacionMedicamento.ReadOnly = True
			_columnFolioAplicacionMedicamento.Caption = "FolioAplicacionMedicamento"
			Me.Columns.Add(_columnFolioAplicacionMedicamento)

			_columnIdAlmacen = New DataColumn("IdAlmacen", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdAlmacen.ReadOnly = True
			_columnIdAlmacen.Caption = "IdAlmacen"
			Me.Columns.Add(_columnIdAlmacen)

			_columnAlmacen = New DataColumn("Almacen", GetType(System.String), Nothing, MappingType.Element)
			_columnAlmacen.ReadOnly = True
			_columnAlmacen.Caption = "Almacen"
			Me.Columns.Add(_columnAlmacen)

			_columnIdUsuarioAlta = New DataColumn("IdUsuarioAlta", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdUsuarioAlta.ReadOnly = True
			_columnIdUsuarioAlta.Caption = "IdUsuarioAlta"
			Me.Columns.Add(_columnIdUsuarioAlta)

			_columnFolioMovimientoAlmacen = New DataColumn("FolioMovimientoAlmacen", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioMovimientoAlmacen.ReadOnly = True
			_columnFolioMovimientoAlmacen.Caption = "FolioMovimientoAlmacen"
			Me.Columns.Add(_columnFolioMovimientoAlmacen)

			_columnFechaAplicacionMedicamento = New DataColumn("FechaAplicacionMedicamento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaAplicacionMedicamento.ReadOnly = True
			_columnFechaAplicacionMedicamento.Caption = "FechaAplicacionMedicamento"
			Me.Columns.Add(_columnFechaAplicacionMedicamento)

			_columnFechaCaptura = New DataColumn("FechaCaptura", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCaptura.ReadOnly = True
			_columnFechaCaptura.Caption = "FechaCaptura"
			Me.Columns.Add(_columnFechaCaptura)

			_columnTotalCabezas = New DataColumn("TotalCabezas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnTotalCabezas.ReadOnly = True
			_columnTotalCabezas.Caption = "TotalCabezas"
			Me.Columns.Add(_columnTotalCabezas)

			_columnTotalKilos = New DataColumn("TotalKilos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotalKilos.ReadOnly = True
			_columnTotalKilos.Caption = "TotalKilos"
			Me.Columns.Add(_columnTotalKilos)

			_columnCostoTotal = New DataColumn("CostoTotal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCostoTotal.ReadOnly = True
			_columnCostoTotal.Caption = "CostoTotal"
			Me.Columns.Add(_columnCostoTotal)

			_columnEstatus = New DataColumn("Estatus", GetType(System.Byte), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

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
			_columnFolioAplicacionMedicamento = Me.Columns("FolioAplicacionMedicamento")
			_columnIdAlmacen = Me.Columns("IdAlmacen")
			_columnAlmacen = Me.Columns("Almacen")
			_columnIdUsuarioAlta = Me.Columns("IdUsuarioAlta")
			_columnFolioMovimientoAlmacen = Me.Columns("FolioMovimientoAlmacen")
			_columnFechaAplicacionMedicamento = Me.Columns("FechaAplicacionMedicamento")
			_columnFechaCaptura = Me.Columns("FechaCaptura")
			_columnTotalCabezas = Me.Columns("TotalCabezas")
			_columnTotalKilos = Me.Columns("TotalKilos")
			_columnCostoTotal = Me.Columns("CostoTotal")
			_columnEstatus = Me.Columns("Estatus")
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

			_fieldsCustomProperties.Add("FolioAplicacionMedicamento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdAlmacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Almacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaAplicacionMedicamento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalCabezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalKilos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CostoTotal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusStr", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaAplicacionMedicamentoRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaAplicacionMedicamentoTypedView = CType(MyBase.Clone(), VwBusquedaAplicacionMedicamentoTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaAplicacionMedicamentoTypedView()
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
				Return VwBusquedaAplicacionMedicamentoTypedView.CustomProperties
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
				Return VwBusquedaAplicacionMedicamentoTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaAplicacionMedicamentoRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaAplicacionMedicamentoRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioAplicacionMedicamento
		''' </summary>
		ReadOnly Friend Property FolioAplicacionMedicamentoColumn As DataColumn
			Get 
				Return _columnFolioAplicacionMedicamento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdAlmacen
		''' </summary>
		ReadOnly Friend Property IdAlmacenColumn As DataColumn
			Get 
				Return _columnIdAlmacen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Almacen
		''' </summary>
		ReadOnly Friend Property AlmacenColumn As DataColumn
			Get 
				Return _columnAlmacen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdUsuarioAlta
		''' </summary>
		ReadOnly Friend Property IdUsuarioAltaColumn As DataColumn
			Get 
				Return _columnIdUsuarioAlta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioMovimientoAlmacen
		''' </summary>
		ReadOnly Friend Property FolioMovimientoAlmacenColumn As DataColumn
			Get 
				Return _columnFolioMovimientoAlmacen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaAplicacionMedicamento
		''' </summary>
		ReadOnly Friend Property FechaAplicacionMedicamentoColumn As DataColumn
			Get 
				Return _columnFechaAplicacionMedicamento 
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
		''' Returns the column Object belonging to the TypedView field TotalCabezas
		''' </summary>
		ReadOnly Friend Property TotalCabezasColumn As DataColumn
			Get 
				Return _columnTotalCabezas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TotalKilos
		''' </summary>
		ReadOnly Friend Property TotalKilosColumn As DataColumn
			Get 
				Return _columnTotalKilos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CostoTotal
		''' </summary>
		ReadOnly Friend Property CostoTotalColumn As DataColumn
			Get 
				Return _columnCostoTotal 
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
	''' Typed datarow for the typed datatable VwBusquedaAplicacionMedicamento
	''' </summary>
	Public Class VwBusquedaAplicacionMedicamentoRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaAplicacionMedicamentoTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaAplicacionMedicamentoTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolioAplicacionMedicamento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."FolioAplicacionMedicamento"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 8
		''' </remarks>
		Public Property [FolioAplicacionMedicamento]() As System.String
			Get 
				If IsFolioAplicacionMedicamentoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioAplicacionMedicamentoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioAplicacionMedicamentoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioAplicacionMedicamento is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioAplicacionMedicamentoNull() As Boolean
			Return IsNull(_parent.FolioAplicacionMedicamentoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioAplicacionMedicamento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioAplicacionMedicamentoNull() 
			Me(_parent.FolioAplicacionMedicamentoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdAlmacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."IdAlmacen"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdAlmacen]() As System.Int32
			Get 
				If IsIdAlmacenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdAlmacenColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdAlmacenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdAlmacen is NULL, False otherwise.
		''' </summary>
		Public Function IsIdAlmacenNull() As Boolean
			Return IsNull(_parent.IdAlmacenColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdAlmacen to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdAlmacenNull() 
			Me(_parent.IdAlmacenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Almacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."Almacen"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [Almacen]() As System.String
			Get 
				If IsAlmacenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.AlmacenColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.AlmacenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Almacen is NULL, False otherwise.
		''' </summary>
		Public Function IsAlmacenNull() As Boolean
			Return IsNull(_parent.AlmacenColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Almacen to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAlmacenNull() 
			Me(_parent.AlmacenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdUsuarioAlta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."IdUsuarioAlta"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdUsuarioAlta]() As System.Int32
			Get 
				If IsIdUsuarioAltaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdUsuarioAltaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdUsuarioAltaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdUsuarioAlta is NULL, False otherwise.
		''' </summary>
		Public Function IsIdUsuarioAltaNull() As Boolean
			Return IsNull(_parent.IdUsuarioAltaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdUsuarioAlta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdUsuarioAltaNull() 
			Me(_parent.IdUsuarioAltaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioMovimientoAlmacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."FolioMovimientoAlmacen"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 20
		''' </remarks>
		Public Property [FolioMovimientoAlmacen]() As System.String
			Get 
				If IsFolioMovimientoAlmacenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioMovimientoAlmacenColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioMovimientoAlmacenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioMovimientoAlmacen is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioMovimientoAlmacenNull() As Boolean
			Return IsNull(_parent.FolioMovimientoAlmacenColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioMovimientoAlmacen to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioMovimientoAlmacenNull() 
			Me(_parent.FolioMovimientoAlmacenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaAplicacionMedicamento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."FechaAplicacionMedicamento"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaAplicacionMedicamento]() As System.DateTime
			Get 
				If IsFechaAplicacionMedicamentoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaAplicacionMedicamentoColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaAplicacionMedicamentoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaAplicacionMedicamento is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaAplicacionMedicamentoNull() As Boolean
			Return IsNull(_parent.FechaAplicacionMedicamentoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaAplicacionMedicamento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaAplicacionMedicamentoNull() 
			Me(_parent.FechaAplicacionMedicamentoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaCaptura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."FechaCaptura"<br/>
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
		''' Gets / sets the value of the TypedView field TotalCabezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."TotalCabezas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [TotalCabezas]() As System.Int32
			Get 
				If IsTotalCabezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.TotalCabezasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.TotalCabezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalCabezas is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalCabezasNull() As Boolean
			Return IsNull(_parent.TotalCabezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalCabezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalCabezasNull() 
			Me(_parent.TotalCabezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TotalKilos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."TotalKilos"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 18, 4, 0
		''' </remarks>
		Public Property [TotalKilos]() As System.Decimal
			Get 
				If IsTotalKilosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TotalKilosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TotalKilosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalKilos is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalKilosNull() As Boolean
			Return IsNull(_parent.TotalKilosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalKilos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalKilosNull() 
			Me(_parent.TotalKilosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CostoTotal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."CostoTotal"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CostoTotal]() As System.Decimal
			Get 
				If IsCostoTotalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CostoTotalColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CostoTotalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CostoTotal is NULL, False otherwise.
		''' </summary>
		Public Function IsCostoTotalNull() As Boolean
			Return IsNull(_parent.CostoTotalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CostoTotal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCostoTotalNull() 
			Me(_parent.CostoTotalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."Estatus"<br/>
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
		''' Gets / sets the value of the TypedView field EstatusStr<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaAplicacionMedicamento"."EstatusStr"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 13
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
