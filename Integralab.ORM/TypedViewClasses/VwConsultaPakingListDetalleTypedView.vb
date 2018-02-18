' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 11:55:47
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
	''' Typed datatable for the view 'VwConsultaPakingListDetalle'.<br/><br/>
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
	Public Class VwConsultaPakingListDetalleTypedView 
#Else
	Public Class VwConsultaPakingListDetalleTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnLoteCorte As DataColumn
		Private _columnIdFolioEtiqueta As DataColumn
		Private _columnIdCorte As DataColumn
		Private _columnIdProducto As DataColumn
		Private _columnCantPzas As DataColumn
		Private _columnCantKgrs As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnIdFolioEmbarque As DataColumn
		Private _columnIdFolioMovimiento As DataColumn
		Private _columnCodigoBarra As DataColumn
		Private _columnIdFolioEtiquetaReferencia As DataColumn
		Private _columnGrados As DataColumn
		Private _columnIdCliente As DataColumn
		Private _columnFechaCaptura As DataColumn
		Private _columnLoteCorteReproceso As DataColumn
		Private _columnIdFolioMovimientoAlmacenReproceso As DataColumn
		Private _columnIdFolioMovimientoAlmacenAjuste As DataColumn
		Private _columnFechaCaducidad As DataColumn
		Private _columnFechaCaducidadAnterior As DataColumn
		Private _columnIdFolioMovimientoAlmacenCongelado As DataColumn
		Private _columnGradosAnterior As DataColumn
		Private _columnTipoProducto As DataColumn
		Private _columnIdAlmacenActual As DataColumn
		Private _columnIdAlmacenOrigen As DataColumn
		Private _columnTipoProductoAnterior As DataColumn
		Private _columnCantLibras As DataColumn
		Private _columnMasDe30Meses As DataColumn
		Private _columnFarenheit As DataColumn
		Private _columnProductoIngles As DataColumn
		Private _columnProducto As DataColumn
		Private _columnPreCorte As DataColumn
		Private _columnPreCorteIngles As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 32
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
			MyBase.New("VwConsultaPakingListDetalle")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwConsultaPakingListDetalleTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwConsultaPakingListDetalleTypedView)
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
			Return New VwConsultaPakingListDetalleRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnLoteCorte = New DataColumn("LoteCorte", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteCorte.ReadOnly = True
			_columnLoteCorte.Caption = "LoteCorte"
			Me.Columns.Add(_columnLoteCorte)

			_columnIdFolioEtiqueta = New DataColumn("IdFolioEtiqueta", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioEtiqueta.ReadOnly = True
			_columnIdFolioEtiqueta.Caption = "IdFolioEtiqueta"
			Me.Columns.Add(_columnIdFolioEtiqueta)

			_columnIdCorte = New DataColumn("IdCorte", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCorte.ReadOnly = True
			_columnIdCorte.Caption = "IdCorte"
			Me.Columns.Add(_columnIdCorte)

			_columnIdProducto = New DataColumn("IdProducto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProducto.ReadOnly = True
			_columnIdProducto.Caption = "IdProducto"
			Me.Columns.Add(_columnIdProducto)

			_columnCantPzas = New DataColumn("CantPzas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantPzas.ReadOnly = True
			_columnCantPzas.Caption = "CantPzas"
			Me.Columns.Add(_columnCantPzas)

			_columnCantKgrs = New DataColumn("CantKgrs", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantKgrs.ReadOnly = True
			_columnCantKgrs.Caption = "CantKgrs"
			Me.Columns.Add(_columnCantKgrs)

			_columnEstatus = New DataColumn("Estatus", GetType(System.Int16), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnIdFolioEmbarque = New DataColumn("IdFolioEmbarque", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioEmbarque.ReadOnly = True
			_columnIdFolioEmbarque.Caption = "IdFolioEmbarque"
			Me.Columns.Add(_columnIdFolioEmbarque)

			_columnIdFolioMovimiento = New DataColumn("IdFolioMovimiento", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioMovimiento.ReadOnly = True
			_columnIdFolioMovimiento.Caption = "IdFolioMovimiento"
			Me.Columns.Add(_columnIdFolioMovimiento)

			_columnCodigoBarra = New DataColumn("CodigoBarra", GetType(System.String), Nothing, MappingType.Element)
			_columnCodigoBarra.ReadOnly = True
			_columnCodigoBarra.Caption = "CodigoBarra"
			Me.Columns.Add(_columnCodigoBarra)

			_columnIdFolioEtiquetaReferencia = New DataColumn("IdFolioEtiquetaReferencia", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioEtiquetaReferencia.ReadOnly = True
			_columnIdFolioEtiquetaReferencia.Caption = "IdFolioEtiquetaReferencia"
			Me.Columns.Add(_columnIdFolioEtiquetaReferencia)

			_columnGrados = New DataColumn("Grados", GetType(System.Int32), Nothing, MappingType.Element)
			_columnGrados.ReadOnly = True
			_columnGrados.Caption = "Grados"
			Me.Columns.Add(_columnGrados)

			_columnIdCliente = New DataColumn("IdCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCliente.ReadOnly = True
			_columnIdCliente.Caption = "IdCliente"
			Me.Columns.Add(_columnIdCliente)

			_columnFechaCaptura = New DataColumn("FechaCaptura", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCaptura.ReadOnly = True
			_columnFechaCaptura.Caption = "FechaCaptura"
			Me.Columns.Add(_columnFechaCaptura)

			_columnLoteCorteReproceso = New DataColumn("LoteCorteReproceso", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteCorteReproceso.ReadOnly = True
			_columnLoteCorteReproceso.Caption = "LoteCorteReproceso"
			Me.Columns.Add(_columnLoteCorteReproceso)

			_columnIdFolioMovimientoAlmacenReproceso = New DataColumn("IdFolioMovimientoAlmacenReproceso", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioMovimientoAlmacenReproceso.ReadOnly = True
			_columnIdFolioMovimientoAlmacenReproceso.Caption = "IdFolioMovimientoAlmacenReproceso"
			Me.Columns.Add(_columnIdFolioMovimientoAlmacenReproceso)

			_columnIdFolioMovimientoAlmacenAjuste = New DataColumn("IdFolioMovimientoAlmacenAjuste", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioMovimientoAlmacenAjuste.ReadOnly = True
			_columnIdFolioMovimientoAlmacenAjuste.Caption = "IdFolioMovimientoAlmacenAjuste"
			Me.Columns.Add(_columnIdFolioMovimientoAlmacenAjuste)

			_columnFechaCaducidad = New DataColumn("FechaCaducidad", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCaducidad.ReadOnly = True
			_columnFechaCaducidad.Caption = "FechaCaducidad"
			Me.Columns.Add(_columnFechaCaducidad)

			_columnFechaCaducidadAnterior = New DataColumn("FechaCaducidadAnterior", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCaducidadAnterior.ReadOnly = True
			_columnFechaCaducidadAnterior.Caption = "FechaCaducidadAnterior"
			Me.Columns.Add(_columnFechaCaducidadAnterior)

			_columnIdFolioMovimientoAlmacenCongelado = New DataColumn("IdFolioMovimientoAlmacenCongelado", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioMovimientoAlmacenCongelado.ReadOnly = True
			_columnIdFolioMovimientoAlmacenCongelado.Caption = "IdFolioMovimientoAlmacenCongelado"
			Me.Columns.Add(_columnIdFolioMovimientoAlmacenCongelado)

			_columnGradosAnterior = New DataColumn("GradosAnterior", GetType(System.Int32), Nothing, MappingType.Element)
			_columnGradosAnterior.ReadOnly = True
			_columnGradosAnterior.Caption = "GradosAnterior"
			Me.Columns.Add(_columnGradosAnterior)

			_columnTipoProducto = New DataColumn("TipoProducto", GetType(System.Int16), Nothing, MappingType.Element)
			_columnTipoProducto.ReadOnly = True
			_columnTipoProducto.Caption = "TipoProducto"
			Me.Columns.Add(_columnTipoProducto)

			_columnIdAlmacenActual = New DataColumn("IdAlmacenActual", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdAlmacenActual.ReadOnly = True
			_columnIdAlmacenActual.Caption = "IdAlmacenActual"
			Me.Columns.Add(_columnIdAlmacenActual)

			_columnIdAlmacenOrigen = New DataColumn("IdAlmacenOrigen", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdAlmacenOrigen.ReadOnly = True
			_columnIdAlmacenOrigen.Caption = "IdAlmacenOrigen"
			Me.Columns.Add(_columnIdAlmacenOrigen)

			_columnTipoProductoAnterior = New DataColumn("TipoProductoAnterior", GetType(System.Int16), Nothing, MappingType.Element)
			_columnTipoProductoAnterior.ReadOnly = True
			_columnTipoProductoAnterior.Caption = "TipoProductoAnterior"
			Me.Columns.Add(_columnTipoProductoAnterior)

			_columnCantLibras = New DataColumn("CantLibras", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantLibras.ReadOnly = True
			_columnCantLibras.Caption = "CantLibras"
			Me.Columns.Add(_columnCantLibras)

			_columnMasDe30Meses = New DataColumn("MasDe30Meses", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnMasDe30Meses.ReadOnly = True
			_columnMasDe30Meses.Caption = "MasDe30Meses"
			Me.Columns.Add(_columnMasDe30Meses)

			_columnFarenheit = New DataColumn("Farenheit", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnFarenheit.ReadOnly = True
			_columnFarenheit.Caption = "Farenheit"
			Me.Columns.Add(_columnFarenheit)

			_columnProductoIngles = New DataColumn("ProductoIngles", GetType(System.String), Nothing, MappingType.Element)
			_columnProductoIngles.ReadOnly = True
			_columnProductoIngles.Caption = "ProductoIngles"
			Me.Columns.Add(_columnProductoIngles)

			_columnProducto = New DataColumn("Producto", GetType(System.String), Nothing, MappingType.Element)
			_columnProducto.ReadOnly = True
			_columnProducto.Caption = "Producto"
			Me.Columns.Add(_columnProducto)

			_columnPreCorte = New DataColumn("PreCorte", GetType(System.String), Nothing, MappingType.Element)
			_columnPreCorte.ReadOnly = True
			_columnPreCorte.Caption = "PreCorte"
			Me.Columns.Add(_columnPreCorte)

			_columnPreCorteIngles = New DataColumn("PreCorteIngles", GetType(System.String), Nothing, MappingType.Element)
			_columnPreCorteIngles.ReadOnly = True
			_columnPreCorteIngles.Caption = "PreCorteIngles"
			Me.Columns.Add(_columnPreCorteIngles)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnLoteCorte = Me.Columns("LoteCorte")
			_columnIdFolioEtiqueta = Me.Columns("IdFolioEtiqueta")
			_columnIdCorte = Me.Columns("IdCorte")
			_columnIdProducto = Me.Columns("IdProducto")
			_columnCantPzas = Me.Columns("CantPzas")
			_columnCantKgrs = Me.Columns("CantKgrs")
			_columnEstatus = Me.Columns("Estatus")
			_columnIdFolioEmbarque = Me.Columns("IdFolioEmbarque")
			_columnIdFolioMovimiento = Me.Columns("IdFolioMovimiento")
			_columnCodigoBarra = Me.Columns("CodigoBarra")
			_columnIdFolioEtiquetaReferencia = Me.Columns("IdFolioEtiquetaReferencia")
			_columnGrados = Me.Columns("Grados")
			_columnIdCliente = Me.Columns("IdCliente")
			_columnFechaCaptura = Me.Columns("FechaCaptura")
			_columnLoteCorteReproceso = Me.Columns("LoteCorteReproceso")
			_columnIdFolioMovimientoAlmacenReproceso = Me.Columns("IdFolioMovimientoAlmacenReproceso")
			_columnIdFolioMovimientoAlmacenAjuste = Me.Columns("IdFolioMovimientoAlmacenAjuste")
			_columnFechaCaducidad = Me.Columns("FechaCaducidad")
			_columnFechaCaducidadAnterior = Me.Columns("FechaCaducidadAnterior")
			_columnIdFolioMovimientoAlmacenCongelado = Me.Columns("IdFolioMovimientoAlmacenCongelado")
			_columnGradosAnterior = Me.Columns("GradosAnterior")
			_columnTipoProducto = Me.Columns("TipoProducto")
			_columnIdAlmacenActual = Me.Columns("IdAlmacenActual")
			_columnIdAlmacenOrigen = Me.Columns("IdAlmacenOrigen")
			_columnTipoProductoAnterior = Me.Columns("TipoProductoAnterior")
			_columnCantLibras = Me.Columns("CantLibras")
			_columnMasDe30Meses = Me.Columns("MasDe30Meses")
			_columnFarenheit = Me.Columns("Farenheit")
			_columnProductoIngles = Me.Columns("ProductoIngles")
			_columnProducto = Me.Columns("Producto")
			_columnPreCorte = Me.Columns("PreCorte")
			_columnPreCorteIngles = Me.Columns("PreCorteIngles")
			
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

			_fieldsCustomProperties.Add("IdFolioEtiqueta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantPzas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantKgrs", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioEmbarque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioMovimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CodigoBarra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioEtiquetaReferencia", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Grados", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("LoteCorteReproceso", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioMovimientoAlmacenReproceso", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioMovimientoAlmacenAjuste", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCaducidad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCaducidadAnterior", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioMovimientoAlmacenCongelado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("GradosAnterior", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdAlmacenActual", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdAlmacenOrigen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoProductoAnterior", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantLibras", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("MasDe30Meses", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Farenheit", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ProductoIngles", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Producto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PreCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PreCorteIngles", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwConsultaPakingListDetalleRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwConsultaPakingListDetalleTypedView = CType(MyBase.Clone(), VwConsultaPakingListDetalleTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwConsultaPakingListDetalleTypedView()
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
				Return VwConsultaPakingListDetalleTypedView.CustomProperties
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
				Return VwConsultaPakingListDetalleTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwConsultaPakingListDetalleRow
			Get 
				Return CType(Me.Rows(index), VwConsultaPakingListDetalleRow)
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
		''' Returns the column Object belonging to the TypedView field IdFolioEtiqueta
		''' </summary>
		ReadOnly Friend Property IdFolioEtiquetaColumn As DataColumn
			Get 
				Return _columnIdFolioEtiqueta 
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
		''' Returns the column Object belonging to the TypedView field Estatus
		''' </summary>
		ReadOnly Friend Property EstatusColumn As DataColumn
			Get 
				Return _columnEstatus 
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
		''' Returns the column Object belonging to the TypedView field IdFolioMovimiento
		''' </summary>
		ReadOnly Friend Property IdFolioMovimientoColumn As DataColumn
			Get 
				Return _columnIdFolioMovimiento 
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
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioEtiquetaReferencia
		''' </summary>
		ReadOnly Friend Property IdFolioEtiquetaReferenciaColumn As DataColumn
			Get 
				Return _columnIdFolioEtiquetaReferencia 
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
		''' Returns the column Object belonging to the TypedView field IdCliente
		''' </summary>
		ReadOnly Friend Property IdClienteColumn As DataColumn
			Get 
				Return _columnIdCliente 
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
		''' Returns the column Object belonging to the TypedView field LoteCorteReproceso
		''' </summary>
		ReadOnly Friend Property LoteCorteReprocesoColumn As DataColumn
			Get 
				Return _columnLoteCorteReproceso 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioMovimientoAlmacenReproceso
		''' </summary>
		ReadOnly Friend Property IdFolioMovimientoAlmacenReprocesoColumn As DataColumn
			Get 
				Return _columnIdFolioMovimientoAlmacenReproceso 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioMovimientoAlmacenAjuste
		''' </summary>
		ReadOnly Friend Property IdFolioMovimientoAlmacenAjusteColumn As DataColumn
			Get 
				Return _columnIdFolioMovimientoAlmacenAjuste 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaCaducidad
		''' </summary>
		ReadOnly Friend Property FechaCaducidadColumn As DataColumn
			Get 
				Return _columnFechaCaducidad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaCaducidadAnterior
		''' </summary>
		ReadOnly Friend Property FechaCaducidadAnteriorColumn As DataColumn
			Get 
				Return _columnFechaCaducidadAnterior 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioMovimientoAlmacenCongelado
		''' </summary>
		ReadOnly Friend Property IdFolioMovimientoAlmacenCongeladoColumn As DataColumn
			Get 
				Return _columnIdFolioMovimientoAlmacenCongelado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field GradosAnterior
		''' </summary>
		ReadOnly Friend Property GradosAnteriorColumn As DataColumn
			Get 
				Return _columnGradosAnterior 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TipoProducto
		''' </summary>
		ReadOnly Friend Property TipoProductoColumn As DataColumn
			Get 
				Return _columnTipoProducto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdAlmacenActual
		''' </summary>
		ReadOnly Friend Property IdAlmacenActualColumn As DataColumn
			Get 
				Return _columnIdAlmacenActual 
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
		''' Returns the column Object belonging to the TypedView field TipoProductoAnterior
		''' </summary>
		ReadOnly Friend Property TipoProductoAnteriorColumn As DataColumn
			Get 
				Return _columnTipoProductoAnterior 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantLibras
		''' </summary>
		ReadOnly Friend Property CantLibrasColumn As DataColumn
			Get 
				Return _columnCantLibras 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field MasDe30Meses
		''' </summary>
		ReadOnly Friend Property MasDe30MesesColumn As DataColumn
			Get 
				Return _columnMasDe30Meses 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Farenheit
		''' </summary>
		ReadOnly Friend Property FarenheitColumn As DataColumn
			Get 
				Return _columnFarenheit 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ProductoIngles
		''' </summary>
		ReadOnly Friend Property ProductoInglesColumn As DataColumn
			Get 
				Return _columnProductoIngles 
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
		''' Returns the column Object belonging to the TypedView field PreCorte
		''' </summary>
		ReadOnly Friend Property PreCorteColumn As DataColumn
			Get 
				Return _columnPreCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PreCorteIngles
		''' </summary>
		ReadOnly Friend Property PreCorteInglesColumn As DataColumn
			Get 
				Return _columnPreCorteIngles 
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
	''' Typed datarow for the typed datatable VwConsultaPakingListDetalle
	''' </summary>
	Public Class VwConsultaPakingListDetalleRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwConsultaPakingListDetalleTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwConsultaPakingListDetalleTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field LoteCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."LoteCorte"<br/>
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
		''' Gets / sets the value of the TypedView field IdFolioEtiqueta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdFolioEtiqueta"<br/>
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
		''' Gets / sets the value of the TypedView field IdCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdCorte"<br/>
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
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdProducto"<br/>
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
		''' Gets / sets the value of the TypedView field CantPzas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."CantPzas"<br/>
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
		''' Mapped on view field: "vwConsultaPakingListDetalle"."CantKgrs"<br/>
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
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."Estatus"<br/>
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
		''' Gets / sets the value of the TypedView field IdFolioEmbarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdFolioEmbarque"<br/>
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
		''' Gets / sets the value of the TypedView field IdFolioMovimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdFolioMovimiento"<br/>
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
		''' Gets / sets the value of the TypedView field CodigoBarra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."CodigoBarra"<br/>
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

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioEtiquetaReferencia<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdFolioEtiquetaReferencia"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 14
		''' </remarks>
		Public Property [IdFolioEtiquetaReferencia]() As System.String
			Get 
				If IsIdFolioEtiquetaReferenciaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioEtiquetaReferenciaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioEtiquetaReferenciaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioEtiquetaReferencia is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioEtiquetaReferenciaNull() As Boolean
			Return IsNull(_parent.IdFolioEtiquetaReferenciaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioEtiquetaReferencia to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioEtiquetaReferenciaNull() 
			Me(_parent.IdFolioEtiquetaReferenciaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Grados<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."Grados"<br/>
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
		''' Gets / sets the value of the TypedView field IdCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdCliente"<br/>
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
		''' Gets / sets the value of the TypedView field FechaCaptura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."FechaCaptura"<br/>
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
		''' Gets / sets the value of the TypedView field LoteCorteReproceso<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."LoteCorteReproceso"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [LoteCorteReproceso]() As System.String
			Get 
				If IsLoteCorteReprocesoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LoteCorteReprocesoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LoteCorteReprocesoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field LoteCorteReproceso is NULL, False otherwise.
		''' </summary>
		Public Function IsLoteCorteReprocesoNull() As Boolean
			Return IsNull(_parent.LoteCorteReprocesoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field LoteCorteReproceso to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLoteCorteReprocesoNull() 
			Me(_parent.LoteCorteReprocesoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioMovimientoAlmacenReproceso<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdFolioMovimientoAlmacenReproceso"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 12
		''' </remarks>
		Public Property [IdFolioMovimientoAlmacenReproceso]() As System.String
			Get 
				If IsIdFolioMovimientoAlmacenReprocesoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioMovimientoAlmacenReprocesoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioMovimientoAlmacenReprocesoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioMovimientoAlmacenReproceso is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioMovimientoAlmacenReprocesoNull() As Boolean
			Return IsNull(_parent.IdFolioMovimientoAlmacenReprocesoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioMovimientoAlmacenReproceso to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioMovimientoAlmacenReprocesoNull() 
			Me(_parent.IdFolioMovimientoAlmacenReprocesoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioMovimientoAlmacenAjuste<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdFolioMovimientoAlmacenAjuste"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 12
		''' </remarks>
		Public Property [IdFolioMovimientoAlmacenAjuste]() As System.String
			Get 
				If IsIdFolioMovimientoAlmacenAjusteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioMovimientoAlmacenAjusteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioMovimientoAlmacenAjusteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioMovimientoAlmacenAjuste is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioMovimientoAlmacenAjusteNull() As Boolean
			Return IsNull(_parent.IdFolioMovimientoAlmacenAjusteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioMovimientoAlmacenAjuste to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioMovimientoAlmacenAjusteNull() 
			Me(_parent.IdFolioMovimientoAlmacenAjusteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaCaducidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."FechaCaducidad"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaCaducidad]() As System.DateTime
			Get 
				If IsFechaCaducidadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaCaducidadColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaCaducidadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaCaducidad is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaCaducidadNull() As Boolean
			Return IsNull(_parent.FechaCaducidadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaCaducidad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaCaducidadNull() 
			Me(_parent.FechaCaducidadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaCaducidadAnterior<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."FechaCaducidadAnterior"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaCaducidadAnterior]() As System.DateTime
			Get 
				If IsFechaCaducidadAnteriorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaCaducidadAnteriorColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaCaducidadAnteriorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaCaducidadAnterior is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaCaducidadAnteriorNull() As Boolean
			Return IsNull(_parent.FechaCaducidadAnteriorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaCaducidadAnterior to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaCaducidadAnteriorNull() 
			Me(_parent.FechaCaducidadAnteriorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioMovimientoAlmacenCongelado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdFolioMovimientoAlmacenCongelado"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 12
		''' </remarks>
		Public Property [IdFolioMovimientoAlmacenCongelado]() As System.String
			Get 
				If IsIdFolioMovimientoAlmacenCongeladoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioMovimientoAlmacenCongeladoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioMovimientoAlmacenCongeladoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioMovimientoAlmacenCongelado is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioMovimientoAlmacenCongeladoNull() As Boolean
			Return IsNull(_parent.IdFolioMovimientoAlmacenCongeladoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioMovimientoAlmacenCongelado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioMovimientoAlmacenCongeladoNull() 
			Me(_parent.IdFolioMovimientoAlmacenCongeladoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field GradosAnterior<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."GradosAnterior"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [GradosAnterior]() As System.Int32
			Get 
				If IsGradosAnteriorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.GradosAnteriorColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.GradosAnteriorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field GradosAnterior is NULL, False otherwise.
		''' </summary>
		Public Function IsGradosAnteriorNull() As Boolean
			Return IsNull(_parent.GradosAnteriorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field GradosAnterior to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetGradosAnteriorNull() 
			Me(_parent.GradosAnteriorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TipoProducto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."TipoProducto"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [TipoProducto]() As System.Int16
			Get 
				If IsTipoProductoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.TipoProductoColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.TipoProductoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoProducto is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoProductoNull() As Boolean
			Return IsNull(_parent.TipoProductoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoProducto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoProductoNull() 
			Me(_parent.TipoProductoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdAlmacenActual<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdAlmacenActual"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdAlmacenActual]() As System.Int32
			Get 
				If IsIdAlmacenActualNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdAlmacenActualColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdAlmacenActualColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdAlmacenActual is NULL, False otherwise.
		''' </summary>
		Public Function IsIdAlmacenActualNull() As Boolean
			Return IsNull(_parent.IdAlmacenActualColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdAlmacenActual to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdAlmacenActualNull() 
			Me(_parent.IdAlmacenActualColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdAlmacenOrigen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."IdAlmacenOrigen"<br/>
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
		''' Gets / sets the value of the TypedView field TipoProductoAnterior<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."TipoProductoAnterior"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [TipoProductoAnterior]() As System.Int16
			Get 
				If IsTipoProductoAnteriorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.TipoProductoAnteriorColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.TipoProductoAnteriorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoProductoAnterior is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoProductoAnteriorNull() As Boolean
			Return IsNull(_parent.TipoProductoAnteriorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoProductoAnterior to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoProductoAnteriorNull() 
			Me(_parent.TipoProductoAnteriorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantLibras<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."CantLibras"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 29, 12, 0
		''' </remarks>
		Public Property [CantLibras]() As System.Decimal
			Get 
				If IsCantLibrasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantLibrasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantLibrasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantLibras is NULL, False otherwise.
		''' </summary>
		Public Function IsCantLibrasNull() As Boolean
			Return IsNull(_parent.CantLibrasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantLibras to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantLibrasNull() 
			Me(_parent.CantLibrasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field MasDe30Meses<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."MasDe30Meses"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [MasDe30Meses]() As System.Boolean
			Get 
				If IsMasDe30MesesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.MasDe30MesesColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.MasDe30MesesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field MasDe30Meses is NULL, False otherwise.
		''' </summary>
		Public Function IsMasDe30MesesNull() As Boolean
			Return IsNull(_parent.MasDe30MesesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field MasDe30Meses to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetMasDe30MesesNull() 
			Me(_parent.MasDe30MesesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Farenheit<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."Farenheit"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 14, 1, 0
		''' </remarks>
		Public Property [Farenheit]() As System.Decimal
			Get 
				If IsFarenheitNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.FarenheitColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.FarenheitColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Farenheit is NULL, False otherwise.
		''' </summary>
		Public Function IsFarenheitNull() As Boolean
			Return IsNull(_parent.FarenheitColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Farenheit to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFarenheitNull() 
			Me(_parent.FarenheitColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ProductoIngles<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."ProductoIngles"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [ProductoIngles]() As System.String
			Get 
				If IsProductoInglesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ProductoInglesColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ProductoInglesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ProductoIngles is NULL, False otherwise.
		''' </summary>
		Public Function IsProductoInglesNull() As Boolean
			Return IsNull(_parent.ProductoInglesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ProductoIngles to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetProductoInglesNull() 
			Me(_parent.ProductoInglesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Producto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."Producto"<br/>
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
		''' Gets / sets the value of the TypedView field PreCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."PreCorte"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [PreCorte]() As System.String
			Get 
				If IsPreCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PreCorteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PreCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PreCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsPreCorteNull() As Boolean
			Return IsNull(_parent.PreCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PreCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPreCorteNull() 
			Me(_parent.PreCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PreCorteIngles<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwConsultaPakingListDetalle"."PreCorteIngles"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [PreCorteIngles]() As System.String
			Get 
				If IsPreCorteInglesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PreCorteInglesColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PreCorteInglesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PreCorteIngles is NULL, False otherwise.
		''' </summary>
		Public Function IsPreCorteInglesNull() As Boolean
			Return IsNull(_parent.PreCorteInglesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PreCorteIngles to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPreCorteInglesNull() 
			Me(_parent.PreCorteInglesColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
