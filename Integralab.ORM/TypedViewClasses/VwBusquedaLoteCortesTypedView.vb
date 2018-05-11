' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 30 de abril de 2018 09:07:37
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
	''' Typed datatable for the view 'VwBusquedaLoteCortes'.<br/><br/>
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
	Public Class VwBusquedaLoteCortesTypedView 
#Else
	Public Class VwBusquedaLoteCortesTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnLoteCorte As DataColumn
		Private _columnLoteSacrificio As DataColumn
		Private _columnFechaCorte As DataColumn
		Private _columnIdCliente As DataColumn
		Private _columnIntroductor As DataColumn
		Private _columnTotalKgs As DataColumn
		Private _columnEstatusCad As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnDiasCad As DataColumn
		Private _columnTipoLote As DataColumn
		Private _columnEsReproceso As DataColumn
		Private _columnTotalPzas As DataColumn
		Private _columnProducto As DataColumn
		Private _columnDescripcion As DataColumn
		Private _columnPrecioxkilototal As DataColumn
		Private _columnKilosRecibidos As DataColumn
		Private _columnNopiezas As DataColumn
		
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
			MyBase.New("VwBusquedaLoteCortes")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaLoteCortesTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaLoteCortesTypedView)
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
			Return New VwBusquedaLoteCortesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnLoteCorte = New DataColumn("LoteCorte", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteCorte.ReadOnly = True
			_columnLoteCorte.Caption = "LoteCorte"
			Me.Columns.Add(_columnLoteCorte)

			_columnLoteSacrificio = New DataColumn("LoteSacrificio", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteSacrificio.ReadOnly = True
			_columnLoteSacrificio.Caption = "LoteSacrificio"
			Me.Columns.Add(_columnLoteSacrificio)

			_columnFechaCorte = New DataColumn("FechaCorte", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCorte.ReadOnly = True
			_columnFechaCorte.Caption = "FechaCorte"
			Me.Columns.Add(_columnFechaCorte)

			_columnIdCliente = New DataColumn("IdCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCliente.ReadOnly = True
			_columnIdCliente.Caption = "IdCliente"
			Me.Columns.Add(_columnIdCliente)

			_columnIntroductor = New DataColumn("Introductor", GetType(System.String), Nothing, MappingType.Element)
			_columnIntroductor.ReadOnly = True
			_columnIntroductor.Caption = "Introductor"
			Me.Columns.Add(_columnIntroductor)

			_columnTotalKgs = New DataColumn("TotalKgs", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotalKgs.ReadOnly = True
			_columnTotalKgs.Caption = "TotalKgs"
			Me.Columns.Add(_columnTotalKgs)

			_columnEstatusCad = New DataColumn("EstatusCad", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusCad.ReadOnly = True
			_columnEstatusCad.Caption = "EstatusCad"
			Me.Columns.Add(_columnEstatusCad)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnDiasCad = New DataColumn("DiasCad", GetType(System.Int32), Nothing, MappingType.Element)
			_columnDiasCad.ReadOnly = True
			_columnDiasCad.Caption = "DiasCad"
			Me.Columns.Add(_columnDiasCad)

			_columnTipoLote = New DataColumn("TipoLote", GetType(System.String), Nothing, MappingType.Element)
			_columnTipoLote.ReadOnly = True
			_columnTipoLote.Caption = "TipoLote"
			Me.Columns.Add(_columnTipoLote)

			_columnEsReproceso = New DataColumn("EsReproceso", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnEsReproceso.ReadOnly = True
			_columnEsReproceso.Caption = "EsReproceso"
			Me.Columns.Add(_columnEsReproceso)

			_columnTotalPzas = New DataColumn("TotalPzas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotalPzas.ReadOnly = True
			_columnTotalPzas.Caption = "TotalPzas"
			Me.Columns.Add(_columnTotalPzas)

			_columnProducto = New DataColumn("Producto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnProducto.ReadOnly = True
			_columnProducto.Caption = "Producto"
			Me.Columns.Add(_columnProducto)

			_columnDescripcion = New DataColumn("Descripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnDescripcion.ReadOnly = True
			_columnDescripcion.Caption = "Descripcion"
			Me.Columns.Add(_columnDescripcion)

			_columnPrecioxkilototal = New DataColumn("Precioxkilototal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPrecioxkilototal.ReadOnly = True
			_columnPrecioxkilototal.Caption = "Precioxkilototal"
			Me.Columns.Add(_columnPrecioxkilototal)

			_columnKilosRecibidos = New DataColumn("KilosRecibidos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosRecibidos.ReadOnly = True
			_columnKilosRecibidos.Caption = "KilosRecibidos"
			Me.Columns.Add(_columnKilosRecibidos)

			_columnNopiezas = New DataColumn("Nopiezas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnNopiezas.ReadOnly = True
			_columnNopiezas.Caption = "Nopiezas"
			Me.Columns.Add(_columnNopiezas)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnLoteCorte = Me.Columns("LoteCorte")
			_columnLoteSacrificio = Me.Columns("LoteSacrificio")
			_columnFechaCorte = Me.Columns("FechaCorte")
			_columnIdCliente = Me.Columns("IdCliente")
			_columnIntroductor = Me.Columns("Introductor")
			_columnTotalKgs = Me.Columns("TotalKgs")
			_columnEstatusCad = Me.Columns("EstatusCad")
			_columnEstatus = Me.Columns("Estatus")
			_columnDiasCad = Me.Columns("DiasCad")
			_columnTipoLote = Me.Columns("TipoLote")
			_columnEsReproceso = Me.Columns("EsReproceso")
			_columnTotalPzas = Me.Columns("TotalPzas")
			_columnProducto = Me.Columns("Producto")
			_columnDescripcion = Me.Columns("Descripcion")
			_columnPrecioxkilototal = Me.Columns("Precioxkilototal")
			_columnKilosRecibidos = Me.Columns("KilosRecibidos")
			_columnNopiezas = Me.Columns("Nopiezas")
			
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

			_fieldsCustomProperties.Add("LoteCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("LoteSacrificio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Introductor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalKgs", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("DiasCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoLote", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EsReproceso", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalPzas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Producto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Precioxkilototal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosRecibidos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nopiezas", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaLoteCortesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaLoteCortesTypedView = CType(MyBase.Clone(), VwBusquedaLoteCortesTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaLoteCortesTypedView()
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
				Return VwBusquedaLoteCortesTypedView.CustomProperties
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
				Return VwBusquedaLoteCortesTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaLoteCortesRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaLoteCortesRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field LoteCorte
		''' </summary>
		ReadOnly Friend Property LoteCorteColumn As DataColumn
			Get 
				Return _columnLoteCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field LoteSacrificio
		''' </summary>
		ReadOnly Friend Property LoteSacrificioColumn As DataColumn
			Get 
				Return _columnLoteSacrificio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaCorte
		''' </summary>
		ReadOnly Friend Property FechaCorteColumn As DataColumn
			Get 
				Return _columnFechaCorte 
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
		''' Returns the column Object belonging to the TypedView field Introductor
		''' </summary>
		ReadOnly Friend Property IntroductorColumn As DataColumn
			Get 
				Return _columnIntroductor 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TotalKgs
		''' </summary>
		ReadOnly Friend Property TotalKgsColumn As DataColumn
			Get 
				Return _columnTotalKgs 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EstatusCad
		''' </summary>
		ReadOnly Friend Property EstatusCadColumn As DataColumn
			Get 
				Return _columnEstatusCad 
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
		''' Returns the column Object belonging to the TypedView field DiasCad
		''' </summary>
		ReadOnly Friend Property DiasCadColumn As DataColumn
			Get 
				Return _columnDiasCad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TipoLote
		''' </summary>
		ReadOnly Friend Property TipoLoteColumn As DataColumn
			Get 
				Return _columnTipoLote 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EsReproceso
		''' </summary>
		ReadOnly Friend Property EsReprocesoColumn As DataColumn
			Get 
				Return _columnEsReproceso 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TotalPzas
		''' </summary>
		ReadOnly Friend Property TotalPzasColumn As DataColumn
			Get 
				Return _columnTotalPzas 
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
		''' Returns the column Object belonging to the TypedView field Descripcion
		''' </summary>
		ReadOnly Friend Property DescripcionColumn As DataColumn
			Get 
				Return _columnDescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Precioxkilototal
		''' </summary>
		ReadOnly Friend Property PrecioxkilototalColumn As DataColumn
			Get 
				Return _columnPrecioxkilototal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field KilosRecibidos
		''' </summary>
		ReadOnly Friend Property KilosRecibidosColumn As DataColumn
			Get 
				Return _columnKilosRecibidos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Nopiezas
		''' </summary>
		ReadOnly Friend Property NopiezasColumn As DataColumn
			Get 
				Return _columnNopiezas 
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
	''' Typed datarow for the typed datatable VwBusquedaLoteCortes
	''' </summary>
	Public Class VwBusquedaLoteCortesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaLoteCortesTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaLoteCortesTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field LoteCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."LoteCorte"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [LoteCorte]() As System.String
			Get 
				If IsLoteCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LoteCorteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LoteCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field LoteCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsLoteCorteNull() As Boolean
			Return IsNull(_parent.LoteCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field LoteCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLoteCorteNull() 
			Me(_parent.LoteCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field LoteSacrificio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."LoteSacrificio"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 11
		''' </remarks>
		Public Property [LoteSacrificio]() As System.String
			Get 
				If IsLoteSacrificioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LoteSacrificioColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LoteSacrificioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field LoteSacrificio is NULL, False otherwise.
		''' </summary>
		Public Function IsLoteSacrificioNull() As Boolean
			Return IsNull(_parent.LoteSacrificioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field LoteSacrificio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLoteSacrificioNull() 
			Me(_parent.LoteSacrificioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."FechaCorte"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaCorte]() As System.DateTime
			Get 
				If IsFechaCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaCorteColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaCorteNull() As Boolean
			Return IsNull(_parent.FechaCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaCorteNull() 
			Me(_parent.FechaCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."IdCliente"<br/>
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
		''' Gets / sets the value of the TypedView field Introductor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."Introductor"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 120
		''' </remarks>
		Public Property [Introductor]() As System.String
			Get 
				If IsIntroductorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IntroductorColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IntroductorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Introductor is NULL, False otherwise.
		''' </summary>
		Public Function IsIntroductorNull() As Boolean
			Return IsNull(_parent.IntroductorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Introductor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIntroductorNull() 
			Me(_parent.IntroductorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TotalKgs<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."TotalKgs"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [TotalKgs]() As System.Decimal
			Get 
				If IsTotalKgsNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TotalKgsColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TotalKgsColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalKgs is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalKgsNull() As Boolean
			Return IsNull(_parent.TotalKgsColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalKgs to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalKgsNull() 
			Me(_parent.TotalKgsColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EstatusCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."EstatusCad"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 9
		''' </remarks>
		Public Property [EstatusCad]() As System.String
			Get 
				If IsEstatusCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EstatusCadColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EstatusCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EstatusCad is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusCadNull() As Boolean
			Return IsNull(_parent.EstatusCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EstatusCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusCadNull() 
			Me(_parent.EstatusCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."Estatus"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 1
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
		''' Gets / sets the value of the TypedView field DiasCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."DiasCad"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [DiasCad]() As System.Int32
			Get 
				If IsDiasCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.DiasCadColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.DiasCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field DiasCad is NULL, False otherwise.
		''' </summary>
		Public Function IsDiasCadNull() As Boolean
			Return IsNull(_parent.DiasCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field DiasCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDiasCadNull() 
			Me(_parent.DiasCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TipoLote<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."TipoLote"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 10
		''' </remarks>
		Public Property [TipoLote]() As System.String
			Get 
				If IsTipoLoteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TipoLoteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TipoLoteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoLote is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoLoteNull() As Boolean
			Return IsNull(_parent.TipoLoteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoLote to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoLoteNull() 
			Me(_parent.TipoLoteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EsReproceso<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."EsReproceso"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [EsReproceso]() As System.Boolean
			Get 
				If IsEsReprocesoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.EsReprocesoColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.EsReprocesoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EsReproceso is NULL, False otherwise.
		''' </summary>
		Public Function IsEsReprocesoNull() As Boolean
			Return IsNull(_parent.EsReprocesoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EsReproceso to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEsReprocesoNull() 
			Me(_parent.EsReprocesoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TotalPzas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."TotalPzas"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [TotalPzas]() As System.Decimal
			Get 
				If IsTotalPzasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TotalPzasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TotalPzasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalPzas is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalPzasNull() As Boolean
			Return IsNull(_parent.TotalPzasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalPzas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalPzasNull() 
			Me(_parent.TotalPzasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Producto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."Producto"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Producto]() As System.Int32
			Get 
				If IsProductoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.ProductoColumn), System.Int32)
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
		''' Gets / sets the value of the TypedView field Descripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."Descripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Descripcion]() As System.String
			Get 
				If IsDescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.DescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.DescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Descripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsDescripcionNull() As Boolean
			Return IsNull(_parent.DescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Descripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDescripcionNull() 
			Me(_parent.DescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Precioxkilototal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."precioxkilototal"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [Precioxkilototal]() As System.Decimal
			Get 
				If IsPrecioxkilototalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PrecioxkilototalColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PrecioxkilototalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Precioxkilototal is NULL, False otherwise.
		''' </summary>
		Public Function IsPrecioxkilototalNull() As Boolean
			Return IsNull(_parent.PrecioxkilototalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Precioxkilototal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrecioxkilototalNull() 
			Me(_parent.PrecioxkilototalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosRecibidos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."KilosRecibidos"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosRecibidos]() As System.Decimal
			Get 
				If IsKilosRecibidosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosRecibidosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosRecibidosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosRecibidos is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosRecibidosNull() As Boolean
			Return IsNull(_parent.KilosRecibidosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosRecibidos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosRecibidosNull() 
			Me(_parent.KilosRecibidosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Nopiezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaLoteCortes"."Nopiezas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Nopiezas]() As System.Int32
			Get 
				If IsNopiezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.NopiezasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.NopiezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Nopiezas is NULL, False otherwise.
		''' </summary>
		Public Function IsNopiezasNull() As Boolean
			Return IsNull(_parent.NopiezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Nopiezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNopiezasNull() 
			Me(_parent.NopiezasColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
