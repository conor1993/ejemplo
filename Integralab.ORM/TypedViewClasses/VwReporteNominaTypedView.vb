' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 5 de enero de 2018 17:48:24
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
	''' Typed datatable for the view 'VwReporteNomina'.<br/><br/>
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
	Public Class VwReporteNominaTypedView 
#Else
	Public Class VwReporteNominaTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnNombre As DataColumn
		Private _columnQuincena As DataColumn
		Private _columnFecha As DataColumn
		Private _columnImporteSueldo As DataColumn
		Private _columnComisiones As DataColumn
		Private _columnImporteHorasExtras As DataColumn
		Private _columnImporteTotalCuotaMensual As DataColumn
		Private _columnImporteIsrsegunTarifa As DataColumn
		Private _columnImporteSubsidioalEmpleo As DataColumn
		Private _columnPretamos As DataColumn
		Private _columnInfonavit As DataColumn
		Private _columnImportePensionAlimenticia As DataColumn
		Private _columnFolio As DataColumn
		Private _columnIdEmpleado As DataColumn
		Private _columnSueldoDiario As DataColumn
		Private _columnDescripcion As DataColumn
		Private _columnNomDepto As DataColumn
		Private _columnHorasExtrasTriples As DataColumn
		Private _columnHorasExtrasDobles As DataColumn
		Private _columnDiasTrabajados As DataColumn
		Private _columnSmregionA As DataColumn
		Private _columnSmregionC As DataColumn
		Private _columnMesComercial As DataColumn
		Private _columnFactor As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 24
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
			MyBase.New("VwReporteNomina")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwReporteNominaTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwReporteNominaTypedView)
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
			Return New VwReporteNominaRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnQuincena = New DataColumn("Quincena", GetType(System.String), Nothing, MappingType.Element)
			_columnQuincena.ReadOnly = True
			_columnQuincena.Caption = "Quincena"
			Me.Columns.Add(_columnQuincena)

			_columnFecha = New DataColumn("Fecha", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFecha.ReadOnly = True
			_columnFecha.Caption = "Fecha"
			Me.Columns.Add(_columnFecha)

			_columnImporteSueldo = New DataColumn("ImporteSueldo", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporteSueldo.ReadOnly = True
			_columnImporteSueldo.Caption = "ImporteSueldo"
			Me.Columns.Add(_columnImporteSueldo)

			_columnComisiones = New DataColumn("Comisiones", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnComisiones.ReadOnly = True
			_columnComisiones.Caption = "Comisiones"
			Me.Columns.Add(_columnComisiones)

			_columnImporteHorasExtras = New DataColumn("ImporteHorasExtras", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporteHorasExtras.ReadOnly = True
			_columnImporteHorasExtras.Caption = "ImporteHorasExtras"
			Me.Columns.Add(_columnImporteHorasExtras)

			_columnImporteTotalCuotaMensual = New DataColumn("ImporteTotalCuotaMensual", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporteTotalCuotaMensual.ReadOnly = True
			_columnImporteTotalCuotaMensual.Caption = "ImporteTotalCuotaMensual"
			Me.Columns.Add(_columnImporteTotalCuotaMensual)

			_columnImporteIsrsegunTarifa = New DataColumn("ImporteIsrsegunTarifa", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporteIsrsegunTarifa.ReadOnly = True
			_columnImporteIsrsegunTarifa.Caption = "ImporteIsrsegunTarifa"
			Me.Columns.Add(_columnImporteIsrsegunTarifa)

			_columnImporteSubsidioalEmpleo = New DataColumn("ImporteSubsidioalEmpleo", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporteSubsidioalEmpleo.ReadOnly = True
			_columnImporteSubsidioalEmpleo.Caption = "ImporteSubsidioalEmpleo"
			Me.Columns.Add(_columnImporteSubsidioalEmpleo)

			_columnPretamos = New DataColumn("Pretamos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPretamos.ReadOnly = True
			_columnPretamos.Caption = "Pretamos"
			Me.Columns.Add(_columnPretamos)

			_columnInfonavit = New DataColumn("Infonavit", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnInfonavit.ReadOnly = True
			_columnInfonavit.Caption = "Infonavit"
			Me.Columns.Add(_columnInfonavit)

			_columnImportePensionAlimenticia = New DataColumn("ImportePensionAlimenticia", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImportePensionAlimenticia.ReadOnly = True
			_columnImportePensionAlimenticia.Caption = "ImportePensionAlimenticia"
			Me.Columns.Add(_columnImportePensionAlimenticia)

			_columnFolio = New DataColumn("Folio", GetType(System.String), Nothing, MappingType.Element)
			_columnFolio.ReadOnly = True
			_columnFolio.Caption = "Folio"
			Me.Columns.Add(_columnFolio)

			_columnIdEmpleado = New DataColumn("IdEmpleado", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdEmpleado.ReadOnly = True
			_columnIdEmpleado.Caption = "IdEmpleado"
			Me.Columns.Add(_columnIdEmpleado)

			_columnSueldoDiario = New DataColumn("SueldoDiario", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSueldoDiario.ReadOnly = True
			_columnSueldoDiario.Caption = "SueldoDiario"
			Me.Columns.Add(_columnSueldoDiario)

			_columnDescripcion = New DataColumn("Descripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnDescripcion.ReadOnly = True
			_columnDescripcion.Caption = "Descripcion"
			Me.Columns.Add(_columnDescripcion)

			_columnNomDepto = New DataColumn("NomDepto", GetType(System.String), Nothing, MappingType.Element)
			_columnNomDepto.ReadOnly = True
			_columnNomDepto.Caption = "NomDepto"
			Me.Columns.Add(_columnNomDepto)

			_columnHorasExtrasTriples = New DataColumn("HorasExtrasTriples", GetType(System.Int32), Nothing, MappingType.Element)
			_columnHorasExtrasTriples.ReadOnly = True
			_columnHorasExtrasTriples.Caption = "HorasExtrasTriples"
			Me.Columns.Add(_columnHorasExtrasTriples)

			_columnHorasExtrasDobles = New DataColumn("HorasExtrasDobles", GetType(System.Int32), Nothing, MappingType.Element)
			_columnHorasExtrasDobles.ReadOnly = True
			_columnHorasExtrasDobles.Caption = "HorasExtrasDobles"
			Me.Columns.Add(_columnHorasExtrasDobles)

			_columnDiasTrabajados = New DataColumn("DiasTrabajados", GetType(System.Int32), Nothing, MappingType.Element)
			_columnDiasTrabajados.ReadOnly = True
			_columnDiasTrabajados.Caption = "DiasTrabajados"
			Me.Columns.Add(_columnDiasTrabajados)

			_columnSmregionA = New DataColumn("SmregionA", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSmregionA.ReadOnly = True
			_columnSmregionA.Caption = "SmregionA"
			Me.Columns.Add(_columnSmregionA)

			_columnSmregionC = New DataColumn("SmregionC", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSmregionC.ReadOnly = True
			_columnSmregionC.Caption = "SmregionC"
			Me.Columns.Add(_columnSmregionC)

			_columnMesComercial = New DataColumn("MesComercial", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnMesComercial.ReadOnly = True
			_columnMesComercial.Caption = "MesComercial"
			Me.Columns.Add(_columnMesComercial)

			_columnFactor = New DataColumn("Factor", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnFactor.ReadOnly = True
			_columnFactor.Caption = "Factor"
			Me.Columns.Add(_columnFactor)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnNombre = Me.Columns("Nombre")
			_columnQuincena = Me.Columns("Quincena")
			_columnFecha = Me.Columns("Fecha")
			_columnImporteSueldo = Me.Columns("ImporteSueldo")
			_columnComisiones = Me.Columns("Comisiones")
			_columnImporteHorasExtras = Me.Columns("ImporteHorasExtras")
			_columnImporteTotalCuotaMensual = Me.Columns("ImporteTotalCuotaMensual")
			_columnImporteIsrsegunTarifa = Me.Columns("ImporteIsrsegunTarifa")
			_columnImporteSubsidioalEmpleo = Me.Columns("ImporteSubsidioalEmpleo")
			_columnPretamos = Me.Columns("Pretamos")
			_columnInfonavit = Me.Columns("Infonavit")
			_columnImportePensionAlimenticia = Me.Columns("ImportePensionAlimenticia")
			_columnFolio = Me.Columns("Folio")
			_columnIdEmpleado = Me.Columns("IdEmpleado")
			_columnSueldoDiario = Me.Columns("SueldoDiario")
			_columnDescripcion = Me.Columns("Descripcion")
			_columnNomDepto = Me.Columns("NomDepto")
			_columnHorasExtrasTriples = Me.Columns("HorasExtrasTriples")
			_columnHorasExtrasDobles = Me.Columns("HorasExtrasDobles")
			_columnDiasTrabajados = Me.Columns("DiasTrabajados")
			_columnSmregionA = Me.Columns("SmregionA")
			_columnSmregionC = Me.Columns("SmregionC")
			_columnMesComercial = Me.Columns("MesComercial")
			_columnFactor = Me.Columns("Factor")
			
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

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Quincena", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Fecha", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImporteSueldo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Comisiones", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImporteHorasExtras", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImporteTotalCuotaMensual", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImporteIsrsegunTarifa", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImporteSubsidioalEmpleo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Pretamos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Infonavit", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImportePensionAlimenticia", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdEmpleado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SueldoDiario", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NomDepto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("HorasExtrasTriples", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("HorasExtrasDobles", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("DiasTrabajados", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SmregionA", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SmregionC", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("MesComercial", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Factor", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwReporteNominaRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwReporteNominaTypedView = CType(MyBase.Clone(), VwReporteNominaTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwReporteNominaTypedView()
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
				Return VwReporteNominaTypedView.CustomProperties
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
				Return VwReporteNominaTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwReporteNominaRow
			Get 
				Return CType(Me.Rows(index), VwReporteNominaRow)
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
		''' Returns the column Object belonging to the TypedView field Quincena
		''' </summary>
		ReadOnly Friend Property QuincenaColumn As DataColumn
			Get 
				Return _columnQuincena 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Fecha
		''' </summary>
		ReadOnly Friend Property FechaColumn As DataColumn
			Get 
				Return _columnFecha 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImporteSueldo
		''' </summary>
		ReadOnly Friend Property ImporteSueldoColumn As DataColumn
			Get 
				Return _columnImporteSueldo 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Comisiones
		''' </summary>
		ReadOnly Friend Property ComisionesColumn As DataColumn
			Get 
				Return _columnComisiones 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImporteHorasExtras
		''' </summary>
		ReadOnly Friend Property ImporteHorasExtrasColumn As DataColumn
			Get 
				Return _columnImporteHorasExtras 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImporteTotalCuotaMensual
		''' </summary>
		ReadOnly Friend Property ImporteTotalCuotaMensualColumn As DataColumn
			Get 
				Return _columnImporteTotalCuotaMensual 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImporteIsrsegunTarifa
		''' </summary>
		ReadOnly Friend Property ImporteIsrsegunTarifaColumn As DataColumn
			Get 
				Return _columnImporteIsrsegunTarifa 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImporteSubsidioalEmpleo
		''' </summary>
		ReadOnly Friend Property ImporteSubsidioalEmpleoColumn As DataColumn
			Get 
				Return _columnImporteSubsidioalEmpleo 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Pretamos
		''' </summary>
		ReadOnly Friend Property PretamosColumn As DataColumn
			Get 
				Return _columnPretamos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Infonavit
		''' </summary>
		ReadOnly Friend Property InfonavitColumn As DataColumn
			Get 
				Return _columnInfonavit 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImportePensionAlimenticia
		''' </summary>
		ReadOnly Friend Property ImportePensionAlimenticiaColumn As DataColumn
			Get 
				Return _columnImportePensionAlimenticia 
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
		''' Returns the column Object belonging to the TypedView field IdEmpleado
		''' </summary>
		ReadOnly Friend Property IdEmpleadoColumn As DataColumn
			Get 
				Return _columnIdEmpleado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SueldoDiario
		''' </summary>
		ReadOnly Friend Property SueldoDiarioColumn As DataColumn
			Get 
				Return _columnSueldoDiario 
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
		''' Returns the column Object belonging to the TypedView field NomDepto
		''' </summary>
		ReadOnly Friend Property NomDeptoColumn As DataColumn
			Get 
				Return _columnNomDepto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field HorasExtrasTriples
		''' </summary>
		ReadOnly Friend Property HorasExtrasTriplesColumn As DataColumn
			Get 
				Return _columnHorasExtrasTriples 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field HorasExtrasDobles
		''' </summary>
		ReadOnly Friend Property HorasExtrasDoblesColumn As DataColumn
			Get 
				Return _columnHorasExtrasDobles 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field DiasTrabajados
		''' </summary>
		ReadOnly Friend Property DiasTrabajadosColumn As DataColumn
			Get 
				Return _columnDiasTrabajados 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SmregionA
		''' </summary>
		ReadOnly Friend Property SmregionAColumn As DataColumn
			Get 
				Return _columnSmregionA 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SmregionC
		''' </summary>
		ReadOnly Friend Property SmregionCColumn As DataColumn
			Get 
				Return _columnSmregionC 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field MesComercial
		''' </summary>
		ReadOnly Friend Property MesComercialColumn As DataColumn
			Get 
				Return _columnMesComercial 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Factor
		''' </summary>
		ReadOnly Friend Property FactorColumn As DataColumn
			Get 
				Return _columnFactor 
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
	''' Typed datarow for the typed datatable VwReporteNomina
	''' </summary>
	Public Class VwReporteNominaRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwReporteNominaTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwReporteNominaTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field Nombre<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."Nombre"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 122
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
		''' Gets / sets the value of the TypedView field Quincena<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."Quincena"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 60
		''' </remarks>
		Public Property [Quincena]() As System.String
			Get 
				If IsQuincenaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.QuincenaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.QuincenaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Quincena is NULL, False otherwise.
		''' </summary>
		Public Function IsQuincenaNull() As Boolean
			Return IsNull(_parent.QuincenaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Quincena to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetQuincenaNull() 
			Me(_parent.QuincenaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Fecha<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."Fecha"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [Fecha]() As System.DateTime
			Get 
				If IsFechaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Fecha is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaNull() As Boolean
			Return IsNull(_parent.FechaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Fecha to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaNull() 
			Me(_parent.FechaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImporteSueldo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."ImporteSueldo"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [ImporteSueldo]() As System.Decimal
			Get 
				If IsImporteSueldoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteSueldoColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteSueldoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImporteSueldo is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteSueldoNull() As Boolean
			Return IsNull(_parent.ImporteSueldoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImporteSueldo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteSueldoNull() 
			Me(_parent.ImporteSueldoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Comisiones<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."Comisiones"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [Comisiones]() As System.Decimal
			Get 
				If IsComisionesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ComisionesColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ComisionesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Comisiones is NULL, False otherwise.
		''' </summary>
		Public Function IsComisionesNull() As Boolean
			Return IsNull(_parent.ComisionesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Comisiones to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetComisionesNull() 
			Me(_parent.ComisionesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImporteHorasExtras<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."ImporteHorasExtras"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [ImporteHorasExtras]() As System.Decimal
			Get 
				If IsImporteHorasExtrasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteHorasExtrasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteHorasExtrasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImporteHorasExtras is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteHorasExtrasNull() As Boolean
			Return IsNull(_parent.ImporteHorasExtrasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImporteHorasExtras to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteHorasExtrasNull() 
			Me(_parent.ImporteHorasExtrasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImporteTotalCuotaMensual<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."ImporteTotalCuotaMensual"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [ImporteTotalCuotaMensual]() As System.Decimal
			Get 
				If IsImporteTotalCuotaMensualNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteTotalCuotaMensualColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteTotalCuotaMensualColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImporteTotalCuotaMensual is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteTotalCuotaMensualNull() As Boolean
			Return IsNull(_parent.ImporteTotalCuotaMensualColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImporteTotalCuotaMensual to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteTotalCuotaMensualNull() 
			Me(_parent.ImporteTotalCuotaMensualColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImporteIsrsegunTarifa<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."ImporteISRSegunTarifa"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [ImporteIsrsegunTarifa]() As System.Decimal
			Get 
				If IsImporteIsrsegunTarifaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteIsrsegunTarifaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteIsrsegunTarifaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImporteIsrsegunTarifa is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteIsrsegunTarifaNull() As Boolean
			Return IsNull(_parent.ImporteIsrsegunTarifaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImporteIsrsegunTarifa to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteIsrsegunTarifaNull() 
			Me(_parent.ImporteIsrsegunTarifaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImporteSubsidioalEmpleo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."ImporteSubsidioalEmpleo"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [ImporteSubsidioalEmpleo]() As System.Decimal
			Get 
				If IsImporteSubsidioalEmpleoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteSubsidioalEmpleoColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteSubsidioalEmpleoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImporteSubsidioalEmpleo is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteSubsidioalEmpleoNull() As Boolean
			Return IsNull(_parent.ImporteSubsidioalEmpleoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImporteSubsidioalEmpleo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteSubsidioalEmpleoNull() 
			Me(_parent.ImporteSubsidioalEmpleoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Pretamos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."Pretamos"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [Pretamos]() As System.Decimal
			Get 
				If IsPretamosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PretamosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PretamosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Pretamos is NULL, False otherwise.
		''' </summary>
		Public Function IsPretamosNull() As Boolean
			Return IsNull(_parent.PretamosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Pretamos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPretamosNull() 
			Me(_parent.PretamosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Infonavit<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."INFONAVIT"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [Infonavit]() As System.Decimal
			Get 
				If IsInfonavitNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.InfonavitColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.InfonavitColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Infonavit is NULL, False otherwise.
		''' </summary>
		Public Function IsInfonavitNull() As Boolean
			Return IsNull(_parent.InfonavitColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Infonavit to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetInfonavitNull() 
			Me(_parent.InfonavitColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImportePensionAlimenticia<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."ImportePensionAlimenticia"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [ImportePensionAlimenticia]() As System.Decimal
			Get 
				If IsImportePensionAlimenticiaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImportePensionAlimenticiaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImportePensionAlimenticiaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImportePensionAlimenticia is NULL, False otherwise.
		''' </summary>
		Public Function IsImportePensionAlimenticiaNull() As Boolean
			Return IsNull(_parent.ImportePensionAlimenticiaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImportePensionAlimenticia to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImportePensionAlimenticiaNull() 
			Me(_parent.ImportePensionAlimenticiaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Folio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."Folio"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
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
		''' Gets / sets the value of the TypedView field IdEmpleado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."IdEmpleado"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdEmpleado]() As System.Int32
			Get 
				If IsIdEmpleadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdEmpleadoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdEmpleadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdEmpleado is NULL, False otherwise.
		''' </summary>
		Public Function IsIdEmpleadoNull() As Boolean
			Return IsNull(_parent.IdEmpleadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdEmpleado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdEmpleadoNull() 
			Me(_parent.IdEmpleadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SueldoDiario<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."SueldoDiario"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [SueldoDiario]() As System.Decimal
			Get 
				If IsSueldoDiarioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SueldoDiarioColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SueldoDiarioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SueldoDiario is NULL, False otherwise.
		''' </summary>
		Public Function IsSueldoDiarioNull() As Boolean
			Return IsNull(_parent.SueldoDiarioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SueldoDiario to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSueldoDiarioNull() 
			Me(_parent.SueldoDiarioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Descripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."Descripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 60
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
		''' Gets / sets the value of the TypedView field NomDepto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."Nom_Depto"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 40
		''' </remarks>
		Public Property [NomDepto]() As System.String
			Get 
				If IsNomDeptoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NomDeptoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NomDeptoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NomDepto is NULL, False otherwise.
		''' </summary>
		Public Function IsNomDeptoNull() As Boolean
			Return IsNull(_parent.NomDeptoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NomDepto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNomDeptoNull() 
			Me(_parent.NomDeptoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field HorasExtrasTriples<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."HorasExtrasTriples"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [HorasExtrasTriples]() As System.Int32
			Get 
				If IsHorasExtrasTriplesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.HorasExtrasTriplesColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.HorasExtrasTriplesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field HorasExtrasTriples is NULL, False otherwise.
		''' </summary>
		Public Function IsHorasExtrasTriplesNull() As Boolean
			Return IsNull(_parent.HorasExtrasTriplesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field HorasExtrasTriples to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetHorasExtrasTriplesNull() 
			Me(_parent.HorasExtrasTriplesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field HorasExtrasDobles<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."HorasExtrasDobles"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [HorasExtrasDobles]() As System.Int32
			Get 
				If IsHorasExtrasDoblesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.HorasExtrasDoblesColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.HorasExtrasDoblesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field HorasExtrasDobles is NULL, False otherwise.
		''' </summary>
		Public Function IsHorasExtrasDoblesNull() As Boolean
			Return IsNull(_parent.HorasExtrasDoblesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field HorasExtrasDobles to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetHorasExtrasDoblesNull() 
			Me(_parent.HorasExtrasDoblesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field DiasTrabajados<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."DiasTrabajados"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [DiasTrabajados]() As System.Int32
			Get 
				If IsDiasTrabajadosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.DiasTrabajadosColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.DiasTrabajadosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field DiasTrabajados is NULL, False otherwise.
		''' </summary>
		Public Function IsDiasTrabajadosNull() As Boolean
			Return IsNull(_parent.DiasTrabajadosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field DiasTrabajados to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDiasTrabajadosNull() 
			Me(_parent.DiasTrabajadosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SmregionA<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."SMRegionA"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [SmregionA]() As System.Decimal
			Get 
				If IsSmregionANull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SmregionAColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SmregionAColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SmregionA is NULL, False otherwise.
		''' </summary>
		Public Function IsSmregionANull() As Boolean
			Return IsNull(_parent.SmregionAColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SmregionA to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSmregionANull() 
			Me(_parent.SmregionAColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SmregionC<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."SMRegionC"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [SmregionC]() As System.Decimal
			Get 
				If IsSmregionCNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SmregionCColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SmregionCColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SmregionC is NULL, False otherwise.
		''' </summary>
		Public Function IsSmregionCNull() As Boolean
			Return IsNull(_parent.SmregionCColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SmregionC to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSmregionCNull() 
			Me(_parent.SmregionCColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field MesComercial<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."MesComercial"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 2, 0
		''' </remarks>
		Public Property [MesComercial]() As System.Decimal
			Get 
				If IsMesComercialNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.MesComercialColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.MesComercialColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field MesComercial is NULL, False otherwise.
		''' </summary>
		Public Function IsMesComercialNull() As Boolean
			Return IsNull(_parent.MesComercialColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field MesComercial to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetMesComercialNull() 
			Me(_parent.MesComercialColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Factor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwReporteNomina"."Factor"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 9, 4, 0
		''' </remarks>
		Public Property [Factor]() As System.Decimal
			Get 
				If IsFactorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.FactorColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.FactorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Factor is NULL, False otherwise.
		''' </summary>
		Public Function IsFactorNull() As Boolean
			Return IsNull(_parent.FactorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Factor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFactorNull() 
			Me(_parent.FactorColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
