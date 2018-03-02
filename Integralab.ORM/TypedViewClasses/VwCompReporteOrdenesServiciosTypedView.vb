' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 10:17:35
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
	''' Typed datatable for the view 'VwCompReporteOrdenesServicios'.<br/><br/>
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
	Public Class VwCompReporteOrdenesServiciosTypedView 
#Else
	Public Class VwCompReporteOrdenesServiciosTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnServicio As DataColumn
		Private _columnFolioDetalleSolicitud As DataColumn
		Private _columnIndice As DataColumn
		Private _columnCantidadSolicitada As DataColumn
		Private _columnCantidadOrdenar As DataColumn
		Private _columnPrecio As DataColumn
		Private _columnDescuento As DataColumn
		Private _columnIva As DataColumn
		Private _columnImporte As DataColumn
		Private _columnFolio As DataColumn
		Private _columnSucursalId As DataColumn
		Private _columnProveedorId As DataColumn
		Private _columnFechaAlta As DataColumn
		Private _columnScdescripcion As DataColumn
		Private _columnScidPlaza As DataColumn
		Private _columnPldescripcion As DataColumn
		Private _columnPrRazSocial As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnRecibidaCad As DataColumn
		Private _columnRecibida As DataColumn
		
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
			MyBase.New("VwCompReporteOrdenesServicios")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCompReporteOrdenesServiciosTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCompReporteOrdenesServiciosTypedView)
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
			Return New VwCompReporteOrdenesServiciosRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnServicio = New DataColumn("Servicio", GetType(System.String), Nothing, MappingType.Element)
			_columnServicio.ReadOnly = True
			_columnServicio.Caption = "Servicio"
			Me.Columns.Add(_columnServicio)

			_columnFolioDetalleSolicitud = New DataColumn("FolioDetalleSolicitud", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioDetalleSolicitud.ReadOnly = True
			_columnFolioDetalleSolicitud.Caption = "FolioDetalleSolicitud"
			Me.Columns.Add(_columnFolioDetalleSolicitud)

			_columnIndice = New DataColumn("Indice", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIndice.ReadOnly = True
			_columnIndice.Caption = "Indice"
			Me.Columns.Add(_columnIndice)

			_columnCantidadSolicitada = New DataColumn("CantidadSolicitada", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidadSolicitada.ReadOnly = True
			_columnCantidadSolicitada.Caption = "CantidadSolicitada"
			Me.Columns.Add(_columnCantidadSolicitada)

			_columnCantidadOrdenar = New DataColumn("CantidadOrdenar", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidadOrdenar.ReadOnly = True
			_columnCantidadOrdenar.Caption = "CantidadOrdenar"
			Me.Columns.Add(_columnCantidadOrdenar)

			_columnPrecio = New DataColumn("Precio", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPrecio.ReadOnly = True
			_columnPrecio.Caption = "Precio"
			Me.Columns.Add(_columnPrecio)

			_columnDescuento = New DataColumn("Descuento", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnDescuento.ReadOnly = True
			_columnDescuento.Caption = "Descuento"
			Me.Columns.Add(_columnDescuento)

			_columnIva = New DataColumn("Iva", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnIva.ReadOnly = True
			_columnIva.Caption = "Iva"
			Me.Columns.Add(_columnIva)

			_columnImporte = New DataColumn("Importe", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporte.ReadOnly = True
			_columnImporte.Caption = "Importe"
			Me.Columns.Add(_columnImporte)

			_columnFolio = New DataColumn("Folio", GetType(System.String), Nothing, MappingType.Element)
			_columnFolio.ReadOnly = True
			_columnFolio.Caption = "Folio"
			Me.Columns.Add(_columnFolio)

			_columnSucursalId = New DataColumn("SucursalId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnSucursalId.ReadOnly = True
			_columnSucursalId.Caption = "SucursalId"
			Me.Columns.Add(_columnSucursalId)

			_columnProveedorId = New DataColumn("ProveedorId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnProveedorId.ReadOnly = True
			_columnProveedorId.Caption = "ProveedorId"
			Me.Columns.Add(_columnProveedorId)

			_columnFechaAlta = New DataColumn("FechaAlta", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaAlta.ReadOnly = True
			_columnFechaAlta.Caption = "FechaAlta"
			Me.Columns.Add(_columnFechaAlta)

			_columnScdescripcion = New DataColumn("Scdescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnScdescripcion.ReadOnly = True
			_columnScdescripcion.Caption = "Scdescripcion"
			Me.Columns.Add(_columnScdescripcion)

			_columnScidPlaza = New DataColumn("ScidPlaza", GetType(System.Int32), Nothing, MappingType.Element)
			_columnScidPlaza.ReadOnly = True
			_columnScidPlaza.Caption = "ScidPlaza"
			Me.Columns.Add(_columnScidPlaza)

			_columnPldescripcion = New DataColumn("Pldescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnPldescripcion.ReadOnly = True
			_columnPldescripcion.Caption = "Pldescripcion"
			Me.Columns.Add(_columnPldescripcion)

			_columnPrRazSocial = New DataColumn("PrRazSocial", GetType(System.String), Nothing, MappingType.Element)
			_columnPrRazSocial.ReadOnly = True
			_columnPrRazSocial.Caption = "PrRazSocial"
			Me.Columns.Add(_columnPrRazSocial)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnRecibidaCad = New DataColumn("RecibidaCad", GetType(System.String), Nothing, MappingType.Element)
			_columnRecibidaCad.ReadOnly = True
			_columnRecibidaCad.Caption = "RecibidaCad"
			Me.Columns.Add(_columnRecibidaCad)

			_columnRecibida = New DataColumn("Recibida", GetType(System.Int16), Nothing, MappingType.Element)
			_columnRecibida.ReadOnly = True
			_columnRecibida.Caption = "Recibida"
			Me.Columns.Add(_columnRecibida)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnServicio = Me.Columns("Servicio")
			_columnFolioDetalleSolicitud = Me.Columns("FolioDetalleSolicitud")
			_columnIndice = Me.Columns("Indice")
			_columnCantidadSolicitada = Me.Columns("CantidadSolicitada")
			_columnCantidadOrdenar = Me.Columns("CantidadOrdenar")
			_columnPrecio = Me.Columns("Precio")
			_columnDescuento = Me.Columns("Descuento")
			_columnIva = Me.Columns("Iva")
			_columnImporte = Me.Columns("Importe")
			_columnFolio = Me.Columns("Folio")
			_columnSucursalId = Me.Columns("SucursalId")
			_columnProveedorId = Me.Columns("ProveedorId")
			_columnFechaAlta = Me.Columns("FechaAlta")
			_columnScdescripcion = Me.Columns("Scdescripcion")
			_columnScidPlaza = Me.Columns("ScidPlaza")
			_columnPldescripcion = Me.Columns("Pldescripcion")
			_columnPrRazSocial = Me.Columns("PrRazSocial")
			_columnEstatus = Me.Columns("Estatus")
			_columnRecibidaCad = Me.Columns("RecibidaCad")
			_columnRecibida = Me.Columns("Recibida")
			
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

			_fieldsCustomProperties.Add("Servicio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioDetalleSolicitud", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Indice", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantidadSolicitada", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantidadOrdenar", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Precio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SucursalId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ProveedorId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Scdescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ScidPlaza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Pldescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrRazSocial", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("RecibidaCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Recibida", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwCompReporteOrdenesServiciosRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwCompReporteOrdenesServiciosTypedView = CType(MyBase.Clone(), VwCompReporteOrdenesServiciosTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwCompReporteOrdenesServiciosTypedView()
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
				Return VwCompReporteOrdenesServiciosTypedView.CustomProperties
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
				Return VwCompReporteOrdenesServiciosTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwCompReporteOrdenesServiciosRow
			Get 
				Return CType(Me.Rows(index), VwCompReporteOrdenesServiciosRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Servicio
		''' </summary>
		ReadOnly Friend Property ServicioColumn As DataColumn
			Get 
				Return _columnServicio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioDetalleSolicitud
		''' </summary>
		ReadOnly Friend Property FolioDetalleSolicitudColumn As DataColumn
			Get 
				Return _columnFolioDetalleSolicitud 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Indice
		''' </summary>
		ReadOnly Friend Property IndiceColumn As DataColumn
			Get 
				Return _columnIndice 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantidadSolicitada
		''' </summary>
		ReadOnly Friend Property CantidadSolicitadaColumn As DataColumn
			Get 
				Return _columnCantidadSolicitada 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantidadOrdenar
		''' </summary>
		ReadOnly Friend Property CantidadOrdenarColumn As DataColumn
			Get 
				Return _columnCantidadOrdenar 
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
		''' Returns the column Object belonging to the TypedView field Iva
		''' </summary>
		ReadOnly Friend Property IvaColumn As DataColumn
			Get 
				Return _columnIva 
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
		''' Returns the column Object belonging to the TypedView field Folio
		''' </summary>
		ReadOnly Friend Property FolioColumn As DataColumn
			Get 
				Return _columnFolio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SucursalId
		''' </summary>
		ReadOnly Friend Property SucursalIdColumn As DataColumn
			Get 
				Return _columnSucursalId 
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
		''' Returns the column Object belonging to the TypedView field FechaAlta
		''' </summary>
		ReadOnly Friend Property FechaAltaColumn As DataColumn
			Get 
				Return _columnFechaAlta 
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
		''' Returns the column Object belonging to the TypedView field ScidPlaza
		''' </summary>
		ReadOnly Friend Property ScidPlazaColumn As DataColumn
			Get 
				Return _columnScidPlaza 
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
		''' Returns the column Object belonging to the TypedView field Estatus
		''' </summary>
		ReadOnly Friend Property EstatusColumn As DataColumn
			Get 
				Return _columnEstatus 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field RecibidaCad
		''' </summary>
		ReadOnly Friend Property RecibidaCadColumn As DataColumn
			Get 
				Return _columnRecibidaCad 
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
	''' Typed datarow for the typed datatable VwCompReporteOrdenesServicios
	''' </summary>
	Public Class VwCompReporteOrdenesServiciosRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwCompReporteOrdenesServiciosTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwCompReporteOrdenesServiciosTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field Servicio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."Servicio"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 500
		''' </remarks>
		Public Property [Servicio]() As System.String
			Get 
				If IsServicioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ServicioColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ServicioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Servicio is NULL, False otherwise.
		''' </summary>
		Public Function IsServicioNull() As Boolean
			Return IsNull(_parent.ServicioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Servicio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetServicioNull() 
			Me(_parent.ServicioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioDetalleSolicitud<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."FolioDetalleSolicitud"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 15
		''' </remarks>
		Public Property [FolioDetalleSolicitud]() As System.String
			Get 
				If IsFolioDetalleSolicitudNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioDetalleSolicitudColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioDetalleSolicitudColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioDetalleSolicitud is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioDetalleSolicitudNull() As Boolean
			Return IsNull(_parent.FolioDetalleSolicitudColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioDetalleSolicitud to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioDetalleSolicitudNull() 
			Me(_parent.FolioDetalleSolicitudColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Indice<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."Indice"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Indice]() As System.Int32
			Get 
				If IsIndiceNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IndiceColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IndiceColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Indice is NULL, False otherwise.
		''' </summary>
		Public Function IsIndiceNull() As Boolean
			Return IsNull(_parent.IndiceColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Indice to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIndiceNull() 
			Me(_parent.IndiceColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantidadSolicitada<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."CantidadSolicitada"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 18, 0, 0
		''' </remarks>
		Public Property [CantidadSolicitada]() As System.Decimal
			Get 
				If IsCantidadSolicitadaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantidadSolicitadaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantidadSolicitadaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantidadSolicitada is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadSolicitadaNull() As Boolean
			Return IsNull(_parent.CantidadSolicitadaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantidadSolicitada to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadSolicitadaNull() 
			Me(_parent.CantidadSolicitadaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantidadOrdenar<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."CantidadOrdenar"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 18, 0, 0
		''' </remarks>
		Public Property [CantidadOrdenar]() As System.Decimal
			Get 
				If IsCantidadOrdenarNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantidadOrdenarColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantidadOrdenarColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantidadOrdenar is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadOrdenarNull() As Boolean
			Return IsNull(_parent.CantidadOrdenarColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantidadOrdenar to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadOrdenarNull() 
			Me(_parent.CantidadOrdenarColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Precio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."Precio"<br/>
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
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."Descuento"<br/>
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
		''' Gets / sets the value of the TypedView field Iva<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."IVA"<br/>
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
		''' Gets / sets the value of the TypedView field Importe<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."Importe"<br/>
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
		''' Gets / sets the value of the TypedView field Folio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."Folio"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 15
		''' </remarks>
		Public Property [Folio]() As System.String
			Get 
				If IsFolioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Folio is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioNull() As Boolean
			Return IsNull(_parent.FolioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Folio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioNull() 
			Me(_parent.FolioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SucursalId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."SucursalId"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [SucursalId]() As System.Int32
			Get 
				If IsSucursalIdNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.SucursalIdColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.SucursalIdColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SucursalId is NULL, False otherwise.
		''' </summary>
		Public Function IsSucursalIdNull() As Boolean
			Return IsNull(_parent.SucursalIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SucursalId to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSucursalIdNull() 
			Me(_parent.SucursalIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ProveedorId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."ProveedorId"<br/>
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
		''' Gets / sets the value of the TypedView field FechaAlta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."FechaAlta"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaAlta]() As System.DateTime
			Get 
				If IsFechaAltaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaAltaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaAltaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaAlta is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaAltaNull() As Boolean
			Return IsNull(_parent.FechaAltaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaAlta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaAltaNull() 
			Me(_parent.FechaAltaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Scdescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."SCDescripcion"<br/>
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
		''' Gets / sets the value of the TypedView field ScidPlaza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."SCIdPlaza"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [ScidPlaza]() As System.Int32
			Get 
				If IsScidPlazaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.ScidPlazaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.ScidPlazaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ScidPlaza is NULL, False otherwise.
		''' </summary>
		Public Function IsScidPlazaNull() As Boolean
			Return IsNull(_parent.ScidPlazaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ScidPlaza to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetScidPlazaNull() 
			Me(_parent.ScidPlazaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Pldescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."PLDescripcion"<br/>
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
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."PrRazSocial"<br/>
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
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."Estatus"<br/>
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
		''' Gets / sets the value of the TypedView field RecibidaCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."RecibidaCad"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 15
		''' </remarks>
		Public Property [RecibidaCad]() As System.String
			Get 
				If IsRecibidaCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.RecibidaCadColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.RecibidaCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field RecibidaCad is NULL, False otherwise.
		''' </summary>
		Public Function IsRecibidaCadNull() As Boolean
			Return IsNull(_parent.RecibidaCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field RecibidaCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetRecibidaCadNull() 
			Me(_parent.RecibidaCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Recibida<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwCompReporteOrdenesServicios"."Recibida"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [Recibida]() As System.Int16
			Get 
				If IsRecibidaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.RecibidaColumn), System.Int16)
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

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
