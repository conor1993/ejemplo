' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 23 de abril de 2018 15:22:03
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
	''' Typed datatable for the view 'VwReportedeEmabarquesDetallado'.<br/><br/>
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
	Public Class VwReportedeEmabarquesDetalladoTypedView 
#Else
	Public Class VwReportedeEmabarquesDetalladoTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnIdFolioEmbarque As DataColumn
		Private _columnFechaEmbarque As DataColumn
		Private _columnIdCliente As DataColumn
		Private _columnNombre As DataColumn
		Private _columnVehiculo As DataColumn
		Private _columnChofer As DataColumn
		Private _columnTotalPiezas As DataColumn
		Private _columnTotalKgrs As DataColumn
		Private _columnTotalCajas As DataColumn
		Private _columnEstado As DataColumn
		Private _columnCiudad As DataColumn
		Private _columnPoblacion As DataColumn
		Private _columnDireccion As DataColumn
		Private _columnDescripcion As DataColumn
		Private _columnColonia As DataColumn
		Private _columnTelefono As DataColumn
		Private _columnCodigoPostal As DataColumn
		Private _columnIdFolioEtiqueta As DataColumn
		Private _columnIdProducto As DataColumn
		Private _columnProducto As DataColumn
		Private _columnCantPzas As DataColumn
		Private _columnCantKgrs As DataColumn
		Private _columnFolioEmbarqueEmp As DataColumn
		Private _columnLoteCorte As DataColumn
		Private _columnFechaCorte As DataColumn
		Private _columnPrecioxKgr As DataColumn
		Private _columnImporteCaja As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 27
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
			MyBase.New("VwReportedeEmabarquesDetallado")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwReportedeEmabarquesDetalladoTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwReportedeEmabarquesDetalladoTypedView)
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
			Return New VwReportedeEmabarquesDetalladoRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnIdFolioEmbarque = New DataColumn("IdFolioEmbarque", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioEmbarque.ReadOnly = True
			_columnIdFolioEmbarque.Caption = "IdFolioEmbarque"
			Me.Columns.Add(_columnIdFolioEmbarque)

			_columnFechaEmbarque = New DataColumn("FechaEmbarque", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaEmbarque.ReadOnly = True
			_columnFechaEmbarque.Caption = "FechaEmbarque"
			Me.Columns.Add(_columnFechaEmbarque)

			_columnIdCliente = New DataColumn("IdCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCliente.ReadOnly = True
			_columnIdCliente.Caption = "IdCliente"
			Me.Columns.Add(_columnIdCliente)

			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnVehiculo = New DataColumn("Vehiculo", GetType(System.String), Nothing, MappingType.Element)
			_columnVehiculo.ReadOnly = True
			_columnVehiculo.Caption = "Vehiculo"
			Me.Columns.Add(_columnVehiculo)

			_columnChofer = New DataColumn("Chofer", GetType(System.String), Nothing, MappingType.Element)
			_columnChofer.ReadOnly = True
			_columnChofer.Caption = "Chofer"
			Me.Columns.Add(_columnChofer)

			_columnTotalPiezas = New DataColumn("TotalPiezas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnTotalPiezas.ReadOnly = True
			_columnTotalPiezas.Caption = "TotalPiezas"
			Me.Columns.Add(_columnTotalPiezas)

			_columnTotalKgrs = New DataColumn("TotalKgrs", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotalKgrs.ReadOnly = True
			_columnTotalKgrs.Caption = "TotalKgrs"
			Me.Columns.Add(_columnTotalKgrs)

			_columnTotalCajas = New DataColumn("TotalCajas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnTotalCajas.ReadOnly = True
			_columnTotalCajas.Caption = "TotalCajas"
			Me.Columns.Add(_columnTotalCajas)

			_columnEstado = New DataColumn("Estado", GetType(System.String), Nothing, MappingType.Element)
			_columnEstado.ReadOnly = True
			_columnEstado.Caption = "Estado"
			Me.Columns.Add(_columnEstado)

			_columnCiudad = New DataColumn("Ciudad", GetType(System.String), Nothing, MappingType.Element)
			_columnCiudad.ReadOnly = True
			_columnCiudad.Caption = "Ciudad"
			Me.Columns.Add(_columnCiudad)

			_columnPoblacion = New DataColumn("Poblacion", GetType(System.String), Nothing, MappingType.Element)
			_columnPoblacion.ReadOnly = True
			_columnPoblacion.Caption = "Poblacion"
			Me.Columns.Add(_columnPoblacion)

			_columnDireccion = New DataColumn("Direccion", GetType(System.String), Nothing, MappingType.Element)
			_columnDireccion.ReadOnly = True
			_columnDireccion.Caption = "Direccion"
			Me.Columns.Add(_columnDireccion)

			_columnDescripcion = New DataColumn("Descripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnDescripcion.ReadOnly = True
			_columnDescripcion.Caption = "Descripcion"
			Me.Columns.Add(_columnDescripcion)

			_columnColonia = New DataColumn("Colonia", GetType(System.String), Nothing, MappingType.Element)
			_columnColonia.ReadOnly = True
			_columnColonia.Caption = "Colonia"
			Me.Columns.Add(_columnColonia)

			_columnTelefono = New DataColumn("Telefono", GetType(System.String), Nothing, MappingType.Element)
			_columnTelefono.ReadOnly = True
			_columnTelefono.Caption = "Telefono"
			Me.Columns.Add(_columnTelefono)

			_columnCodigoPostal = New DataColumn("CodigoPostal", GetType(System.String), Nothing, MappingType.Element)
			_columnCodigoPostal.ReadOnly = True
			_columnCodigoPostal.Caption = "CodigoPostal"
			Me.Columns.Add(_columnCodigoPostal)

			_columnIdFolioEtiqueta = New DataColumn("IdFolioEtiqueta", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioEtiqueta.ReadOnly = True
			_columnIdFolioEtiqueta.Caption = "IdFolioEtiqueta"
			Me.Columns.Add(_columnIdFolioEtiqueta)

			_columnIdProducto = New DataColumn("IdProducto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProducto.ReadOnly = True
			_columnIdProducto.Caption = "IdProducto"
			Me.Columns.Add(_columnIdProducto)

			_columnProducto = New DataColumn("Producto", GetType(System.String), Nothing, MappingType.Element)
			_columnProducto.ReadOnly = True
			_columnProducto.Caption = "Producto"
			Me.Columns.Add(_columnProducto)

			_columnCantPzas = New DataColumn("CantPzas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCantPzas.ReadOnly = True
			_columnCantPzas.Caption = "CantPzas"
			Me.Columns.Add(_columnCantPzas)

			_columnCantKgrs = New DataColumn("CantKgrs", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantKgrs.ReadOnly = True
			_columnCantKgrs.Caption = "CantKgrs"
			Me.Columns.Add(_columnCantKgrs)

			_columnFolioEmbarqueEmp = New DataColumn("FolioEmbarqueEmp", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioEmbarqueEmp.ReadOnly = True
			_columnFolioEmbarqueEmp.Caption = "FolioEmbarqueEmp"
			Me.Columns.Add(_columnFolioEmbarqueEmp)

			_columnLoteCorte = New DataColumn("LoteCorte", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteCorte.ReadOnly = True
			_columnLoteCorte.Caption = "LoteCorte"
			Me.Columns.Add(_columnLoteCorte)

			_columnFechaCorte = New DataColumn("FechaCorte", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCorte.ReadOnly = True
			_columnFechaCorte.Caption = "FechaCorte"
			Me.Columns.Add(_columnFechaCorte)

			_columnPrecioxKgr = New DataColumn("PrecioxKgr", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPrecioxKgr.ReadOnly = True
			_columnPrecioxKgr.Caption = "PrecioxKgr"
			Me.Columns.Add(_columnPrecioxKgr)

			_columnImporteCaja = New DataColumn("ImporteCaja", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporteCaja.ReadOnly = True
			_columnImporteCaja.Caption = "ImporteCaja"
			Me.Columns.Add(_columnImporteCaja)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnIdFolioEmbarque = Me.Columns("IdFolioEmbarque")
			_columnFechaEmbarque = Me.Columns("FechaEmbarque")
			_columnIdCliente = Me.Columns("IdCliente")
			_columnNombre = Me.Columns("Nombre")
			_columnVehiculo = Me.Columns("Vehiculo")
			_columnChofer = Me.Columns("Chofer")
			_columnTotalPiezas = Me.Columns("TotalPiezas")
			_columnTotalKgrs = Me.Columns("TotalKgrs")
			_columnTotalCajas = Me.Columns("TotalCajas")
			_columnEstado = Me.Columns("Estado")
			_columnCiudad = Me.Columns("Ciudad")
			_columnPoblacion = Me.Columns("Poblacion")
			_columnDireccion = Me.Columns("Direccion")
			_columnDescripcion = Me.Columns("Descripcion")
			_columnColonia = Me.Columns("Colonia")
			_columnTelefono = Me.Columns("Telefono")
			_columnCodigoPostal = Me.Columns("CodigoPostal")
			_columnIdFolioEtiqueta = Me.Columns("IdFolioEtiqueta")
			_columnIdProducto = Me.Columns("IdProducto")
			_columnProducto = Me.Columns("Producto")
			_columnCantPzas = Me.Columns("CantPzas")
			_columnCantKgrs = Me.Columns("CantKgrs")
			_columnFolioEmbarqueEmp = Me.Columns("FolioEmbarqueEmp")
			_columnLoteCorte = Me.Columns("LoteCorte")
			_columnFechaCorte = Me.Columns("FechaCorte")
			_columnPrecioxKgr = Me.Columns("PrecioxKgr")
			_columnImporteCaja = Me.Columns("ImporteCaja")
			
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

			_fieldsCustomProperties.Add("IdFolioEmbarque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaEmbarque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Vehiculo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Chofer", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalPiezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalKgrs", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalCajas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Ciudad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Poblacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Direccion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Colonia", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Telefono", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CodigoPostal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioEtiqueta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Producto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantPzas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantKgrs", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioEmbarqueEmp", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("LoteCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrecioxKgr", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImporteCaja", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwReportedeEmabarquesDetalladoRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwReportedeEmabarquesDetalladoTypedView = CType(MyBase.Clone(), VwReportedeEmabarquesDetalladoTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwReportedeEmabarquesDetalladoTypedView()
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
				Return VwReportedeEmabarquesDetalladoTypedView.CustomProperties
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
				Return VwReportedeEmabarquesDetalladoTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwReportedeEmabarquesDetalladoRow
			Get 
				Return CType(Me.Rows(index), VwReportedeEmabarquesDetalladoRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioEmbarque
		''' </summary>
		ReadOnly Friend Property IdFolioEmbarqueColumn As DataColumn
			Get 
				Return _columnIdFolioEmbarque 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaEmbarque
		''' </summary>
		ReadOnly Friend Property FechaEmbarqueColumn As DataColumn
			Get 
				Return _columnFechaEmbarque 
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
		''' Returns the column Object belonging to the TypedView field Nombre
		''' </summary>
		ReadOnly Friend Property NombreColumn As DataColumn
			Get 
				Return _columnNombre 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Vehiculo
		''' </summary>
		ReadOnly Friend Property VehiculoColumn As DataColumn
			Get 
				Return _columnVehiculo 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Chofer
		''' </summary>
		ReadOnly Friend Property ChoferColumn As DataColumn
			Get 
				Return _columnChofer 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TotalPiezas
		''' </summary>
		ReadOnly Friend Property TotalPiezasColumn As DataColumn
			Get 
				Return _columnTotalPiezas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TotalKgrs
		''' </summary>
		ReadOnly Friend Property TotalKgrsColumn As DataColumn
			Get 
				Return _columnTotalKgrs 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TotalCajas
		''' </summary>
		ReadOnly Friend Property TotalCajasColumn As DataColumn
			Get 
				Return _columnTotalCajas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Estado
		''' </summary>
		ReadOnly Friend Property EstadoColumn As DataColumn
			Get 
				Return _columnEstado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Ciudad
		''' </summary>
		ReadOnly Friend Property CiudadColumn As DataColumn
			Get 
				Return _columnCiudad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Poblacion
		''' </summary>
		ReadOnly Friend Property PoblacionColumn As DataColumn
			Get 
				Return _columnPoblacion 
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
		''' Returns the column Object belonging to the TypedView field Descripcion
		''' </summary>
		ReadOnly Friend Property DescripcionColumn As DataColumn
			Get 
				Return _columnDescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Colonia
		''' </summary>
		ReadOnly Friend Property ColoniaColumn As DataColumn
			Get 
				Return _columnColonia 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Telefono
		''' </summary>
		ReadOnly Friend Property TelefonoColumn As DataColumn
			Get 
				Return _columnTelefono 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CodigoPostal
		''' </summary>
		ReadOnly Friend Property CodigoPostalColumn As DataColumn
			Get 
				Return _columnCodigoPostal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioEtiqueta
		''' </summary>
		ReadOnly Friend Property IdFolioEtiquetaColumn As DataColumn
			Get 
				Return _columnIdFolioEtiqueta 
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
		''' Returns the column Object belonging to the TypedView field Producto
		''' </summary>
		ReadOnly Friend Property ProductoColumn As DataColumn
			Get 
				Return _columnProducto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantPzas
		''' </summary>
		ReadOnly Friend Property CantPzasColumn As DataColumn
			Get 
				Return _columnCantPzas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantKgrs
		''' </summary>
		ReadOnly Friend Property CantKgrsColumn As DataColumn
			Get 
				Return _columnCantKgrs 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioEmbarqueEmp
		''' </summary>
		ReadOnly Friend Property FolioEmbarqueEmpColumn As DataColumn
			Get 
				Return _columnFolioEmbarqueEmp 
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
		''' Returns the column Object belonging to the TypedView field FechaCorte
		''' </summary>
		ReadOnly Friend Property FechaCorteColumn As DataColumn
			Get 
				Return _columnFechaCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrecioxKgr
		''' </summary>
		ReadOnly Friend Property PrecioxKgrColumn As DataColumn
			Get 
				Return _columnPrecioxKgr 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImporteCaja
		''' </summary>
		ReadOnly Friend Property ImporteCajaColumn As DataColumn
			Get 
				Return _columnImporteCaja 
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
	''' Typed datarow for the typed datatable VwReportedeEmabarquesDetallado
	''' </summary>
	Public Class VwReportedeEmabarquesDetalladoRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwReportedeEmabarquesDetalladoTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwReportedeEmabarquesDetalladoTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioEmbarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."IdFolioEmbarque"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [IdFolioEmbarque]() As System.String
			Get 
				If IsIdFolioEmbarqueNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioEmbarqueColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioEmbarqueColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioEmbarque is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioEmbarqueNull() As Boolean
			Return IsNull(_parent.IdFolioEmbarqueColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioEmbarque to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioEmbarqueNull() 
			Me(_parent.IdFolioEmbarqueColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaEmbarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."FechaEmbarque"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaEmbarque]() As System.DateTime
			Get 
				If IsFechaEmbarqueNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaEmbarqueColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaEmbarqueColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaEmbarque is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaEmbarqueNull() As Boolean
			Return IsNull(_parent.FechaEmbarqueColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaEmbarque to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaEmbarqueNull() 
			Me(_parent.FechaEmbarqueColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."IdCliente"<br/>
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
		''' Gets / sets the value of the TypedView field Nombre<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Nombre"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 173
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
		''' Gets / sets the value of the TypedView field Vehiculo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Vehiculo"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Vehiculo]() As System.String
			Get 
				If IsVehiculoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.VehiculoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.VehiculoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Vehiculo is NULL, False otherwise.
		''' </summary>
		Public Function IsVehiculoNull() As Boolean
			Return IsNull(_parent.VehiculoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Vehiculo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetVehiculoNull() 
			Me(_parent.VehiculoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Chofer<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Chofer"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Chofer]() As System.String
			Get 
				If IsChoferNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ChoferColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ChoferColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Chofer is NULL, False otherwise.
		''' </summary>
		Public Function IsChoferNull() As Boolean
			Return IsNull(_parent.ChoferColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Chofer to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetChoferNull() 
			Me(_parent.ChoferColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TotalPiezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."TotalPiezas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [TotalPiezas]() As System.Int32
			Get 
				If IsTotalPiezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.TotalPiezasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.TotalPiezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalPiezas is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalPiezasNull() As Boolean
			Return IsNull(_parent.TotalPiezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalPiezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalPiezasNull() 
			Me(_parent.TotalPiezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TotalKgrs<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."TotalKgrs"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [TotalKgrs]() As System.Decimal
			Get 
				If IsTotalKgrsNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TotalKgrsColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TotalKgrsColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalKgrs is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalKgrsNull() As Boolean
			Return IsNull(_parent.TotalKgrsColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalKgrs to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalKgrsNull() 
			Me(_parent.TotalKgrsColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TotalCajas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."TotalCajas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [TotalCajas]() As System.Int32
			Get 
				If IsTotalCajasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.TotalCajasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.TotalCajasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalCajas is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalCajasNull() As Boolean
			Return IsNull(_parent.TotalCajasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalCajas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalCajasNull() 
			Me(_parent.TotalCajasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Estado"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 80
		''' </remarks>
		Public Property [Estado]() As System.String
			Get 
				If IsEstadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EstadoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EstadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Estado is NULL, False otherwise.
		''' </summary>
		Public Function IsEstadoNull() As Boolean
			Return IsNull(_parent.EstadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Estado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstadoNull() 
			Me(_parent.EstadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Ciudad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Ciudad"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 80
		''' </remarks>
		Public Property [Ciudad]() As System.String
			Get 
				If IsCiudadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CiudadColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CiudadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Ciudad is NULL, False otherwise.
		''' </summary>
		Public Function IsCiudadNull() As Boolean
			Return IsNull(_parent.CiudadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Ciudad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCiudadNull() 
			Me(_parent.CiudadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Poblacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Poblacion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 80
		''' </remarks>
		Public Property [Poblacion]() As System.String
			Get 
				If IsPoblacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PoblacionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PoblacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Poblacion is NULL, False otherwise.
		''' </summary>
		Public Function IsPoblacionNull() As Boolean
			Return IsNull(_parent.PoblacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Poblacion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPoblacionNull() 
			Me(_parent.PoblacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Direccion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Direccion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
		''' </remarks>
		Public Property [Direccion]() As System.String
			Get 
				If IsDireccionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.DireccionColumn), System.String)
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
		''' Gets / sets the value of the TypedView field Descripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Descripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
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
		''' Gets / sets the value of the TypedView field Colonia<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Colonia"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 120
		''' </remarks>
		Public Property [Colonia]() As System.String
			Get 
				If IsColoniaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ColoniaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ColoniaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Colonia is NULL, False otherwise.
		''' </summary>
		Public Function IsColoniaNull() As Boolean
			Return IsNull(_parent.ColoniaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Colonia to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetColoniaNull() 
			Me(_parent.ColoniaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Telefono<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Telefono"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [Telefono]() As System.String
			Get 
				If IsTelefonoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TelefonoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TelefonoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Telefono is NULL, False otherwise.
		''' </summary>
		Public Function IsTelefonoNull() As Boolean
			Return IsNull(_parent.TelefonoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Telefono to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTelefonoNull() 
			Me(_parent.TelefonoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CodigoPostal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."CodigoPostal"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 10
		''' </remarks>
		Public Property [CodigoPostal]() As System.String
			Get 
				If IsCodigoPostalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CodigoPostalColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CodigoPostalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CodigoPostal is NULL, False otherwise.
		''' </summary>
		Public Function IsCodigoPostalNull() As Boolean
			Return IsNull(_parent.CodigoPostalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CodigoPostal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodigoPostalNull() 
			Me(_parent.CodigoPostalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioEtiqueta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."IdFolioEtiqueta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 20
		''' </remarks>
		Public Property [IdFolioEtiqueta]() As System.String
			Get 
				If IsIdFolioEtiquetaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioEtiquetaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioEtiquetaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioEtiqueta is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioEtiquetaNull() As Boolean
			Return IsNull(_parent.IdFolioEtiquetaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioEtiqueta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioEtiquetaNull() 
			Me(_parent.IdFolioEtiquetaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdProducto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."IdProducto"<br/>
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
		''' Gets / sets the value of the TypedView field Producto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."Producto"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Producto]() As System.String
			Get 
				If IsProductoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ProductoColumn), System.String)
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
		''' Gets / sets the value of the TypedView field CantPzas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."CantPzas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CantPzas]() As System.Int32
			Get 
				If IsCantPzasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CantPzasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CantPzasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantPzas is NULL, False otherwise.
		''' </summary>
		Public Function IsCantPzasNull() As Boolean
			Return IsNull(_parent.CantPzasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantPzas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantPzasNull() 
			Me(_parent.CantPzasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantKgrs<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."CantKgrs"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CantKgrs]() As System.Decimal
			Get 
				If IsCantKgrsNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantKgrsColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantKgrsColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantKgrs is NULL, False otherwise.
		''' </summary>
		Public Function IsCantKgrsNull() As Boolean
			Return IsNull(_parent.CantKgrsColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantKgrs to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantKgrsNull() 
			Me(_parent.CantKgrsColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioEmbarqueEmp<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."FolioEmbarqueEmp"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [FolioEmbarqueEmp]() As System.String
			Get 
				If IsFolioEmbarqueEmpNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioEmbarqueEmpColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioEmbarqueEmpColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioEmbarqueEmp is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioEmbarqueEmpNull() As Boolean
			Return IsNull(_parent.FolioEmbarqueEmpColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioEmbarqueEmp to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioEmbarqueEmpNull() 
			Me(_parent.FolioEmbarqueEmpColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field LoteCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."LoteCorte"<br/>
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
		''' Gets / sets the value of the TypedView field FechaCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."FechaCorte"<br/>
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
		''' Gets / sets the value of the TypedView field PrecioxKgr<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."PrecioxKgr"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [PrecioxKgr]() As System.Decimal
			Get 
				If IsPrecioxKgrNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PrecioxKgrColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PrecioxKgrColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrecioxKgr is NULL, False otherwise.
		''' </summary>
		Public Function IsPrecioxKgrNull() As Boolean
			Return IsNull(_parent.PrecioxKgrColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrecioxKgr to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrecioxKgrNull() 
			Me(_parent.PrecioxKgrColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImporteCaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReportedeEmabarquesDetallado"."ImporteCaja"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [ImporteCaja]() As System.Decimal
			Get 
				If IsImporteCajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteCajaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteCajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImporteCaja is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteCajaNull() As Boolean
			Return IsNull(_parent.ImporteCajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImporteCaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteCajaNull() 
			Me(_parent.ImporteCajaColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
