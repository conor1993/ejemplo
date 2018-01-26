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
	''' Typed datatable for the view 'VwBusquedaPreparacionMezcla'.<br/><br/>
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
	Public Class VwBusquedaPreparacionMezclaTypedView 
#Else
	Public Class VwBusquedaPreparacionMezclaTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolPrepForm As DataColumn
		Private _columnIdPlaza As DataColumn
		Private _columnFecPrepForm As DataColumn
		Private _columnIdAlmacen As DataColumn
		Private _columnAlmacen As DataColumn
		Private _columnIdMezcla As DataColumn
		Private _columnMezcla As DataColumn
		Private _columnCantaPreparar As DataColumn
		Private _columnCantRealaPrep As DataColumn
		Private _columnCostoTotal As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnEstatusStr As DataColumn
		Private _columnLote As DataColumn
		Private _columnIdEnvase As DataColumn
		Private _columnEnvase As DataColumn
		Private _columnCantidadEnvase As DataColumn
		Private _columnPlaza As DataColumn
		
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
			MyBase.New("VwBusquedaPreparacionMezcla")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaPreparacionMezclaTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaPreparacionMezclaTypedView)
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
			Return New VwBusquedaPreparacionMezclaRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolPrepForm = New DataColumn("FolPrepForm", GetType(System.String), Nothing, MappingType.Element)
			_columnFolPrepForm.ReadOnly = True
			_columnFolPrepForm.Caption = "FolPrepForm"
			Me.Columns.Add(_columnFolPrepForm)

			_columnIdPlaza = New DataColumn("IdPlaza", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdPlaza.ReadOnly = True
			_columnIdPlaza.Caption = "IdPlaza"
			Me.Columns.Add(_columnIdPlaza)

			_columnFecPrepForm = New DataColumn("FecPrepForm", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFecPrepForm.ReadOnly = True
			_columnFecPrepForm.Caption = "FecPrepForm"
			Me.Columns.Add(_columnFecPrepForm)

			_columnIdAlmacen = New DataColumn("IdAlmacen", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdAlmacen.ReadOnly = True
			_columnIdAlmacen.Caption = "IdAlmacen"
			Me.Columns.Add(_columnIdAlmacen)

			_columnAlmacen = New DataColumn("Almacen", GetType(System.String), Nothing, MappingType.Element)
			_columnAlmacen.ReadOnly = True
			_columnAlmacen.Caption = "Almacen"
			Me.Columns.Add(_columnAlmacen)

			_columnIdMezcla = New DataColumn("IdMezcla", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdMezcla.ReadOnly = True
			_columnIdMezcla.Caption = "IdMezcla"
			Me.Columns.Add(_columnIdMezcla)

			_columnMezcla = New DataColumn("Mezcla", GetType(System.String), Nothing, MappingType.Element)
			_columnMezcla.ReadOnly = True
			_columnMezcla.Caption = "Mezcla"
			Me.Columns.Add(_columnMezcla)

			_columnCantaPreparar = New DataColumn("CantaPreparar", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantaPreparar.ReadOnly = True
			_columnCantaPreparar.Caption = "CantaPreparar"
			Me.Columns.Add(_columnCantaPreparar)

			_columnCantRealaPrep = New DataColumn("CantRealaPrep", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantRealaPrep.ReadOnly = True
			_columnCantRealaPrep.Caption = "CantRealaPrep"
			Me.Columns.Add(_columnCantRealaPrep)

			_columnCostoTotal = New DataColumn("CostoTotal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCostoTotal.ReadOnly = True
			_columnCostoTotal.Caption = "CostoTotal"
			Me.Columns.Add(_columnCostoTotal)

			_columnEstatus = New DataColumn("Estatus", GetType(System.Int16), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnEstatusStr = New DataColumn("EstatusStr", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusStr.ReadOnly = True
			_columnEstatusStr.Caption = "EstatusStr"
			Me.Columns.Add(_columnEstatusStr)

			_columnLote = New DataColumn("Lote", GetType(System.String), Nothing, MappingType.Element)
			_columnLote.ReadOnly = True
			_columnLote.Caption = "Lote"
			Me.Columns.Add(_columnLote)

			_columnIdEnvase = New DataColumn("IdEnvase", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdEnvase.ReadOnly = True
			_columnIdEnvase.Caption = "IdEnvase"
			Me.Columns.Add(_columnIdEnvase)

			_columnEnvase = New DataColumn("Envase", GetType(System.String), Nothing, MappingType.Element)
			_columnEnvase.ReadOnly = True
			_columnEnvase.Caption = "Envase"
			Me.Columns.Add(_columnEnvase)

			_columnCantidadEnvase = New DataColumn("CantidadEnvase", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCantidadEnvase.ReadOnly = True
			_columnCantidadEnvase.Caption = "CantidadEnvase"
			Me.Columns.Add(_columnCantidadEnvase)

			_columnPlaza = New DataColumn("Plaza", GetType(System.String), Nothing, MappingType.Element)
			_columnPlaza.ReadOnly = True
			_columnPlaza.Caption = "Plaza"
			Me.Columns.Add(_columnPlaza)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolPrepForm = Me.Columns("FolPrepForm")
			_columnIdPlaza = Me.Columns("IdPlaza")
			_columnFecPrepForm = Me.Columns("FecPrepForm")
			_columnIdAlmacen = Me.Columns("IdAlmacen")
			_columnAlmacen = Me.Columns("Almacen")
			_columnIdMezcla = Me.Columns("IdMezcla")
			_columnMezcla = Me.Columns("Mezcla")
			_columnCantaPreparar = Me.Columns("CantaPreparar")
			_columnCantRealaPrep = Me.Columns("CantRealaPrep")
			_columnCostoTotal = Me.Columns("CostoTotal")
			_columnEstatus = Me.Columns("Estatus")
			_columnEstatusStr = Me.Columns("EstatusStr")
			_columnLote = Me.Columns("Lote")
			_columnIdEnvase = Me.Columns("IdEnvase")
			_columnEnvase = Me.Columns("Envase")
			_columnCantidadEnvase = Me.Columns("CantidadEnvase")
			_columnPlaza = Me.Columns("Plaza")
			
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

			_fieldsCustomProperties.Add("FolPrepForm", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdPlaza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FecPrepForm", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdAlmacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Almacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdMezcla", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Mezcla", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantaPreparar", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantRealaPrep", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CostoTotal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusStr", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Lote", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdEnvase", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Envase", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantidadEnvase", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Plaza", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaPreparacionMezclaRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaPreparacionMezclaTypedView = CType(MyBase.Clone(), VwBusquedaPreparacionMezclaTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaPreparacionMezclaTypedView()
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
				Return VwBusquedaPreparacionMezclaTypedView.CustomProperties
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
				Return VwBusquedaPreparacionMezclaTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaPreparacionMezclaRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaPreparacionMezclaRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolPrepForm
		''' </summary>
		ReadOnly Friend Property FolPrepFormColumn As DataColumn
			Get 
				Return _columnFolPrepForm 
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
		''' Returns the column Object belonging to the TypedView field FecPrepForm
		''' </summary>
		ReadOnly Friend Property FecPrepFormColumn As DataColumn
			Get 
				Return _columnFecPrepForm 
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
		''' Returns the column Object belonging to the TypedView field IdMezcla
		''' </summary>
		ReadOnly Friend Property IdMezclaColumn As DataColumn
			Get 
				Return _columnIdMezcla 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Mezcla
		''' </summary>
		ReadOnly Friend Property MezclaColumn As DataColumn
			Get 
				Return _columnMezcla 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantaPreparar
		''' </summary>
		ReadOnly Friend Property CantaPrepararColumn As DataColumn
			Get 
				Return _columnCantaPreparar 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantRealaPrep
		''' </summary>
		ReadOnly Friend Property CantRealaPrepColumn As DataColumn
			Get 
				Return _columnCantRealaPrep 
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
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Lote
		''' </summary>
		ReadOnly Friend Property LoteColumn As DataColumn
			Get 
				Return _columnLote 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdEnvase
		''' </summary>
		ReadOnly Friend Property IdEnvaseColumn As DataColumn
			Get 
				Return _columnIdEnvase 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Envase
		''' </summary>
		ReadOnly Friend Property EnvaseColumn As DataColumn
			Get 
				Return _columnEnvase 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantidadEnvase
		''' </summary>
		ReadOnly Friend Property CantidadEnvaseColumn As DataColumn
			Get 
				Return _columnCantidadEnvase 
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
	''' Typed datarow for the typed datatable VwBusquedaPreparacionMezcla
	''' </summary>
	Public Class VwBusquedaPreparacionMezclaRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaPreparacionMezclaTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaPreparacionMezclaTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolPrepForm<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."Fol_PrepForm"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 8
		''' </remarks>
		Public Property [FolPrepForm]() As System.String
			Get 
				If IsFolPrepFormNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolPrepFormColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolPrepFormColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolPrepForm is NULL, False otherwise.
		''' </summary>
		Public Function IsFolPrepFormNull() As Boolean
			Return IsNull(_parent.FolPrepFormColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolPrepForm to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolPrepFormNull() 
			Me(_parent.FolPrepFormColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdPlaza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."IdPlaza"<br/>
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
		''' Gets / sets the value of the TypedView field FecPrepForm<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."Fec_PrepForm"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FecPrepForm]() As System.DateTime
			Get 
				If IsFecPrepFormNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FecPrepFormColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FecPrepFormColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FecPrepForm is NULL, False otherwise.
		''' </summary>
		Public Function IsFecPrepFormNull() As Boolean
			Return IsNull(_parent.FecPrepFormColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FecPrepForm to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFecPrepFormNull() 
			Me(_parent.FecPrepFormColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdAlmacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."IdAlmacen"<br/>
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
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."Almacen"<br/>
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
		''' Gets / sets the value of the TypedView field IdMezcla<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."IdMezcla"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdMezcla]() As System.Int32
			Get 
				If IsIdMezclaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdMezclaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdMezclaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdMezcla is NULL, False otherwise.
		''' </summary>
		Public Function IsIdMezclaNull() As Boolean
			Return IsNull(_parent.IdMezclaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdMezcla to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdMezclaNull() 
			Me(_parent.IdMezclaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Mezcla<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."Mezcla"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
		''' </remarks>
		Public Property [Mezcla]() As System.String
			Get 
				If IsMezclaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.MezclaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.MezclaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Mezcla is NULL, False otherwise.
		''' </summary>
		Public Function IsMezclaNull() As Boolean
			Return IsNull(_parent.MezclaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Mezcla to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetMezclaNull() 
			Me(_parent.MezclaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantaPreparar<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."CantaPreparar"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CantaPreparar]() As System.Decimal
			Get 
				If IsCantaPrepararNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantaPrepararColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantaPrepararColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantaPreparar is NULL, False otherwise.
		''' </summary>
		Public Function IsCantaPrepararNull() As Boolean
			Return IsNull(_parent.CantaPrepararColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantaPreparar to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantaPrepararNull() 
			Me(_parent.CantaPrepararColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantRealaPrep<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."CantRealaPrep"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CantRealaPrep]() As System.Decimal
			Get 
				If IsCantRealaPrepNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantRealaPrepColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantRealaPrepColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantRealaPrep is NULL, False otherwise.
		''' </summary>
		Public Function IsCantRealaPrepNull() As Boolean
			Return IsNull(_parent.CantRealaPrepColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantRealaPrep to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantRealaPrepNull() 
			Me(_parent.CantRealaPrepColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CostoTotal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."CostoTotal"<br/>
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
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."Estatus"<br/>
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
		''' Gets / sets the value of the TypedView field EstatusStr<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."EstatusStr"<br/>
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

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Lote<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."Lote"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 15
		''' </remarks>
		Public Property [Lote]() As System.String
			Get 
				If IsLoteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LoteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LoteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Lote is NULL, False otherwise.
		''' </summary>
		Public Function IsLoteNull() As Boolean
			Return IsNull(_parent.LoteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Lote to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLoteNull() 
			Me(_parent.LoteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdEnvase<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."IdEnvase"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdEnvase]() As System.Int32
			Get 
				If IsIdEnvaseNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdEnvaseColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdEnvaseColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdEnvase is NULL, False otherwise.
		''' </summary>
		Public Function IsIdEnvaseNull() As Boolean
			Return IsNull(_parent.IdEnvaseColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdEnvase to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdEnvaseNull() 
			Me(_parent.IdEnvaseColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Envase<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."Envase"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
		''' </remarks>
		Public Property [Envase]() As System.String
			Get 
				If IsEnvaseNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EnvaseColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EnvaseColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Envase is NULL, False otherwise.
		''' </summary>
		Public Function IsEnvaseNull() As Boolean
			Return IsNull(_parent.EnvaseColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Envase to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEnvaseNull() 
			Me(_parent.EnvaseColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantidadEnvase<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."CantidadEnvase"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CantidadEnvase]() As System.Int32
			Get 
				If IsCantidadEnvaseNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CantidadEnvaseColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CantidadEnvaseColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantidadEnvase is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadEnvaseNull() As Boolean
			Return IsNull(_parent.CantidadEnvaseColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantidadEnvase to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadEnvaseNull() 
			Me(_parent.CantidadEnvaseColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Plaza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaPreparacionMezcla"."Plaza"<br/>
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

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
