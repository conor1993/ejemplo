' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 11 de enero de 2018 10:37:38
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
	''' Typed datatable for the view 'VwBusquedaMovimientosAlmacen'.<br/><br/>
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
	Public Class VwBusquedaMovimientosAlmacenTypedView 
#Else
	Public Class VwBusquedaMovimientosAlmacenTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnIdAlmacen As DataColumn
		Private _columnFolioMovimiento As DataColumn
		Private _columnFechaMovimiento As DataColumn
		Private _columnIdTipoMovimiento As DataColumn
		Private _columnCostoTotal As DataColumn
		Private _columnOrigen As DataColumn
		Private _columnReferencia As DataColumn
		Private _columnUsuarioId As DataColumn
		Private _columnFechaContabilizacion As DataColumn
		Private _columnPolizaContabilidad As DataColumn
		Private _columnEntrega As DataColumn
		Private _columnRecibe As DataColumn
		Private _columnObservaciones As DataColumn
		Private _columnAlmacen As DataColumn
		Private _columnTipoMovimiento As DataColumn
		Private _columnDireccion As DataColumn
		Private _columnAfectaCosto As DataColumn
		Private _columnEstatusContabilizado As DataColumn
		Private _columnDireccionStr As DataColumn
		Private _columnEstatus As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 20
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
			MyBase.New("VwBusquedaMovimientosAlmacen")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaMovimientosAlmacenTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaMovimientosAlmacenTypedView)
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
			Return New VwBusquedaMovimientosAlmacenRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnIdAlmacen = New DataColumn("IdAlmacen", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdAlmacen.ReadOnly = True
			_columnIdAlmacen.Caption = "IdAlmacen"
			Me.Columns.Add(_columnIdAlmacen)

			_columnFolioMovimiento = New DataColumn("FolioMovimiento", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioMovimiento.ReadOnly = True
			_columnFolioMovimiento.Caption = "FolioMovimiento"
			Me.Columns.Add(_columnFolioMovimiento)

			_columnFechaMovimiento = New DataColumn("FechaMovimiento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaMovimiento.ReadOnly = True
			_columnFechaMovimiento.Caption = "FechaMovimiento"
			Me.Columns.Add(_columnFechaMovimiento)

			_columnIdTipoMovimiento = New DataColumn("IdTipoMovimiento", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdTipoMovimiento.ReadOnly = True
			_columnIdTipoMovimiento.Caption = "IdTipoMovimiento"
			Me.Columns.Add(_columnIdTipoMovimiento)

			_columnCostoTotal = New DataColumn("CostoTotal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCostoTotal.ReadOnly = True
			_columnCostoTotal.Caption = "CostoTotal"
			Me.Columns.Add(_columnCostoTotal)

			_columnOrigen = New DataColumn("Origen", GetType(System.String), Nothing, MappingType.Element)
			_columnOrigen.ReadOnly = True
			_columnOrigen.Caption = "Origen"
			Me.Columns.Add(_columnOrigen)

			_columnReferencia = New DataColumn("Referencia", GetType(System.String), Nothing, MappingType.Element)
			_columnReferencia.ReadOnly = True
			_columnReferencia.Caption = "Referencia"
			Me.Columns.Add(_columnReferencia)

			_columnUsuarioId = New DataColumn("UsuarioId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnUsuarioId.ReadOnly = True
			_columnUsuarioId.Caption = "UsuarioId"
			Me.Columns.Add(_columnUsuarioId)

			_columnFechaContabilizacion = New DataColumn("FechaContabilizacion", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaContabilizacion.ReadOnly = True
			_columnFechaContabilizacion.Caption = "FechaContabilizacion"
			Me.Columns.Add(_columnFechaContabilizacion)

			_columnPolizaContabilidad = New DataColumn("PolizaContabilidad", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPolizaContabilidad.ReadOnly = True
			_columnPolizaContabilidad.Caption = "PolizaContabilidad"
			Me.Columns.Add(_columnPolizaContabilidad)

			_columnEntrega = New DataColumn("Entrega", GetType(System.String), Nothing, MappingType.Element)
			_columnEntrega.ReadOnly = True
			_columnEntrega.Caption = "Entrega"
			Me.Columns.Add(_columnEntrega)

			_columnRecibe = New DataColumn("Recibe", GetType(System.String), Nothing, MappingType.Element)
			_columnRecibe.ReadOnly = True
			_columnRecibe.Caption = "Recibe"
			Me.Columns.Add(_columnRecibe)

			_columnObservaciones = New DataColumn("Observaciones", GetType(System.String), Nothing, MappingType.Element)
			_columnObservaciones.ReadOnly = True
			_columnObservaciones.Caption = "Observaciones"
			Me.Columns.Add(_columnObservaciones)

			_columnAlmacen = New DataColumn("Almacen", GetType(System.String), Nothing, MappingType.Element)
			_columnAlmacen.ReadOnly = True
			_columnAlmacen.Caption = "Almacen"
			Me.Columns.Add(_columnAlmacen)

			_columnTipoMovimiento = New DataColumn("TipoMovimiento", GetType(System.String), Nothing, MappingType.Element)
			_columnTipoMovimiento.ReadOnly = True
			_columnTipoMovimiento.Caption = "TipoMovimiento"
			Me.Columns.Add(_columnTipoMovimiento)

			_columnDireccion = New DataColumn("Direccion", GetType(System.Int16), Nothing, MappingType.Element)
			_columnDireccion.ReadOnly = True
			_columnDireccion.Caption = "Direccion"
			Me.Columns.Add(_columnDireccion)

			_columnAfectaCosto = New DataColumn("AfectaCosto", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnAfectaCosto.ReadOnly = True
			_columnAfectaCosto.Caption = "AfectaCosto"
			Me.Columns.Add(_columnAfectaCosto)

			_columnEstatusContabilizado = New DataColumn("EstatusContabilizado", GetType(System.Int16), Nothing, MappingType.Element)
			_columnEstatusContabilizado.ReadOnly = True
			_columnEstatusContabilizado.Caption = "EstatusContabilizado"
			Me.Columns.Add(_columnEstatusContabilizado)

			_columnDireccionStr = New DataColumn("DireccionStr", GetType(System.String), Nothing, MappingType.Element)
			_columnDireccionStr.ReadOnly = True
			_columnDireccionStr.Caption = "DireccionStr"
			Me.Columns.Add(_columnDireccionStr)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnIdAlmacen = Me.Columns("IdAlmacen")
			_columnFolioMovimiento = Me.Columns("FolioMovimiento")
			_columnFechaMovimiento = Me.Columns("FechaMovimiento")
			_columnIdTipoMovimiento = Me.Columns("IdTipoMovimiento")
			_columnCostoTotal = Me.Columns("CostoTotal")
			_columnOrigen = Me.Columns("Origen")
			_columnReferencia = Me.Columns("Referencia")
			_columnUsuarioId = Me.Columns("UsuarioId")
			_columnFechaContabilizacion = Me.Columns("FechaContabilizacion")
			_columnPolizaContabilidad = Me.Columns("PolizaContabilidad")
			_columnEntrega = Me.Columns("Entrega")
			_columnRecibe = Me.Columns("Recibe")
			_columnObservaciones = Me.Columns("Observaciones")
			_columnAlmacen = Me.Columns("Almacen")
			_columnTipoMovimiento = Me.Columns("TipoMovimiento")
			_columnDireccion = Me.Columns("Direccion")
			_columnAfectaCosto = Me.Columns("AfectaCosto")
			_columnEstatusContabilizado = Me.Columns("EstatusContabilizado")
			_columnDireccionStr = Me.Columns("DireccionStr")
			_columnEstatus = Me.Columns("Estatus")
			
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

			_fieldsCustomProperties.Add("IdAlmacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdTipoMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CostoTotal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Origen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Referencia", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("UsuarioId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PolizaContabilidad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Entrega", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Recibe", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Almacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Direccion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("AfectaCosto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusContabilizado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("DireccionStr", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaMovimientosAlmacenRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaMovimientosAlmacenTypedView = CType(MyBase.Clone(), VwBusquedaMovimientosAlmacenTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaMovimientosAlmacenTypedView()
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
				Return VwBusquedaMovimientosAlmacenTypedView.CustomProperties
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
				Return VwBusquedaMovimientosAlmacenTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaMovimientosAlmacenRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaMovimientosAlmacenRow)
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
		''' Returns the column Object belonging to the TypedView field FolioMovimiento
		''' </summary>
		ReadOnly Friend Property FolioMovimientoColumn As DataColumn
			Get 
				Return _columnFolioMovimiento 
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
		''' Returns the column Object belonging to the TypedView field IdTipoMovimiento
		''' </summary>
		ReadOnly Friend Property IdTipoMovimientoColumn As DataColumn
			Get 
				Return _columnIdTipoMovimiento 
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
		''' Returns the column Object belonging to the TypedView field Origen
		''' </summary>
		ReadOnly Friend Property OrigenColumn As DataColumn
			Get 
				Return _columnOrigen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Referencia
		''' </summary>
		ReadOnly Friend Property ReferenciaColumn As DataColumn
			Get 
				Return _columnReferencia 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field UsuarioId
		''' </summary>
		ReadOnly Friend Property UsuarioIdColumn As DataColumn
			Get 
				Return _columnUsuarioId 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaContabilizacion
		''' </summary>
		ReadOnly Friend Property FechaContabilizacionColumn As DataColumn
			Get 
				Return _columnFechaContabilizacion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PolizaContabilidad
		''' </summary>
		ReadOnly Friend Property PolizaContabilidadColumn As DataColumn
			Get 
				Return _columnPolizaContabilidad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Entrega
		''' </summary>
		ReadOnly Friend Property EntregaColumn As DataColumn
			Get 
				Return _columnEntrega 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Recibe
		''' </summary>
		ReadOnly Friend Property RecibeColumn As DataColumn
			Get 
				Return _columnRecibe 
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
		''' Returns the column Object belonging to the TypedView field Almacen
		''' </summary>
		ReadOnly Friend Property AlmacenColumn As DataColumn
			Get 
				Return _columnAlmacen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TipoMovimiento
		''' </summary>
		ReadOnly Friend Property TipoMovimientoColumn As DataColumn
			Get 
				Return _columnTipoMovimiento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Direccion
		''' </summary>
		ReadOnly Friend Property DireccionColumn As DataColumn
			Get 
				Return _columnDireccion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field AfectaCosto
		''' </summary>
		ReadOnly Friend Property AfectaCostoColumn As DataColumn
			Get 
				Return _columnAfectaCosto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EstatusContabilizado
		''' </summary>
		ReadOnly Friend Property EstatusContabilizadoColumn As DataColumn
			Get 
				Return _columnEstatusContabilizado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field DireccionStr
		''' </summary>
		ReadOnly Friend Property DireccionStrColumn As DataColumn
			Get 
				Return _columnDireccionStr 
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
	''' Typed datarow for the typed datatable VwBusquedaMovimientosAlmacen
	''' </summary>
	Public Class VwBusquedaMovimientosAlmacenRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaMovimientosAlmacenTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaMovimientosAlmacenTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field IdAlmacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."IdAlmacen"<br/>
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
		''' Gets / sets the value of the TypedView field FolioMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."FolioMovimiento"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 20
		''' </remarks>
		Public Property [FolioMovimiento]() As System.String
			Get 
				If IsFolioMovimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioMovimientoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioMovimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioMovimientoNull() As Boolean
			Return IsNull(_parent.FolioMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioMovimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioMovimientoNull() 
			Me(_parent.FolioMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."FechaMovimiento"<br/>
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
		''' Gets / sets the value of the TypedView field IdTipoMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."IdTipoMovimiento"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdTipoMovimiento]() As System.Int32
			Get 
				If IsIdTipoMovimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdTipoMovimientoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdTipoMovimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdTipoMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsIdTipoMovimientoNull() As Boolean
			Return IsNull(_parent.IdTipoMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdTipoMovimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdTipoMovimientoNull() 
			Me(_parent.IdTipoMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CostoTotal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."CostoTotal"<br/>
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
		''' Gets / sets the value of the TypedView field Origen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."Origen"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 30
		''' </remarks>
		Public Property [Origen]() As System.String
			Get 
				If IsOrigenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.OrigenColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.OrigenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Origen is NULL, False otherwise.
		''' </summary>
		Public Function IsOrigenNull() As Boolean
			Return IsNull(_parent.OrigenColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Origen to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetOrigenNull() 
			Me(_parent.OrigenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Referencia<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."Referencia"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 20
		''' </remarks>
		Public Property [Referencia]() As System.String
			Get 
				If IsReferenciaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ReferenciaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ReferenciaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Referencia is NULL, False otherwise.
		''' </summary>
		Public Function IsReferenciaNull() As Boolean
			Return IsNull(_parent.ReferenciaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Referencia to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetReferenciaNull() 
			Me(_parent.ReferenciaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field UsuarioId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."UsuarioId"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [UsuarioId]() As System.Int32
			Get 
				If IsUsuarioIdNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.UsuarioIdColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.UsuarioIdColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field UsuarioId is NULL, False otherwise.
		''' </summary>
		Public Function IsUsuarioIdNull() As Boolean
			Return IsNull(_parent.UsuarioIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field UsuarioId to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetUsuarioIdNull() 
			Me(_parent.UsuarioIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaContabilizacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."FechaContabilizacion"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaContabilizacion]() As System.DateTime
			Get 
				If IsFechaContabilizacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaContabilizacionColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaContabilizacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaContabilizacion is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaContabilizacionNull() As Boolean
			Return IsNull(_parent.FechaContabilizacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaContabilizacion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaContabilizacionNull() 
			Me(_parent.FechaContabilizacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PolizaContabilidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."PolizaContabilidad"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PolizaContabilidad]() As System.Int32
			Get 
				If IsPolizaContabilidadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PolizaContabilidadColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PolizaContabilidadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PolizaContabilidad is NULL, False otherwise.
		''' </summary>
		Public Function IsPolizaContabilidadNull() As Boolean
			Return IsNull(_parent.PolizaContabilidadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PolizaContabilidad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPolizaContabilidadNull() 
			Me(_parent.PolizaContabilidadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Entrega<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."Entrega"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 120
		''' </remarks>
		Public Property [Entrega]() As System.String
			Get 
				If IsEntregaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EntregaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EntregaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Entrega is NULL, False otherwise.
		''' </summary>
		Public Function IsEntregaNull() As Boolean
			Return IsNull(_parent.EntregaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Entrega to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEntregaNull() 
			Me(_parent.EntregaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Recibe<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."Recibe"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 120
		''' </remarks>
		Public Property [Recibe]() As System.String
			Get 
				If IsRecibeNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.RecibeColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.RecibeColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Recibe is NULL, False otherwise.
		''' </summary>
		Public Function IsRecibeNull() As Boolean
			Return IsNull(_parent.RecibeColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Recibe to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetRecibeNull() 
			Me(_parent.RecibeColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Observaciones<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."Observaciones"<br/>
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
		''' Gets / sets the value of the TypedView field Almacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."Almacen"<br/>
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
		''' Gets / sets the value of the TypedView field TipoMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."TipoMovimiento"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 80
		''' </remarks>
		Public Property [TipoMovimiento]() As System.String
			Get 
				If IsTipoMovimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TipoMovimientoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TipoMovimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoMovimientoNull() As Boolean
			Return IsNull(_parent.TipoMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoMovimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoMovimientoNull() 
			Me(_parent.TipoMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Direccion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."Direccion"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [Direccion]() As System.Int16
			Get 
				If IsDireccionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.DireccionColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.DireccionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Direccion is NULL, False otherwise.
		''' </summary>
		Public Function IsDireccionNull() As Boolean
			Return IsNull(_parent.DireccionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Direccion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDireccionNull() 
			Me(_parent.DireccionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field AfectaCosto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."AfectaCosto"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [AfectaCosto]() As System.Boolean
			Get 
				If IsAfectaCostoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.AfectaCostoColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.AfectaCostoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field AfectaCosto is NULL, False otherwise.
		''' </summary>
		Public Function IsAfectaCostoNull() As Boolean
			Return IsNull(_parent.AfectaCostoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field AfectaCosto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAfectaCostoNull() 
			Me(_parent.AfectaCostoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EstatusContabilizado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."EstatusContabilizado"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [EstatusContabilizado]() As System.Int16
			Get 
				If IsEstatusContabilizadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.EstatusContabilizadoColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.EstatusContabilizadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EstatusContabilizado is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusContabilizadoNull() As Boolean
			Return IsNull(_parent.EstatusContabilizadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EstatusContabilizado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusContabilizadoNull() 
			Me(_parent.EstatusContabilizadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field DireccionStr<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."DireccionStr"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 7
		''' </remarks>
		Public Property [DireccionStr]() As System.String
			Get 
				If IsDireccionStrNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.DireccionStrColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.DireccionStrColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field DireccionStr is NULL, False otherwise.
		''' </summary>
		Public Function IsDireccionStrNull() As Boolean
			Return IsNull(_parent.DireccionStrColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field DireccionStr to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDireccionStrNull() 
			Me(_parent.DireccionStrColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaMovimientosAlmacen"."Estatus"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 9
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

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
