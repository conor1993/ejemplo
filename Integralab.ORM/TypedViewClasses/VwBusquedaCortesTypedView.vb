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
	''' Typed datatable for the view 'VwBusquedaCortes'.<br/><br/>
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
	Public Class VwBusquedaCortesTypedView 
#Else
	Public Class VwBusquedaCortesTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnIdFolioEtiqueta As DataColumn
		Private _columnLoteCorte As DataColumn
		Private _columnIdAlmacen As DataColumn
		Private _columnAlmacen As DataColumn
		Private _columnTipoAlmacen As DataColumn
		Private _columnNomCorte As DataColumn
		Private _columnCodPreCorte As DataColumn
		Private _columnNomSubCorte As DataColumn
		Private _columnCodCorte As DataColumn
		Private _columnCantPzas As DataColumn
		Private _columnCantKgrs As DataColumn
		Private _columnFechaCorte As DataColumn
		Private _columnFechaCad As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnTotalPzas As DataColumn
		Private _columnTotalKgs As DataColumn
		Private _columnIdCorte As DataColumn
		Private _columnIdProducto As DataColumn
		Private _columnIdCliente As DataColumn
		Private _columnLoteSacrificio As DataColumn
		Private _columnGrados As DataColumn
		Private _columnIdFolioMovimiento As DataColumn
		Private _columnIdFolioEmbarque As DataColumn
		Private _columnIdClienteEmb As DataColumn
		Private _columnIdPuntoEntrega As DataColumn
		Private _columnIdChofer As DataColumn
		Private _columnFechaEmbarque As DataColumn
		Private _columnCodigoBarra As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 28
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
			MyBase.New("VwBusquedaCortes")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaCortesTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaCortesTypedView)
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
			Return New VwBusquedaCortesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnIdFolioEtiqueta = New DataColumn("IdFolioEtiqueta", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioEtiqueta.ReadOnly = True
			_columnIdFolioEtiqueta.Caption = "IdFolioEtiqueta"
			Me.Columns.Add(_columnIdFolioEtiqueta)

			_columnLoteCorte = New DataColumn("LoteCorte", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteCorte.ReadOnly = True
			_columnLoteCorte.Caption = "LoteCorte"
			Me.Columns.Add(_columnLoteCorte)

			_columnIdAlmacen = New DataColumn("IdAlmacen", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdAlmacen.ReadOnly = True
			_columnIdAlmacen.Caption = "IdAlmacen"
			Me.Columns.Add(_columnIdAlmacen)

			_columnAlmacen = New DataColumn("Almacen", GetType(System.String), Nothing, MappingType.Element)
			_columnAlmacen.ReadOnly = True
			_columnAlmacen.Caption = "Almacen"
			Me.Columns.Add(_columnAlmacen)

			_columnTipoAlmacen = New DataColumn("TipoAlmacen", GetType(System.Int16), Nothing, MappingType.Element)
			_columnTipoAlmacen.ReadOnly = True
			_columnTipoAlmacen.Caption = "TipoAlmacen"
			Me.Columns.Add(_columnTipoAlmacen)

			_columnNomCorte = New DataColumn("NomCorte", GetType(System.String), Nothing, MappingType.Element)
			_columnNomCorte.ReadOnly = True
			_columnNomCorte.Caption = "NomCorte"
			Me.Columns.Add(_columnNomCorte)

			_columnCodPreCorte = New DataColumn("CodPreCorte", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCodPreCorte.ReadOnly = True
			_columnCodPreCorte.Caption = "CodPreCorte"
			Me.Columns.Add(_columnCodPreCorte)

			_columnNomSubCorte = New DataColumn("NomSubCorte", GetType(System.String), Nothing, MappingType.Element)
			_columnNomSubCorte.ReadOnly = True
			_columnNomSubCorte.Caption = "NomSubCorte"
			Me.Columns.Add(_columnNomSubCorte)

			_columnCodCorte = New DataColumn("CodCorte", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCodCorte.ReadOnly = True
			_columnCodCorte.Caption = "CodCorte"
			Me.Columns.Add(_columnCodCorte)

			_columnCantPzas = New DataColumn("CantPzas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantPzas.ReadOnly = True
			_columnCantPzas.Caption = "CantPzas"
			Me.Columns.Add(_columnCantPzas)

			_columnCantKgrs = New DataColumn("CantKgrs", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantKgrs.ReadOnly = True
			_columnCantKgrs.Caption = "CantKgrs"
			Me.Columns.Add(_columnCantKgrs)

			_columnFechaCorte = New DataColumn("FechaCorte", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCorte.ReadOnly = True
			_columnFechaCorte.Caption = "FechaCorte"
			Me.Columns.Add(_columnFechaCorte)

			_columnFechaCad = New DataColumn("FechaCad", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCad.ReadOnly = True
			_columnFechaCad.Caption = "FechaCad"
			Me.Columns.Add(_columnFechaCad)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnTotalPzas = New DataColumn("TotalPzas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotalPzas.ReadOnly = True
			_columnTotalPzas.Caption = "TotalPzas"
			Me.Columns.Add(_columnTotalPzas)

			_columnTotalKgs = New DataColumn("TotalKgs", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotalKgs.ReadOnly = True
			_columnTotalKgs.Caption = "TotalKgs"
			Me.Columns.Add(_columnTotalKgs)

			_columnIdCorte = New DataColumn("IdCorte", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCorte.ReadOnly = True
			_columnIdCorte.Caption = "IdCorte"
			Me.Columns.Add(_columnIdCorte)

			_columnIdProducto = New DataColumn("IdProducto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProducto.ReadOnly = True
			_columnIdProducto.Caption = "IdProducto"
			Me.Columns.Add(_columnIdProducto)

			_columnIdCliente = New DataColumn("IdCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCliente.ReadOnly = True
			_columnIdCliente.Caption = "IdCliente"
			Me.Columns.Add(_columnIdCliente)

			_columnLoteSacrificio = New DataColumn("LoteSacrificio", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteSacrificio.ReadOnly = True
			_columnLoteSacrificio.Caption = "LoteSacrificio"
			Me.Columns.Add(_columnLoteSacrificio)

			_columnGrados = New DataColumn("Grados", GetType(System.Int32), Nothing, MappingType.Element)
			_columnGrados.ReadOnly = True
			_columnGrados.Caption = "Grados"
			Me.Columns.Add(_columnGrados)

			_columnIdFolioMovimiento = New DataColumn("IdFolioMovimiento", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioMovimiento.ReadOnly = True
			_columnIdFolioMovimiento.Caption = "IdFolioMovimiento"
			Me.Columns.Add(_columnIdFolioMovimiento)

			_columnIdFolioEmbarque = New DataColumn("IdFolioEmbarque", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioEmbarque.ReadOnly = True
			_columnIdFolioEmbarque.Caption = "IdFolioEmbarque"
			Me.Columns.Add(_columnIdFolioEmbarque)

			_columnIdClienteEmb = New DataColumn("IdClienteEmb", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdClienteEmb.ReadOnly = True
			_columnIdClienteEmb.Caption = "IdClienteEmb"
			Me.Columns.Add(_columnIdClienteEmb)

			_columnIdPuntoEntrega = New DataColumn("IdPuntoEntrega", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdPuntoEntrega.ReadOnly = True
			_columnIdPuntoEntrega.Caption = "IdPuntoEntrega"
			Me.Columns.Add(_columnIdPuntoEntrega)

			_columnIdChofer = New DataColumn("IdChofer", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdChofer.ReadOnly = True
			_columnIdChofer.Caption = "IdChofer"
			Me.Columns.Add(_columnIdChofer)

			_columnFechaEmbarque = New DataColumn("FechaEmbarque", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaEmbarque.ReadOnly = True
			_columnFechaEmbarque.Caption = "FechaEmbarque"
			Me.Columns.Add(_columnFechaEmbarque)

			_columnCodigoBarra = New DataColumn("CodigoBarra", GetType(System.String), Nothing, MappingType.Element)
			_columnCodigoBarra.ReadOnly = True
			_columnCodigoBarra.Caption = "CodigoBarra"
			Me.Columns.Add(_columnCodigoBarra)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnIdFolioEtiqueta = Me.Columns("IdFolioEtiqueta")
			_columnLoteCorte = Me.Columns("LoteCorte")
			_columnIdAlmacen = Me.Columns("IdAlmacen")
			_columnAlmacen = Me.Columns("Almacen")
			_columnTipoAlmacen = Me.Columns("TipoAlmacen")
			_columnNomCorte = Me.Columns("NomCorte")
			_columnCodPreCorte = Me.Columns("CodPreCorte")
			_columnNomSubCorte = Me.Columns("NomSubCorte")
			_columnCodCorte = Me.Columns("CodCorte")
			_columnCantPzas = Me.Columns("CantPzas")
			_columnCantKgrs = Me.Columns("CantKgrs")
			_columnFechaCorte = Me.Columns("FechaCorte")
			_columnFechaCad = Me.Columns("FechaCad")
			_columnEstatus = Me.Columns("Estatus")
			_columnTotalPzas = Me.Columns("TotalPzas")
			_columnTotalKgs = Me.Columns("TotalKgs")
			_columnIdCorte = Me.Columns("IdCorte")
			_columnIdProducto = Me.Columns("IdProducto")
			_columnIdCliente = Me.Columns("IdCliente")
			_columnLoteSacrificio = Me.Columns("LoteSacrificio")
			_columnGrados = Me.Columns("Grados")
			_columnIdFolioMovimiento = Me.Columns("IdFolioMovimiento")
			_columnIdFolioEmbarque = Me.Columns("IdFolioEmbarque")
			_columnIdClienteEmb = Me.Columns("IdClienteEmb")
			_columnIdPuntoEntrega = Me.Columns("IdPuntoEntrega")
			_columnIdChofer = Me.Columns("IdChofer")
			_columnFechaEmbarque = Me.Columns("FechaEmbarque")
			_columnCodigoBarra = Me.Columns("CodigoBarra")
			
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

			_fieldsCustomProperties.Add("IdFolioEtiqueta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("LoteCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdAlmacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Almacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoAlmacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NomCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CodPreCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NomSubCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CodCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantPzas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantKgrs", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalPzas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalKgs", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("LoteSacrificio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Grados", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioEmbarque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdClienteEmb", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdPuntoEntrega", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdChofer", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaEmbarque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CodigoBarra", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaCortesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaCortesTypedView = CType(MyBase.Clone(), VwBusquedaCortesTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaCortesTypedView()
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
				Return VwBusquedaCortesTypedView.CustomProperties
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
				Return VwBusquedaCortesTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaCortesRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaCortesRow)
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
		''' Returns the column Object belonging to the TypedView field LoteCorte
		''' </summary>
		ReadOnly Friend Property LoteCorteColumn As DataColumn
			Get 
				Return _columnLoteCorte 
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
		''' Returns the column Object belonging to the TypedView field TipoAlmacen
		''' </summary>
		ReadOnly Friend Property TipoAlmacenColumn As DataColumn
			Get 
				Return _columnTipoAlmacen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field NomCorte
		''' </summary>
		ReadOnly Friend Property NomCorteColumn As DataColumn
			Get 
				Return _columnNomCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CodPreCorte
		''' </summary>
		ReadOnly Friend Property CodPreCorteColumn As DataColumn
			Get 
				Return _columnCodPreCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field NomSubCorte
		''' </summary>
		ReadOnly Friend Property NomSubCorteColumn As DataColumn
			Get 
				Return _columnNomSubCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CodCorte
		''' </summary>
		ReadOnly Friend Property CodCorteColumn As DataColumn
			Get 
				Return _columnCodCorte 
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
		''' Returns the column Object belonging to the TypedView field FechaCorte
		''' </summary>
		ReadOnly Friend Property FechaCorteColumn As DataColumn
			Get 
				Return _columnFechaCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaCad
		''' </summary>
		ReadOnly Friend Property FechaCadColumn As DataColumn
			Get 
				Return _columnFechaCad 
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
		''' Returns the column Object belonging to the TypedView field TotalPzas
		''' </summary>
		ReadOnly Friend Property TotalPzasColumn As DataColumn
			Get 
				Return _columnTotalPzas 
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
		''' Returns the column Object belonging to the TypedView field IdCorte
		''' </summary>
		ReadOnly Friend Property IdCorteColumn As DataColumn
			Get 
				Return _columnIdCorte 
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
		''' Returns the column Object belonging to the TypedView field IdCliente
		''' </summary>
		ReadOnly Friend Property IdClienteColumn As DataColumn
			Get 
				Return _columnIdCliente 
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
		''' Returns the column Object belonging to the TypedView field Grados
		''' </summary>
		ReadOnly Friend Property GradosColumn As DataColumn
			Get 
				Return _columnGrados 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioMovimiento
		''' </summary>
		ReadOnly Friend Property IdFolioMovimientoColumn As DataColumn
			Get 
				Return _columnIdFolioMovimiento 
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
		''' Returns the column Object belonging to the TypedView field IdClienteEmb
		''' </summary>
		ReadOnly Friend Property IdClienteEmbColumn As DataColumn
			Get 
				Return _columnIdClienteEmb 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdPuntoEntrega
		''' </summary>
		ReadOnly Friend Property IdPuntoEntregaColumn As DataColumn
			Get 
				Return _columnIdPuntoEntrega 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdChofer
		''' </summary>
		ReadOnly Friend Property IdChoferColumn As DataColumn
			Get 
				Return _columnIdChofer 
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
		''' Returns the column Object belonging to the TypedView field CodigoBarra
		''' </summary>
		ReadOnly Friend Property CodigoBarraColumn As DataColumn
			Get 
				Return _columnCodigoBarra 
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
	''' Typed datarow for the typed datatable VwBusquedaCortes
	''' </summary>
	Public Class VwBusquedaCortesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaCortesTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaCortesTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioEtiqueta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdFolioEtiqueta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 14
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
		''' Gets / sets the value of the TypedView field LoteCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."LoteCorte"<br/>
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
		''' Gets / sets the value of the TypedView field IdAlmacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdAlmacen"<br/>
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
		''' Mapped on view field: "VwBusquedaCortes"."Almacen"<br/>
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
		''' Gets / sets the value of the TypedView field TipoAlmacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."TipoAlmacen"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [TipoAlmacen]() As System.Int16
			Get 
				If IsTipoAlmacenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.TipoAlmacenColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.TipoAlmacenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoAlmacen is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoAlmacenNull() As Boolean
			Return IsNull(_parent.TipoAlmacenColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoAlmacen to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoAlmacenNull() 
			Me(_parent.TipoAlmacenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field NomCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."Nom_Corte"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [NomCorte]() As System.String
			Get 
				If IsNomCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NomCorteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NomCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NomCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsNomCorteNull() As Boolean
			Return IsNull(_parent.NomCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NomCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNomCorteNull() 
			Me(_parent.NomCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CodPreCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."Cod_PreCorte"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CodPreCorte]() As System.Int32
			Get 
				If IsCodPreCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CodPreCorteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CodPreCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CodPreCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsCodPreCorteNull() As Boolean
			Return IsNull(_parent.CodPreCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CodPreCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodPreCorteNull() 
			Me(_parent.CodPreCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field NomSubCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."Nom_SubCorte"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [NomSubCorte]() As System.String
			Get 
				If IsNomSubCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NomSubCorteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NomSubCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NomSubCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsNomSubCorteNull() As Boolean
			Return IsNull(_parent.NomSubCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NomSubCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNomSubCorteNull() 
			Me(_parent.NomSubCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CodCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."Cod_Corte"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CodCorte]() As System.Int32
			Get 
				If IsCodCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CodCorteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CodCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CodCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsCodCorteNull() As Boolean
			Return IsNull(_parent.CodCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CodCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodCorteNull() 
			Me(_parent.CodCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantPzas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."CantPzas"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CantPzas]() As System.Decimal
			Get 
				If IsCantPzasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantPzasColumn), System.Decimal)
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
		''' Mapped on view field: "VwBusquedaCortes"."CantKgrs"<br/>
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
		''' Gets / sets the value of the TypedView field FechaCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."FechaCorte"<br/>
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
		''' Gets / sets the value of the TypedView field FechaCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."FechaCad"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaCad]() As System.DateTime
			Get 
				If IsFechaCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaCadColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaCad is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaCadNull() As Boolean
			Return IsNull(_parent.FechaCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaCadNull() 
			Me(_parent.FechaCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."Estatus"<br/>
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

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TotalPzas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."TotalPzas"<br/>
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
		''' Gets / sets the value of the TypedView field TotalKgs<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."TotalKgs"<br/>
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
		''' Gets / sets the value of the TypedView field IdCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdCorte"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdCorte]() As System.Int32
			Get 
				If IsIdCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdCorteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsIdCorteNull() As Boolean
			Return IsNull(_parent.IdCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdCorteNull() 
			Me(_parent.IdCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdProducto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdProducto"<br/>
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
		''' Gets / sets the value of the TypedView field IdCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdCliente"<br/>
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
		''' Gets / sets the value of the TypedView field LoteSacrificio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."LoteSacrificio"<br/>
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
		''' Gets / sets the value of the TypedView field Grados<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."Grados"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Grados]() As System.Int32
			Get 
				If IsGradosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.GradosColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.GradosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Grados is NULL, False otherwise.
		''' </summary>
		Public Function IsGradosNull() As Boolean
			Return IsNull(_parent.GradosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Grados to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetGradosNull() 
			Me(_parent.GradosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdFolioMovimiento"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 12
		''' </remarks>
		Public Property [IdFolioMovimiento]() As System.String
			Get 
				If IsIdFolioMovimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioMovimientoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioMovimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioMovimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioMovimientoNull() As Boolean
			Return IsNull(_parent.IdFolioMovimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioMovimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioMovimientoNull() 
			Me(_parent.IdFolioMovimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioEmbarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdFolioEmbarque"<br/>
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
		''' Gets / sets the value of the TypedView field IdClienteEmb<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdClienteEmb"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdClienteEmb]() As System.Int32
			Get 
				If IsIdClienteEmbNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdClienteEmbColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdClienteEmbColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdClienteEmb is NULL, False otherwise.
		''' </summary>
		Public Function IsIdClienteEmbNull() As Boolean
			Return IsNull(_parent.IdClienteEmbColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdClienteEmb to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdClienteEmbNull() 
			Me(_parent.IdClienteEmbColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdPuntoEntrega<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdPuntoEntrega"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdPuntoEntrega]() As System.Int32
			Get 
				If IsIdPuntoEntregaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdPuntoEntregaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdPuntoEntregaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdPuntoEntrega is NULL, False otherwise.
		''' </summary>
		Public Function IsIdPuntoEntregaNull() As Boolean
			Return IsNull(_parent.IdPuntoEntregaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdPuntoEntrega to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdPuntoEntregaNull() 
			Me(_parent.IdPuntoEntregaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdChofer<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."IdChofer"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdChofer]() As System.Int32
			Get 
				If IsIdChoferNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdChoferColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdChoferColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdChofer is NULL, False otherwise.
		''' </summary>
		Public Function IsIdChoferNull() As Boolean
			Return IsNull(_parent.IdChoferColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdChofer to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdChoferNull() 
			Me(_parent.IdChoferColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaEmbarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."FechaEmbarque"<br/>
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
		''' Gets / sets the value of the TypedView field CodigoBarra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaCortes"."CodigoBarra"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [CodigoBarra]() As System.String
			Get 
				If IsCodigoBarraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CodigoBarraColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CodigoBarraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CodigoBarra is NULL, False otherwise.
		''' </summary>
		Public Function IsCodigoBarraNull() As Boolean
			Return IsNull(_parent.CodigoBarraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CodigoBarra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodigoBarraNull() 
			Me(_parent.CodigoBarraColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
